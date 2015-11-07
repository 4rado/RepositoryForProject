using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MissionPlanner.Controls;
using MissionPlanner.Controls.BackstageView;

namespace MissionPlanner.Wizard
{
    public partial class DS_Check_Automatic : MyUserControl, IWizard
    {
        static bool busy;
        int count;

        public DS_Check_Automatic()
        {
            InitializeComponent();
            busy = false;
            count = 1;
            label1.Visible = false;
            button2.Visible = false;
        }

        public int WizardValidate()
        {
            return 1;
        }

        public bool WizardBusy()
        {
            return busy;
        }

        void UpdateInformation()
        {

            MAVLink.mavlink_rc_channels_override_t rc = new MAVLink.mavlink_rc_channels_override_t();
            rc.target_component = MainV2.comPort.MAV.compid;
            rc.target_system = MainV2.comPort.MAV.sysid;
            rc.chan1_raw = 0;
            rc.chan2_raw = 0;
            rc.chan3_raw = 0;
            rc.chan4_raw = 0;
            rc.chan5_raw = 0;
            rc.chan6_raw = 0;
            rc.chan7_raw = 0;
            rc.chan8_raw = 0;
            //this.label1.Text = "1) Включить режим MANUAL. ";
            if (count == 1)
            {
                MainV2.comPort.setMode("Manual");
                MainV2.comPort.MAV.cs.rcoverridech1 = pickChannel(1, -1);
                rc.chan1_raw = pickChannel(1, -1);
                sendPackets(rc);

                this.label1.Text = "1) Проверьте, что левый элерон отклонился вверх, правый вниз.";
            }
            if (count == 2)
            {
                MainV2.comPort.MAV.cs.rcoverridech1 = pickChannel(1, 1);
                rc.chan1_raw = pickChannel(1, 1);
                MainV2.comPort.sendPacket(rc);
                this.label1.Text = "2) Проверьте, что правый элерон отклоняется вверх, левый вниз.";
                sendPackets(rc);
            }
            if (count == 3)
            {
                // Recover state of roll
                MainV2.comPort.MAV.cs.rcoverridech1 = pickChannel(1, 0); 
                MainV2.comPort.MAV.cs.rcoverridech2 = pickChannel(2, -1);
                rc.chan1_raw = pickChannel(1, 0);
                rc.chan2_raw = pickChannel(2, -1);
                sendPackets(rc);
                this.label1.Text = "3) Проверьте, что рули высоты отклоняются вверх.";
            }
            if (count == 4)
            {
                MainV2.comPort.MAV.cs.rcoverridech2 = pickChannel(2, 1);
                rc.chan2_raw = pickChannel(2, 1);
                sendPackets(rc);
                this.label1.Text = "4) Проверьте, что рули высоты отклоняются вниз.";
            }
            if (count == 5)
            {
                // Recover state of pitch
                MainV2.comPort.MAV.cs.rcoverridech2 = pickChannel(2, 0);
                rc.chan2_raw = pickChannel(2, 0);
                // Change the State of rudder
                MainV2.comPort.MAV.cs.rcoverridech4 = pickChannel(4, -1);
                rc.chan4_raw = pickChannel(4, -1);
                sendPackets(rc);
                this.label1.Text = "5) Проверьте, что рули высоты отклоняются влево.";
            }
            if (count == 6)
            {
                MainV2.comPort.MAV.cs.rcoverridech4 = pickChannel(4, 1);
                rc.chan4_raw = pickChannel(4, 1);
                sendPackets(rc);
                this.label1.Text = "6) Проверьте, что  рули высоты отклоняются вправо.";
            }
            if (count == 7)
            {
                MainV2.comPort.MAV.cs.rcoverridech4 = pickChannel(4, 0);
                rc.chan4_raw = pickChannel(4, 0);
                MainV2.comPort.setMode("FBWA");
                this.label1.Text = "7) Проверьте, что левый элерон отклоняется вверх, правый вниз, рули высоты влево.";
            }
            if (count == 8)
            {
                MainV2.comPort.setMode("FBWA");
                this.label1.Text = "8) Проверьте, что правый элерон отклоняется вверх, левый вниз, рули высоты вправо.";
            }
            if (count == 9)
            {
                this.label1.Text = "9) Проверьте, что рули высоты отклоняются вверх.";
            }
            if (count == 10)
            {
                this.label1.Text = "10)Проверьте, что рули высоты отклоняются вниз.";
            }
            if (count == 11)
            {
                this.label1.Text = "11) Наклонить самолет влево – левый элерон отклоняется вниз, правый вверх, рули высоты вправо.\n    Наклонить самолет вправо – правый элерон отклоняется вниз, левый вверх, рули высоты влево.";
            }
            if (count == 12)
            {
                this.label1.Text = "12) Наклонить самолет носом вниз – рули высоты отклоняются вверх. \n    Наклонить самолет носом вверх – рули высоты отклоняются вниз.";
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Visible = true;
            label1.Visible = true;
            UpdateInformation();
            busy = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count++;
            UpdateInformation();
            if (count == 12)
            {
                button2.Text = "Финиш";
            }
            if (count == 13)
            {
                MainV2.comPort.setMode("Manual");
                button2.Visible = false;
                button2.Text = "Продолжить";
                count = 1;
                button1.Enabled = true;
                label1.Visible = false;
                busy = false;
            }
        }
        private ushort pickChannel(ushort chan, int MaxMinTrim)
        {
            int max;
            int min;
            int trim;
            if (MainV2.comPort.MAV.param.ContainsKey("RC" + chan + "_MIN"))
            {
                min = (int)(float)(MainV2.comPort.MAV.param["RC" + chan + "_MIN"]);
                max = (int)(float)(MainV2.comPort.MAV.param["RC" + chan + "_MAX"]);
                trim = (int)(float)(MainV2.comPort.MAV.param["RC" + chan + "_TRIM"]);
            }
            else
            {
                min = 1000;
                max = 2000;
                trim = 1500;
            }
            if (MaxMinTrim == 1)
            {
                return (ushort)max;
            }
            else
            {
                if (MaxMinTrim == -1)
                {
                    return (ushort)min;
                }
                else
                {
                    return (ushort)trim;
                }
            }

        }
        private void sendPackets( object rc )
        {
            MainV2.comPort.sendPacket(rc);
            System.Threading.Thread.Sleep(20);
            MainV2.comPort.sendPacket(rc);
            System.Threading.Thread.Sleep(20);
            MainV2.comPort.sendPacket(rc);
            System.Threading.Thread.Sleep(20);
            MainV2.comPort.sendPacket(rc);
            System.Threading.Thread.Sleep(20);
            MainV2.comPort.sendPacket(rc);
            System.Threading.Thread.Sleep(20);
            MainV2.comPort.sendPacket(rc);

            MainV2.comPort.sendPacket(rc);
            MainV2.comPort.sendPacket(rc);
            MainV2.comPort.sendPacket(rc);
        }
    }
}
