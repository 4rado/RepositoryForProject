using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MissionPlanner.Controls;

namespace MissionPlanner.Wizard
{
    public partial class _1Intro : MyUserControl, IWizard
    {
        public int a;
        Color general;
        Color change;
        public _1Intro()
        {
            InitializeComponent();
            a = 1;
            general = label_1.BackColor;
            change = Color.FromArgb(0,128,0);
            label_1.BackColor = change;
            label_2.Visible = false;
            label_3.Visible = false;
            label_4.Visible = false;
            label_5.Visible = false;
            label_6.Visible = false;
            label_7.Visible = false;
            label_8.Visible = false;
        }

        public int  WizardValidate()
        {
            Wizard.config["fwtype"] = "plane";
            return 1;
        }
        public bool WizardBusy()
        {
            if (a == 9)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if( a < 9 )
                a += 1;
            switch (a)
            {
                case 2:
                    label_1.BackColor = general;
                    label_2.Visible = true;
                    label_2.BackColor = change;
                    break;
                case 3:
                    label_2.BackColor = general;
                    label_3.Visible = true;
                    label_3.BackColor = change;
                    break;
                case 4:
                    label_3.BackColor = general;
                    label_4.Visible = true;
                    label_4.BackColor = change;
                    break;
                case 5:
                    label_4.BackColor = general;
                    label_5.Visible = true;
                    label_5.BackColor = change;
                    break;
                case 6:
                    label_5.BackColor = general;
                    label_6.Visible = true;
                    label_6.BackColor = change;
                    break;
                case 7:
                    label_6.BackColor = general;
                    label_7.Visible = true;
                    label_7.BackColor = change;
                    break;
                case 8:
                    label_7.BackColor = general;
                    label_8.Visible = true;
                    label_8.BackColor = change;
                    break;
                case 9:
                    label_8.BackColor = general;
                    break;
            }
            
        }

       
    }
}
