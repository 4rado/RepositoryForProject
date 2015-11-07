using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MissionPlanner.Controls;
using System.Threading;

namespace MissionPlanner.Wizard
{
    public partial class DialCalib : Form
    {
        byte count = 0;
        bool busy;
        public DialCalib()
        {
            InitializeComponent();
            busy = false;
         // Utilities.ThemeManager.ApplyThemeTo(this);
        }

        public void Calib_Load(object sender, EventArgs e)
        {
            busy = true;
            try
            {
                // start the process off
                MainV2.comPort.doCommand(MAVLink.MAV_CMD.PREFLIGHT_CALIBRATION, 0, 0, 0, 0, 1, 0, 0);
                MainV2.comPort.giveComport = true;
            }
            catch { busy = false; CustomMessageBox.Show(Strings.ErrorNoResponce, Strings.ERROR); return; }
            System.Threading.ThreadPool.QueueUserWorkItem(readmessage, this);
            BUT_continue.Focus();
        }

        public void Calib_Close(object sender, FormClosingEventArgs e)
        {
            if (!MainV2.comPort.BaseStream.IsOpen)
            {
                busy = false;
                return;
            }
            if (busy)
            {
                DialogResult res = MessageBox.Show("Are sure, that you want abort calibration?",
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (res == DialogResult.Yes)
                {
                    busy = false;
                    try
                    {
                        for( byte i = (byte)(count + 1); i < 9; i++)
                        {
                            MainV2.comPort.sendPacket(new MAVLink.mavlink_command_ack_t() { command = 1, result = i });
                            Thread.Sleep(100);
                            MainV2.comPort.readPacket();
                            MainV2.comPort.MAV.cs.UpdateCurrentSettings(null);
                            UpdateUserMessage();
                        }
                        
                    }
                    catch (Exception ex) { CustomMessageBox.Show(Strings.CommandFailed + ex); Wizard.instance.Close(); }
                    MainV2.comPort.MAV.cs.messages.Clear();
                    return;
                    //MainV2.comPort.EraseLog();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        public bool Busy()
        {
            return busy;
            
        }

        private void BUT_continue_Click(object sender, EventArgs e)
        {
            if (BUT_continue.Text == "Finish")
            {
                this.Close();
            }
            else
            {
                count++;
                BUT_continue.Text = "Continue";
            }
            try
            {
                 MainV2.comPort.sendPacket(new MAVLink.mavlink_command_ack_t() { command = 1, result = count });
            }
            catch (Exception ex) { CustomMessageBox.Show(Strings.CommandFailed + ex); Wizard.instance.Close(); }
        }
        static void readmessage(object item)
        {
            DialCalib local = (DialCalib)item;

            // clean up history
            MainV2.comPort.MAV.cs.messages.Clear();
            while (!(MainV2.comPort.MAV.cs.message.ToLower().Contains("calibration successful") || MainV2.comPort.MAV.cs.message.ToLower().Contains("calibration failed")) && local.busy )
            {
                try
                {
                    System.Threading.Thread.Sleep(10);
                    // read the message
                    if (MainV2.comPort.BaseStream.BytesToRead > 4)
                        MainV2.comPort.readPacket();
                    // update cs with the message
                    MainV2.comPort.MAV.cs.UpdateCurrentSettings(null);
                    // update user display
                    local.UpdateUserMessage();
                }
                catch { break; }
            }

            MainV2.comPort.giveComport = false;

            try
            {
                local.CalibDone();
            }
            catch { }
        }

        public void UpdateUserMessage()
        {
            this.Invoke((MethodInvoker)delegate()
            {
                if (MainV2.comPort.MAV.cs.message.ToLower().Contains("initi") ) 
                {
                    if( count == 0 ) 
                        imageLabel1.Image = MissionPlanner.Properties.Resources.calibration01;
                    imageLabel1.Text = MainV2.comPort.MAV.cs.message;
                }
                if (MainV2.comPort.MAV.cs.message.ToLower().Contains("level") )
                {
                    imageLabel1.Image = MissionPlanner.Properties.Resources.calibration01;
                    imageLabel1.Text = MainV2.comPort.MAV.cs.message;
                }
                else if (MainV2.comPort.MAV.cs.message.ToLower().Contains("left") )
                {
                    imageLabel1.Image = MissionPlanner.Properties.Resources.calibration07;
                    imageLabel1.Text = MainV2.comPort.MAV.cs.message;
                }
                else if (MainV2.comPort.MAV.cs.message.ToLower().Contains("right") )
                {
                    imageLabel1.Image = MissionPlanner.Properties.Resources.calibration05;
                    imageLabel1.Text = MainV2.comPort.MAV.cs.message;
                }
                else if (MainV2.comPort.MAV.cs.message.ToLower().Contains("down")  )
                {
                    imageLabel1.Image = MissionPlanner.Properties.Resources.calibration04;
                    imageLabel1.Text = MainV2.comPort.MAV.cs.message;
                }
                else if (MainV2.comPort.MAV.cs.message.ToLower().Contains("up") )
                {
                    imageLabel1.Image = MissionPlanner.Properties.Resources.calibration06;
                    imageLabel1.Text = MainV2.comPort.MAV.cs.message;
                }
                else if (MainV2.comPort.MAV.cs.message.ToLower().Contains("back")  )
                {
                    imageLabel1.Image = MissionPlanner.Properties.Resources.calibration03;
                    imageLabel1.Text = MainV2.comPort.MAV.cs.message;
                }
                else if (MainV2.comPort.MAV.cs.message.ToLower().Contains("calibration")) 
                {
                    imageLabel1.Image = MissionPlanner.Properties.Resources.calibration01;
                    imageLabel1.Text = MainV2.comPort.MAV.cs.message;
                }

                imageLabel1.Refresh();
            });
        }

        public void CalibDone()
        {
            this.Invoke((MethodInvoker)delegate()
            {
                if (count != 6)
                {
                    if (!MainV2.comPort.BaseStream.IsOpen)
                    {
                        this.Close();
                        return;
                    }
                    if (busy)
                    {
                        DialogResult res = MessageBox.Show("Do you want to start calibration again?",
                        "Calibration Failed",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);

                        if (res == DialogResult.Yes)
                        {
                            BUT_continue.Text = "Start";
                            Calib_Load(this, EventArgs.Empty);
                        }
                        else
                        {
                            busy = false;
                            this.Close();
                        }
                    }
                }
                else
                {
                    busy = false;
                    this.BUT_continue.Text = "Finish";
                    count = 0;
                }
            });
        }
    }
}
