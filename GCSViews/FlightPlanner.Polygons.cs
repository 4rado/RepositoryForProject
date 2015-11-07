using System;
using System.Collections.Generic; // Lists
using System.Text; // stringbuilder
using System.Drawing; // pens etc
using System.IO; // file io
using System.IO.Ports; // serial
using System.Windows.Forms; // Forms
using System.Collections; // hashs
using System.Text.RegularExpressions; // regex
using System.Xml; // GE xml alt reader
using System.Net; // dns, ip address
using System.Net.Sockets; // tcplistner
using GMap.NET;
using GMap.NET.WindowsForms;
using System.Globalization; // language
using GMap.NET.WindowsForms.Markers;
using System.Resources;
using System.Reflection;
using System.ComponentModel;
using System.Threading;
using log4net;
using MissionPlanner.Controls;
using MissionPlanner.Utilities;
using MissionPlanner.Controls.BackstageView;
using ProjNet.CoordinateSystems.Transformations;
using ProjNet.CoordinateSystems;
using ProjNet.Converters;
using System.Xml.XPath;
using com.codec.jpeg;
using MissionPlanner;
using GMap.NET.MapProviders;
using MissionPlanner.Maps;
using System.Data;
using DotSpatial.Projections;
using System.Drawing.Drawing2D;

namespace MissionPlanner.GCSViews
{
    partial class FlightPlanner
    {
        internal class Polygon
        {
            public GMapPolygon polygon;
            public GMapOverlay overlay;
            public GMarkerGoogleType markerType;
            public Color color;
            private FlightPlanner host;
            private Brush brush;
            string tag;


            public Polygon(FlightPlanner host, string name, GMarkerGoogleType markerType, Color color, Brush brush, string tag = "")
            {
                this.markerType = markerType;
                this.color = color;
                this.brush = brush;

                //setup drawnpolygon
                List<PointLatLng> list = new List<PointLatLng>();
                polygon = new GMapPolygon(list, name + "poly");
                polygon.Stroke = new Pen(color, 2);
                polygon.Fill = brush;

                overlay = new GMapOverlay(name + "polygonoverlay");
                this.host = host;
                host.MainMap.Overlays.Add(this.overlay);
                this.tag = tag;
            }

            public void update(PointLatLng point)
            {
                if (tag.Equals(""))
                    polygon.Points[int.Parse(host.CurentRectMarker.InnerMarker.Tag.ToString().Replace("grid", "")) - 1] = new PointLatLng(point.Lat, point.Lng);
                else
                    polygon.Points[int.Parse(host.CurentRectMarker.InnerMarker.Tag.ToString().Replace(tag, "").Replace("grid", "")) - 1] = new PointLatLng(point.Lat, point.Lng);
                host.MainMap.UpdatePolygonLocalPosition(polygon);
            }

            public void addPoint(double lat, double lng)
            {
                if (overlay.Polygons.Count == 0)
                {
                    polygon.Points.Clear();
                    overlay.Polygons.Add(polygon);
                }

                polygon.Fill = brush;

                // remove full loop is exists
                if (polygon.Points.Count > 1 && polygon.Points[0] == polygon.Points[polygon.Points.Count - 1])
                    polygon.Points.RemoveAt(polygon.Points.Count - 1); // unmake a full loop

                polygon.Points.Add(new PointLatLng(lat, lng));

                host.addmarkergrid(tag + polygon.Points.Count.ToString(), lng, lat, 0, this);
                host.MainMap.UpdatePolygonLocalPosition(polygon);
                host.MainMap.Invalidate();
            }


            public void redrawPolygonSurvey(List<PointLatLngAlt> list)
            {
                polygon.Points.Clear();
                overlay.Clear();

                int tagg = 0;
                list.ForEach(x =>
                {
                    tagg++;
                    polygon.Points.Add(x);
                    host.addpolygonmarkergrid(tag + tagg.ToString(), x.Lng, x.Lat, 0);
                });

                polygonsoverlay.Polygons.Add(polygon);
                host.MainMap.UpdatePolygonLocalPosition(polygon);
                host.MainMap.Invalidate();
            }

            public void redrawPolygonSurvey(List<PointLatLng> list)
            {
                polygon.Points.Clear();
                overlay.Clear();

                int tagg = 0;
                list.ForEach(x =>
                {
                    tagg++;
                    polygon.Points.Add(x);
                    host.addpolygonmarkergrid(tag + tagg.ToString(), x.Lng, x.Lat, 0);
                });

                polygonsoverlay.Polygons.Add(polygon);
                host.MainMap.UpdatePolygonLocalPosition(polygon);
                host.MainMap.Invalidate();
            }

            public void Clear()
            {
                polygon.Points.Clear();
                overlay.Markers.Clear();
                overlay.Polygons.Clear();
                overlay.Clear();
            }

            public void removePoint(int no)
            {
                polygon.Points.RemoveAt(no - 1);
                overlay.Markers.Clear();

                int a = 1;
                foreach (PointLatLng pnt in polygon.Points)
                {
                    host.addmarkergrid(tag + a.ToString(), pnt.Lng, pnt.Lat, 0, this);
                    a++;
                }

                host.MainMap.UpdatePolygonLocalPosition(polygon);
            }

            public void addRect(PointLatLng p1, PointLatLng p2, PointLatLng p3, PointLatLng p4)
            {
                Clear();
                addPoint(p1.Lat, p1.Lng);
                addPoint(p2.Lat, p2.Lng);
                addPoint(p3.Lat, p3.Lng);
                addPoint(p4.Lat, p4.Lng);

            }

        };

        class MultiPolygon
        {
            private Dictionary<int, Polygon> polygons;
            private int current;
            private int Count;
            private FlightPlanner host;

            public MultiPolygon(FlightPlanner host)
            {
                polygons = new Dictionary<int, Polygon>();
                current = -1;
                Count = 0;
                this.host = host;
            }
            public int CountPolygons()
            {
                return this.Count;
            }

            public void AddNewPolygon()
            {
                polygons.Add(Count, new Polygon(host, "red" + Count.ToString(), GMarkerGoogleType.red, Color.Red, new SolidBrush(Color.FromArgb(30, Color.Red)), Count.ToString() + "\\"));
                current = Count;
                Count++;
            }

            public void update(PointLatLng point)
            {
                string[] tag = host.CurentRectMarker.InnerMarker.Tag.ToString().Replace("grid", "").Split(new Char[] { '\\' });

                polygons[int.Parse(tag[0])].polygon.Points[int.Parse(tag[1]) - 1] = new PointLatLng(point.Lat, point.Lng);
                host.MainMap.UpdatePolygonLocalPosition(polygons[int.Parse(tag[0])].polygon);

            }

            public void addPoint(double lat, double lng)
            {
                if (current < 0)
                    AddNewPolygon();

                polygons[current].addPoint(lat, lng);

            }
            public void removePoint(int poly, int point)
            {
                polygons[poly].removePoint(point);
            }

            public void Clear(object tag)
            {
                int poly = int.Parse(tag.ToString().Replace("grid", "").Split(new Char[] { '\\' })[0]);
                polygons[poly].Clear();
                polygons.Remove(poly);
                current = -1;
            }

            public void setCurrent(object tag)
            {
                current = int.Parse(tag.ToString().Replace("grid", "").Split(new Char[] { '\\' })[0]);
            }

            public void Clear()
            {
                polygons.Clear();
                Count = 0;
                current = -1;
            }

            public Dictionary<int, Polygon> getAllPolygons()
            {
                return this.polygons;
            }

            public Polygon getPoly(int poly)
            {
                return polygons[poly];
            }

            public Polygon getCurrentPoly()
            {
                if (current < 0)
                {
                    AddNewPolygon();
                }
                return polygons[current];
            }
        };

    }
}