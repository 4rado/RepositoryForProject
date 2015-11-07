using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MissionPlanner.Controls;
using System.IO;
using System.Threading;

namespace MissionPlanner.Wizard
{
    public partial class _5AccelCalib : MyUserControl, IWizard, IActivate , IDeactivate
    {
        byte count = 0;
        bool accelDispalying = true;
        static bool busy = false;
        DateTime lastScreenUpdate;
        Thread accel_thread;
        bool thread_started = false;
        DialCalib calibration;

        public _5AccelCalib()
        {
            InitializeComponent();
            hudWizard.Enabled = true;
            hudWizard.WizardMode();
            lastScreenUpdate = DateTime.Now;
            calibration = new DialCalib();
        }
        public int WizardValidate()
        {
            
            return 1;
        }

        public bool WizardBusy()
        {
            busy = calibration.Busy();
            return busy;
        }


        private void BUT_start_Click(object sender, EventArgs e)
        {
         
            ((MyButton)sender).Enabled = false;
            accelDispalying = false; // stop displaying accelerometr horizon
            if (thread_started)
            {
                accel_thread.Abort();
                thread_started = false;
            }

            busy = true;

            calibration.ShowDialog();
            timer1.Start();
        }
        private void updateAccelerometrDisplay()
        {
            while (accelDispalying && MainV2.comPort.BaseStream.IsOpen )
            {
                MainV2.comPort.requestDatastream(MAVLink.MAV_DATA_STREAM.EXTENDED_STATUS, MainV2.comPort.MAV.cs.ratestatus); // mode
                MainV2.comPort.requestDatastream(MAVLink.MAV_DATA_STREAM.POSITION, MainV2.comPort.MAV.cs.rateposition); // request gps
                MainV2.comPort.requestDatastream(MAVLink.MAV_DATA_STREAM.EXTRA1, MainV2.comPort.MAV.cs.rateattitude); // request attitude
                MainV2.comPort.requestDatastream(MAVLink.MAV_DATA_STREAM.EXTRA2, MainV2.comPort.MAV.cs.rateattitude); // request vfr
                MainV2.comPort.requestDatastream(MAVLink.MAV_DATA_STREAM.EXTRA3, MainV2.comPort.MAV.cs.ratesensors); // request extra stuff - tridge
                MainV2.comPort.requestDatastream(MAVLink.MAV_DATA_STREAM.RAW_SENSORS, MainV2.comPort.MAV.cs.ratesensors); // request raw sensor
                MainV2.comPort.requestDatastream(MAVLink.MAV_DATA_STREAM.RC_CHANNELS, MainV2.comPort.MAV.cs.raterc); // request rc inf
                MainV2.comPort.logreadmode = false;
                if (MainV2.comPort.logreadmode && MainV2.comPort.logplaybackfile != null)
                {
                    if (MainV2.comPort.BaseStream.IsOpen)
                    {
                        MainV2.comPort.logreadmode = false;
                        MainV2.comPort.logplaybackfile.Close();
                        MainV2.comPort.logplaybackfile = null;
                    }
                }
                MainV2.comPort.readPacket();
                updateBindingSource();
            }          
        }
        
        private void updateBindingSource()
        {

            // 25 Hz
            if ( this.lastScreenUpdate.AddMilliseconds(40) < DateTime.Now)
            {
                this.BeginInvoke((MethodInvoker)delegate()
                {
                        MainV2.comPort.MAV.cs.UpdateCurrentSettings(this.bindingSourceHud);
                });
                this.lastScreenUpdate = DateTime.Now;
            }
        }
        public void Activate()
        {
            thread_started = true;
            accelDispalying = true;
            accel_thread = new Thread(updateAccelerometrDisplay);
            accel_thread.Start();
        }

        public void Deactivate()
        {
            if (thread_started == true)
            {
                accelDispalying = false;
                accel_thread.Abort();
                thread_started = false;
            }
        }
        public void AccelCalib_Close()
        {
            accelDispalying = false;
            accel_thread.Abort();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!calibration.Busy() )
            {
                timer1.Stop();
                accelDispalying = true;
                accel_thread = new Thread(updateAccelerometrDisplay);
                accel_thread.Start();
                thread_started = true;
                BUT_start.Enabled = true;
                calibration = new DialCalib();
            }
        }
    }
}
