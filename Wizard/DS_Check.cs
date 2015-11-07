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
    public partial class DS_Check : MyUserControl, IActivate, IDeactivate, IWizard
    {
        static bool busy;
        int count;
        
        public DS_Check()
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
            if (count == 1)
            {
                this.label1.Text = "1) Включить режим MANUAL. ";
            }
            if (count == 2)
            {
                this.label1.Text = "2) Отклонить ручку управления влево – левый элерон отклоняется вверх, правый вниз.\n    Отклонить ручку управления вправо  - правый элерон отклоняется вверх, левый вниз.";
            }
            if (count == 3)
            {
                this.label1.Text = "3) Отклонить ручку управления на себя – рули высоты отклоняются вверх.\n    Отклонить ручку управления от себя – рули высоты отклоняются вниз.";
            }
            if (count == 4)
            {
                this.label1.Text = "4) Отклонить ручку управления по курсу влево – рули высоты отклоняются влево.\n    Отклонить ручку управления по курсу вправо – рули высоты отклоняются вправо.";
            }
            if (count == 5)
            {
                this.label1.Text = "5) Включить режим FBWA, самолет установить горизонтально.";
            }
            if (count == 6)
            {
                this.label1.Text = "6) Отклонить ручку управления влево – левый элерон отклоняется вверх, правый вниз, рули высоты влево.\n    Отклонить ручку управления вправо – правый элерон отклоняется вверх, левый вниз, рули высоты вправо.";
            }
            if (count == 7)
            {
                this.label1.Text = "7) Отклонить ручку управления на себя – рули высоты отклоняются вверх.\n    Отклонить ручку управления от себя – рули высоты отклоняются вниз.";
            }
            if (count == 8)
            {
                this.label1.Text = "8) Наклонить самолет влево – левый элерон отклоняется вниз, правый вверх, рули высоты вправо.\n    Наклонить самолет вправо – правый элерон отклоняется вниз, левый вверх, рули высоты влево.";
            }
            if (count == 9)
            {
                this.label1.Text = "9) Наклонить самолет носом вниз – рули высоты отклоняются вверх. \n    Наклонить самолет носом вверх – рули высоты отклоняются вниз.";
            }
            if (count == 10)
            {
                this.label1.Text = "10) Включить режим MANUAL";
            }
        }

        public void Activate()
        {
            timer1.Start();
        }
       
        public void Deactivate()
        {
            timer1.Stop();
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
            if (count == 10)
            {
                button2.Text = "Финиш";
            }
            if (count == 11)
            {
                button2.Visible = false;
                button2.Text = "Продолжить";
                count = 1;
                button1.Enabled = true;
                label1.Visible = false;
                busy = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = "Mode:" + MainV2.comPort.MAV.cs.mode;
        }
    }
}
