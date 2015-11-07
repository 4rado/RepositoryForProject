using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CreateMap
{
    public partial class Form1 : Form
    {
        const int _SFM_PROC = 10;
        const int _CMP_PROC = 11;
        const int _SFM_PAUSE = 100;
        const int _CMP_PAUSE = 101;
        string ImagePath;
        string LogPath;
        string outPath;
        static string pathToVisualSFM = @"\VisualSFM\VisualSFM.exe";
        static string pathToCMPMVS = @"\CMPMVS.exe";
        Process procSFM;
        Process procCMPMVS;
        bool pause = true;
        int runState = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text == "" || textBox1.Text == ""))// || LogPath == null))
            {
                if(!pause)
                    doPause();
                else
                    doRun();
            }
            else
            {
                MessageBox.Show("Выберите путь к папке с изображениями и пусть для сохранения мкрты");
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            ImagePath = fbd.SelectedPath;
            textBox1.Text = ImagePath;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            textBox2.Text = fbd.SelectedPath;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (runState == 1)
                {
                    if (procSFM.HasExited == true)
                        startCMPMVS();
                    else
                        doSFM();
                };
                if (runState == 2)
                    if (procCMPMVS.HasExited == true)
                    {
                        turnToBegin();
                        label1.Text = "all done";
                    }
                    else
                        doCMPMVS();
            }
            catch (Exception e1)
            {
            };
            progressBar1.PerformStep();
        }
        void startSFM()
        {
            runState = 1;
            label1.Text = "Шаг 1 из 3 : нахождение позиций камер";
            procSFM = new Process();
            procSFM.StartInfo.FileName = pathToVisualSFM;
            procSFM.StartInfo.UseShellExecute = false;
            procSFM.StartInfo.CreateNoWindow = false;
            //procSFM.StartInfo.RedirectStandardOutput = true;
            procSFM.StartInfo.Arguments = "sfm+cmp " + ImagePath + " " + outPath + @"\result";
            //procSFM.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
            procSFM.Start();
        }

        

        void startCMPMVS()
        {
            runState = 2;
            label1.Text = "Шаг 2 из 3 : создание карты";
            procCMPMVS = new Process();
            procCMPMVS.StartInfo.FileName = pathToCMPMVS;
            procCMPMVS.StartInfo.UseShellExecute = false;
            procCMPMVS.StartInfo.CreateNoWindow = false;
            //procCMPMVS.StartInfo.RedirectStandardOutput = true;
            procCMPMVS.StartInfo.Arguments = outPath + @"\result.nvm.cmp\00\mvs.ini doComputeDEMandOrtoPhoto=TRUE ";
            //procCMPMVS.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
            procCMPMVS.Start();
        }

        void doSFM()
        {           
            while (!procSFM.StandardOutput.EndOfStream) 
            {
                    string line = procSFM.StandardOutput.ReadLine();
                    listBox1.Items.Add(line);
            };
        }

        void doCMPMVS()
        {           
            while (!procCMPMVS.StandardOutput.EndOfStream) 
            {
                string line = procCMPMVS.StandardOutput.ReadLine();
                listBox1.Items.Add(line);
            };
        }
        void turnToBegin()
        {
            label1.Text = "";
            listBox1.Items.Clear();
            timer1.Enabled = false;
            runState = 0;
            button1.Text = "Запуск";
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Visible = false;
            progressBar1.Value = 0;
            try
            {
                procCMPMVS.Kill();                
            }
            catch (Exception e2)
            {
            }; 
            try
            {
                procSFM.Kill();
            }
            catch (Exception e2)
            {
            };
        }
        void doPause()
        {
            pause = true;
            timer1.Enabled = false;
            button1.Text = "Запуск";
            progressBar1.Value = 0;
            try
            {               
                if(runState == 1)
                {
                    runState = 0;
                    if(procSFM != null)
                        if(!procSFM.HasExited)
                            procSFM.Kill();
                    turnToBegin();
                    return ;
                };
            }
            catch (Exception e)
            {
            };
            try
            {
                if(runState == 2)
                {
                    runState = 1;
                    if (procCMPMVS != null)
                        if(!procCMPMVS.HasExited)
                            procCMPMVS.Kill();
                    return ;
                };
            }
            catch (Exception e)
            {
            };
        }
        void doBegin()
        {
            button2.Enabled = false;
            button3.Enabled = false;
            ImagePath = textBox1.Text ;
            outPath = textBox2.Text;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            timer1.Enabled = true;
            button4.Visible = true;
        }

        void doRun()
        {            
            button1.Text = "Пауза";
            pause = false;
            try
            {
                if (runState == 0)
                {
                    doBegin();
                    startSFM();
                    return;
                };
                if (runState == 1)
                {
                    startCMPMVS();
                    return;
                };
            }
            catch (Exception e)
            {
            };
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Меньше информаци")
            {
                button5.Text = "Больше информаци";
                this.Height = 188;
                listBox1.Visible = false;
            }
            else
            {
                button5.Text = "Меньше информаци";
                if (this.Height < 400)
                    this.Height = 400;
                listBox1.Visible = true;
            };
        }

        private void button4_Click(object sender, EventArgs e)
        {
            turnToBegin();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            turnToBegin();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Application.ExecutablePath;
            int i = path.Length-1;
            while(path[i] != '\\')
                --i;
            path = path.Remove(i);
            pathToVisualSFM = path + pathToVisualSFM;
            pathToCMPMVS = path + pathToCMPMVS;
        }
        
    }

}
