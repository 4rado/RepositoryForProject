using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MissionPlanner.Controls;
using GMap.NET;
using GMap.NET.WindowsForms;
using System.Globalization; // language
using GMap.NET.WindowsForms.Markers;
using ZedGraph; // Graphs
using System.Drawing.Drawing2D;
using MissionPlanner.Utilities;
using MissionPlanner.Controls.BackstageView;
//using Crom.Controls.Docking;
using log4net;
using System.Reflection;
using MissionPlanner.Log;
using GMap.NET.MapProviders;
using System.IO; // file io
using System.IO.Ports; // serial
using System.Collections; // hashs
using System.Text.RegularExpressions; // regex
using System.Xml; // GE xml alt reader
using System.Net; // dns, ip address
using System.Net.Sockets; // tcplistner
using System.Threading;

namespace MissionPlanner.Wizard
{
    public partial class _6CompassCalib : MyUserControl, IWizard, IActivate, IDeactivate
    {
        private float prevDegree;
        internal PointLatLng MouseDownStart = new PointLatLng();
        internal static GMapOverlay tfrpolygons;
        internal static GMapOverlay kmlpolygons;
        internal static GMapOverlay geofence;
        internal static GMapOverlay rallypointoverlay;
        internal static GMapOverlay poioverlay = new GMapOverlay("POI"); // poi layer
        GMapOverlay polygons;
        GMapOverlay routes;
        PointLatLng portlocation;
        public _6CompassCalib()
        {
            InitializeComponent();

            // map configuring
            gMapControl1.CacheLocation = Path.GetDirectoryName(Application.ExecutablePath) + Path.DirectorySeparatorChar + "gmapcache" + Path.DirectorySeparatorChar;
            gMapControl1.MapProvider = GoogleMapProvider.Instance;
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 24 - vScrollBar1.Value;
            gMapControl1.DisableFocusOnMouseEnter = true;
            gMapControl1.RoutesEnabled = true;
            gMapControl1.PolygonsEnabled = true;

            tfrpolygons = new GMapOverlay("tfrpolygons");
            gMapControl1.Overlays.Add(tfrpolygons);
            tfrpolygons.IsVisibile = true;

            kmlpolygons = new GMapOverlay("kmlpolygons");
            gMapControl1.Overlays.Add(kmlpolygons);
            kmlpolygons.IsVisibile = true;

            geofence = new GMapOverlay("geofence");
            gMapControl1.Overlays.Add(geofence);
            geofence.IsVisibile = true;
            
            polygons = new GMapOverlay("polygons");
            gMapControl1.Overlays.Add(polygons);
            polygons.IsVisibile = true;
            
            routes = new GMapOverlay("routes");
            gMapControl1.Overlays.Add(routes);
            routes.IsVisibile = true;
            portlocation = new PointLatLng(MainV2.comPort.MAV.cs.lat, MainV2.comPort.MAV.cs.lng);

            routes.Markers.Add(new GMapMarkerPlane(portlocation, MainV2.comPort.MAV.cs.yaw, MainV2.comPort.MAV.cs.groundcourse, MainV2.comPort.MAV.cs.nav_bearing, MainV2.comPort.MAV.cs.target_bearing) { ToolTipText = MainV2.comPort.MAV.cs.alt.ToString("0"), ToolTipMode = MarkerTooltipMode.Always });
            routes.Dispose();

            rallypointoverlay = new GMapOverlay("rally points");
            gMapControl1.Overlays.Add(rallypointoverlay);
            rallypointoverlay.IsVisibile = true;

            gMapControl1.Overlays.Add(poioverlay);
            gMapControl1.Position = new PointLatLng(MainV2.comPort.MAV.cs.lat, MainV2.comPort.MAV.cs.lng);
            poioverlay.IsVisibile = true;
            prevDegree = 0;     
        }

        public int WizardValidate()
        {
            return 1; // было 1
        }

        public bool WizardBusy()
        {
            return false;
        }
        public void Activate()
        {
            timer1.Start();
            timer2.Start();
            routes.Dispose();
        }

        public void Deactivate()
        {
            timer1.Stop();
            timer2.Stop();
        }


        private void BUT_MagCalibration_Click(object sender, EventArgs e)
        {
            if (!MainV2.comPort.BaseStream.IsOpen)
            {
                CustomMessageBox.Show(Strings.ErrorNotConnected, Strings.ERROR);
                Wizard.instance.Close();
            }

            try
            {
                MainV2.comPort.MAV.cs.ratesensors = 2;

                MainV2.comPort.requestDatastream(MAVLink.MAV_DATA_STREAM.EXTRA3, MainV2.comPort.MAV.cs.ratesensors);
                MainV2.comPort.requestDatastream(MAVLink.MAV_DATA_STREAM.RAW_SENSORS, MainV2.comPort.MAV.cs.ratesensors);

                MainV2.comPort.setParam("MAG_ENABLE", 1);
            }
            catch
            {
                CustomMessageBox.Show(Strings.ErrorNotConnected, Strings.ERROR);
                Wizard.instance.Close();
            }

            MagCalib.DoGUIMagCalib();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=DmsueBS0J3E");
            }
            catch { CustomMessageBox.Show("Your default http association is not set correctly."); }
        }

        int step = 0;
        HIL.Vector3 north;
        HIL.Vector3 east;
        HIL.Vector3 south;
        HIL.Vector3 west;


        const float rad2deg = (float)(180 / Math.PI);
        const float deg2rad = (float)(1.0 / rad2deg);

        float calcheading(HIL.Vector3 mag)
        {
            HIL.Matrix3 dcm_matrix = new HIL.Matrix3();
            dcm_matrix.from_euler(0, 0, 0);

            // Tilt compensated magnetic field Y component:
            double headY = mag.y * dcm_matrix.c.z - mag.z * dcm_matrix.c.y;

            // Tilt compensated magnetic field X component:
            double headX = mag.x + dcm_matrix.c.x * (headY - mag.x * dcm_matrix.c.x);

            // magnetic heading
            // 6/4/11 - added constrain to keep bad values from ruining DCM Yaw - Jason S.
            double heading = constrain_float((float)Math.Atan2(-headY, headX), -3.15f, 3.15f);

            return (float)((heading * rad2deg) + 360) % 360f;
        }

        float constrain_float(float input, float min, float max)
        {
            if (input > max)
                return max;
            if (input < min)
                return min;
            return input;
        }


        bool docalc()
        {
            try
            {
                //  HIL.Vector3 magoff = new HIL.Vector3((float)MainV2.comPort.MAV.param["COMPASS_OFS_X"], (float)MainV2.comPort.MAV.param["COMPASS_OFS_Y"], (float)MainV2.comPort.MAV.param["COMPASS_OFS_Z"]);
                //north -= magoff;
                //east -= magoff;
                //south -= magoff;
                //west -= magoff;
            }
            catch { }

            foreach (Common.Rotation item in Enum.GetValues(typeof(Common.Rotation)))
            {
                // copy them, as we dont want to change the originals
                HIL.Vector3 northc = new HIL.Vector3(north);
                HIL.Vector3 eastc = new HIL.Vector3(east);
                HIL.Vector3 southc = new HIL.Vector3(south);
                HIL.Vector3 westc = new HIL.Vector3(west);

                northc.rotate(item);
                eastc.rotate(item);
                southc.rotate(item);
                westc.rotate(item);

                // test the copies
                if (withinMargin(calcheading(northc), 35, 0))
                {
                    if (withinMargin(calcheading(eastc), 35, 90))
                    {
                        if (withinMargin(calcheading(southc), 35, 180))
                        {
                            if (withinMargin(calcheading(westc), 35, 270))
                            {
                                Console.WriteLine("Rotation " + item.ToString());
                                //label5.Text = "Done Rotation: " + item.ToString();
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }

        bool withinMargin(float value, float margin, float target)
        {
            // to prevent the near 0 issues
            value += 360;
            target += 360;

            Console.WriteLine("{0} = {1} within +-{2}", value % 360, target % 360, margin);

            if (value >= (target - margin))
            {
                if (value <= (target + margin))
                {
                    return true;
                }
            }
            return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float target = (MainV2.comPort.MAV.cs.yaw % 90);

            if (target > 45)
                target -= 90f;

        }


        public static Bitmap RotateImage(Image image, PointF offset, float angle)
        {
            if (image == null)
                throw new ArgumentNullException("image");

            //create a new empty bitmap to hold rotated image
            Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
            rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            //make a graphics object from the empty bitmap
            Graphics g = Graphics.FromImage(rotatedBmp);

            //Put the rotation point in the center of the image
            g.TranslateTransform(offset.X, offset.Y);

            //rotate the image
            g.RotateTransform(angle);

            //move the image back
            g.TranslateTransform(-offset.X, -offset.Y);

            //draw passed in image onto graphics object
            PointF point = new PointF(0, 0);
            g.DrawImage(image, point);

            return rotatedBmp;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            gMapControl1.HoldInvalidation = true;
          // // portlocation = new PointLatLng(MainV2.comPort.MAV.cs.lat, MainV2.comPort.MAV.cs.lng);
          //  routes.Markers.Add(new GMapMarkerPlane(portlocation, MainV2.comPort.MAV.cs.yaw, MainV2.comPort.MAV.cs.groundcourse, MainV2.comPort.MAV.cs.nav_bearing, MainV2.comPort.MAV.cs.target_bearing) { ToolTipText = MainV2.comPort.MAV.cs.alt.ToString("0"), ToolTipMode = MarkerTooltipMode.Always });
           // addpolygonmarker("Guided Mode", MainV2.comPort.MAV.GuidedMode.y, MainV2.comPort.MAV.GuidedMode.x, (int)MainV2.comPort.MAV.GuidedMode.z, Color.Blue, routes);
            gMapControl1.Position = new PointLatLng(MainV2.comPort.MAV.cs.lat, MainV2.comPort.MAV.cs.lng);
            pictureBox1.Image = (Image)RotateImage((Bitmap)pictureBox1.Image, new PointF(pictureBox1.Image.Height / 2, pictureBox1.Image.Width / 2), MainV2.comPort.MAV.cs.yaw - prevDegree);
            prevDegree = MainV2.comPort.MAV.cs.yaw;
            //gMapControl1.HoldInvalidation = false;
            //gMapControl1.Invalidate();
           
           // routes.Markers.Add(new GMarkerGoogle(portlocation, GMarkerGoogleType.blue_dot) { Position = MainV2.comPort.MAV.cs.MovingBase, ToolTipText = "Moving Base", ToolTipMode = MarkerTooltipMode.OnMouseOver });
        //    gMapControl1.HoldInvalidation = false;
          //  gMapControl1.Invalidate();
        }


        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            gMapControl1.Zoom = 24 - vScrollBar1.Value;
        }
    }
}