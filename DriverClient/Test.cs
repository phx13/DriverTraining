using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace DriverClient
{
    public partial class Test : Form, IDisposable
    {
        public Test()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            SetStyle(System.Windows.Forms.ControlStyles.UserPaint, true);
            SetStyle(System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(System.Windows.Forms.ControlStyles.DoubleBuffer, true);
            SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(System.Windows.Forms.ControlStyles.ResizeRedraw, true);
            //MyUDPSocket.Init();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams p = base.CreateParams;
                p.ExStyle |= 0 * 02000000;
                return p;
            }
        }

        private void Test_Load(object sender, EventArgs e)
        {
            t1ttL.Location = new Point(340, 50);
            t2ttL.Location = new Point(340, 50);
            t3ttL.Location = new Point(240, 50);
            t4ttL.Location = new Point(240, 50);
            t5ttL.Location = new Point(340, 50);
            t6ttL.Location = new Point(340, 50);

            CurrentScoreLabel.Location = new Point(85, 800);
            ScoreRichTextBox.Location = new Point(1292, 0);

            t1t1L.Location = new Point(160, 45);
            t1t2L.Location = new Point(155, 45);
            t1t3L.Location = new Point(135, 45);
            t1t4L.Location = new Point(160, 45);

            t2t1L.Location = new Point(195, 45);

            t3t1L.Location = new Point(150, 45);
            t3t2L.Location = new Point(150, 45);
            t3t3L.Location = new Point(150, 45);
            t3t4L.Location = new Point(200, 45);
            t3t5L.Location = new Point(200, 45);
            t3t6L.Location = new Point(200, 45);
            t3t7L.Location = new Point(150, 45);
            t3t8L.Location = new Point(150, 45);

            t4t1L.Location = new Point(65, 45);

            t5t1L.Location = new Point(195, 45);

            t6t1L.Location = new Point(195, 45);

            FileSystemWatcher fWatcher = new FileSystemWatcher();
            fWatcher.Path = path + "\\";
            fWatcher.Filter = "log.txt";
            fWatcher.NotifyFilter = NotifyFilters.Size;
            fWatcher.Changed += new FileSystemEventHandler(Changed);
            fWatcher.EnableRaisingEvents = true;
            //MyUDPSocket.Receive();
        }

        private void Test_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (Gamepanel.Visible == true)
                {
                    if (myExe != null)
                    {
                        myExe.Stop();
                    }
                    ScoreRichTextBox.Text = "";
                    CurrentScoreLabel.Text = "当前分数：5";
                    Gamepanel.Controls.Clear();
                    Gamepanel.Visible = false;
                    Startbutton.Visible = false;
                }
                else
                {
                    t1tt.Visible = false;
                    t2tt.Visible = false;
                    t3tt.Visible = false;
                    t4tt.Visible = false;
                    t5tt.Visible = false;
                    t6tt.Visible = false;

                    t1t1.Visible = false;
                    t1t2.Visible = false;
                    t1t3.Visible = false;
                    t1t4.Visible = false;

                    t2t1.Visible = false;

                    t3t1.Visible = false;
                    t3t2.Visible = false;
                    t3t3.Visible = false;
                    t3t4.Visible = false;
                    t3t5.Visible = false;
                    t3t6.Visible = false;
                    t3t7.Visible = false;
                    t3t8.Visible = false;

                    t4t1.Visible = false;

                    t5t1.Visible = false;

                    t6t1.Visible = false;
                    this.Close();                
                }
            }
        }

        #region Mousehover
        private void t1t1_MouseEnter(object sender, EventArgs e)
        {
            t1t1L.ForeColor = Color.OrangeRed;
        }

        private void t1t1_MouseLeave(object sender, EventArgs e)
        {
            t1t1L.ForeColor = Color.White;
        }

        private void t1t2_MouseEnter(object sender, EventArgs e)
        {
            t1t2L.ForeColor = Color.OrangeRed;
        }

        private void t1t2_MouseLeave(object sender, EventArgs e)
        {
            t1t2L.ForeColor = Color.White;
        }

        private void t1t3_MouseEnter(object sender, EventArgs e)
        {
            t1t3L.ForeColor = Color.OrangeRed;
        }

        private void t1t3_MouseLeave(object sender, EventArgs e)
        {
            t1t3L.ForeColor = Color.White;
        }

        private void t1t4_MouseEnter(object sender, EventArgs e)
        {
            t1t4L.ForeColor = Color.OrangeRed;
        }

        private void t1t4_MouseLeave(object sender, EventArgs e)
        {
            t1t4L.ForeColor = Color.White;
        }

        private void t2t1_MouseEnter(object sender, EventArgs e)
        {
            t2t1L.ForeColor = Color.OrangeRed;
        }

        private void t2t1_MouseLeave(object sender, EventArgs e)
        {
            t2t1L.ForeColor = Color.White;
        }

        private void t3t1_MouseEnter(object sender, EventArgs e)
        {
            t3t1L.ForeColor = Color.OrangeRed;
        }

        private void t3t1_MouseLeave(object sender, EventArgs e)
        {
            t3t1L.ForeColor = Color.White;
        }

        private void t3t2_MouseEnter(object sender, EventArgs e)
        {
            t3t2L.ForeColor = Color.OrangeRed;
        }

        private void t3t2_MouseLeave(object sender, EventArgs e)
        {
            t3t2L.ForeColor = Color.White;
        }

        private void t3t3_MouseEnter(object sender, EventArgs e)
        {
            t3t3L.ForeColor = Color.OrangeRed;
        }

        private void t3t3_MouseLeave(object sender, EventArgs e)
        {
            t3t3L.ForeColor = Color.White;
        }
        private void t3t4_MouseEnter(object sender, EventArgs e)
        {
            t3t4L.ForeColor = Color.OrangeRed;
        }

        private void t3t4_MouseLeave(object sender, EventArgs e)
        {
            t3t4L.ForeColor = Color.White;
        }

        private void t3t5_MouseEnter(object sender, EventArgs e)
        {
            t3t5L.ForeColor = Color.OrangeRed;
        }

        private void t3t5_MouseLeave(object sender, EventArgs e)
        {
            t3t5L.ForeColor = Color.White;
        }

        private void t3t6_MouseEnter(object sender, EventArgs e)
        {
            t3t6L.ForeColor = Color.OrangeRed;
        }

        private void t3t6_MouseLeave(object sender, EventArgs e)
        {
            t3t6L.ForeColor = Color.White;
        }

        private void t3t7_MouseEnter(object sender, EventArgs e)
        {
            t3t7L.ForeColor = Color.OrangeRed;
        }

        private void t3t7_MouseLeave(object sender, EventArgs e)
        {
            t3t7L.ForeColor = Color.White;
        }
        private void t3t8_MouseEnter(object sender, EventArgs e)
        {
            t3t8L.ForeColor = Color.OrangeRed;
        }

        private void t3t8_MouseLeave(object sender, EventArgs e)
        {
            t3t8L.ForeColor = Color.White;
        }

        private void t4t1_MouseEnter(object sender, EventArgs e)
        {
            t4t1L.ForeColor = Color.OrangeRed;
        }

        private void t4t1_MouseLeave(object sender, EventArgs e)
        {
            t4t1L.ForeColor = Color.White;
        }

        private void t5t1_MouseEnter(object sender, EventArgs e)
        {
            t5t1L.ForeColor = Color.OrangeRed;
        }

        private void t5t1_MouseLeave(object sender, EventArgs e)
        {
            t5t1L.ForeColor = Color.White;
        }

        private void t6t1_MouseEnter(object sender, EventArgs e)
        {
            t6t1L.ForeColor = Color.OrangeRed;
        }

        private void t6t1_MouseLeave(object sender, EventArgs e)
        {
            t6t1L.ForeColor = Color.White;
        }
        #endregion

        #region Click
        MyEXEClass myExe = null;
        Option option = new Option();

        public void OpenOption(string infoArg)
        {
            StreamWriter sw = new StreamWriter(path + "\\OptionLog.txt",false);
            sw.Write(infoArg);
            sw.Close();

            switch (infoArg)
            {
                case "t1t1":
                    option.L1.Text = "低速档驾驶。。。";
                    option.L2.Text = "低速档驾驶。。。";
                    break;
                case "t1t2":
                    option.L1.Text = "依次换挡驾驶。。。";
                    option.L2.Text = "依次换挡驾驶。。。";
                    break;
                case "t1t3":
                    option.L1.Text = "重点难点动作驾驶。。。";
                    option.L2.Text = "重点难点动作驾驶。。。";
                    break;
                case "t1t4":
                    option.L1.Text = "各种速度驾驶。。。";
                    option.L2.Text = "各种速度驾驶。。。";
                    break;
                case "t2t1":
                    option.L1.Text = "坡上驾驶。。。";
                    option.L2.Text = "坡上驾驶。。。";
                    break;
                case "t3t1":
                    option.L1.Text = "直线桩间限制路。。。";
                    option.L2.Text = "直线桩间限制路。。。";
                    break;
                case "t3t2":
                    option.L1.Text = "下坡桩间限制路。。。";
                    option.L2.Text = "下坡桩间限制路。。。";
                    break;
                case "t3t3":
                    option.L1.Text = "“S”型限制路。。。";
                    option.L2.Text = "“S”型限制路。。。";
                    break;
                case "t3t4":
                    option.L1.Text = "车辙桥。。。";
                    option.L2.Text = "车辙桥。。。";
                    break;
                case "t3t5":
                    option.L1.Text = "土岭。。。";
                    option.L2.Text = "土岭。。。";
                    break;
                case "t3t6":
                    option.L1.Text = "弹坑。。。";
                    option.L2.Text = "弹坑。。。";
                    break;
                case "t3t7":
                    option.L1.Text = "弯道限制路。。。";
                    option.L2.Text = "弯道限制路。。。";
                    break;
                case "t3t8":
                    option.L1.Text = "双直角限制路。。。";
                    option.L2.Text = "双直角限制路。。。";
                    break;
                case "t4t1":
                    option.L1.Text = "连续限制路和障碍物驾驶。。。";
                    option.L2.Text = "连续限制路和障碍物驾驶。。。";
                    break;
                case "t5t1":
                    option.L1.Text = "道路驾驶。。。";
                    option.L2.Text = "道路驾驶。。。";
                    break;
                case "t6t1":
                    option.L1.Text = "行军驾驶。。。";
                    option.L2.Text = "行军驾驶。。。";
                    break;
                default:
                    option.L1.Text = "";
                    option.L2.Text = "";
                    break;
            }

            Gamepanel.BringToFront();
            Gamepanel.Visible = true;
            Gamepanel.Controls.Clear();
            Startbutton.Visible = true;
            option.TopLevel = false;
            option.Dock = DockStyle.Fill;
            Gamepanel.Controls.Add(option);
            option.Show();
        }

        private void t1t1_Click(object sender, EventArgs e)
        {
            OpenOption("t1t1");
        }

        private void t1t2_Click(object sender, EventArgs e)
        {
            OpenOption("t1t2");
        }

        private void t1t3_Click(object sender, EventArgs e)
        {
            OpenOption("t1t3");
        }

        private void t1t4_Click(object sender, EventArgs e)
        {
            OpenOption("t1t4");
        }

        private void t2t1_Click(object sender, EventArgs e)
        {
            OpenOption("t2t1");
        }

        private void t3t1_Click(object sender, EventArgs e)
        {
            OpenOption("t3t1");
        }

        private void t3t2_Click(object sender, EventArgs e)
        {
            OpenOption("t3t2");
        }

        private void t3t3_Click(object sender, EventArgs e)
        {
            OpenOption("t3t3");
        }

        private void t3t4_Click(object sender, EventArgs e)
        {
            OpenOption("t3t4");
        }

        private void t3t5_Click(object sender, EventArgs e)
        {
            OpenOption("t3t5");
        }

        private void t3t6_Click(object sender, EventArgs e)
        {
            OpenOption("t3t6");
        }

        private void t3t7_Click(object sender, EventArgs e)
        {
            OpenOption("t3t7");
        }

        private void t3t8_Click(object sender, EventArgs e)
        {
            OpenOption("t3t8");
        }

        private void t4t1_Click(object sender, EventArgs e)
        {
            OpenOption("t4t1");
        }

        private void t5t1_Click(object sender, EventArgs e)
        {
            OpenOption("t5t1");
        }

        private void t6t1_Click(object sender, EventArgs e)
        {
            OpenOption("t6t1");
        }

        string writeArg;
        private void Write()
        {
            StreamWriter sw = new StreamWriter(path + "\\OptionLog.txt", false);
            writeArg = option.Rainlabel2.Text + "," + option.Foglabel2.Text + "," + option.Timelabel2.Text;
            sw.Write(writeArg); 
            sw.Close(); 
        }

        private string readArg;
        private void Startbutton_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream(path + "\\OptionLog.txt", FileMode.Open);
            StreamReader sr = new StreamReader(file);
            readArg = sr.ReadToEnd();
            sr.Close();

            Write();

            Startbutton.Visible = false;
            Gamepanel.Controls.Clear();
            Gamepanel.Controls.Add(ScoreRichTextBox);

            switch (readArg)
            {
                case "t1t1":
                    break;
                case "t1t2":
                    myExe = new MyEXEClass(Gamepanel, "-admin -forceSimul -window");
                    break;
                case "t1t3":
                    myExe = new MyEXEClass(Gamepanel, "-admin -forceSimul -window");
                    break;
                case "t1t4":
                    myExe = new MyEXEClass(Gamepanel, "-admin -forceSimul -window");
                    break;
                case "t2t1":
                    myExe = new MyEXEClass(Gamepanel, "-admin -forceSimul -window");
                    break;
                case "t3t1":
                    myExe = new MyEXEClass(Gamepanel, "-admin -forceSimul -window");
                    break;
                case "t3t2":
                    myExe = new MyEXEClass(Gamepanel, "-admin -forceSimul -window");
                    break;
                case "t3t3":
                    myExe = new MyEXEClass(Gamepanel, "-admin -forceSimul -window");
                    break;
                case "t3t4":
                    myExe = new MyEXEClass(Gamepanel, "-admin -forceSimul -window");
                    break;
                case "t3t5":
                    myExe = new MyEXEClass(Gamepanel, "-admin -forceSimul -window");
                    break;
                case "t3t6":
                    myExe = new MyEXEClass(Gamepanel, "-admin -forceSimul -window");
                    break;
                case "t3t7":
                    myExe = new MyEXEClass(Gamepanel, "-admin -forceSimul -window");
                    break;
                case "t3t8":
                    myExe = new MyEXEClass(Gamepanel, "-admin -forceSimul -window");
                    break;
                case "t4t1":
                    myExe = new MyEXEClass(Gamepanel, "-admin -forceSimul -window");
                    break;
                case "t5t1":
                    myExe = new MyEXEClass(Gamepanel, "-admin -forceSimul -window");
                    break;
                case "t6t1":
                    myExe = new MyEXEClass(Gamepanel, "-admin -forceSimul -window");
                    break;
                default:
                    myExe = new MyEXEClass(Gamepanel, "-admin -forceSimul -window");
                    break;
            }
            if (myExe!=null)
            {
                //myExe.Start("C:\\Program Files\\Bohemia Interactive Simulations\\VBS3 3.9.2 YYMEA_General\\VBS3_64.exe");
                myExe.Start("C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe");
                //myExe.Start("D:\\Program Files\\VBS3_64.exe");
            }
        }
        #endregion

        #region Read
        private string strLine;
        private string strSub;

        private string Read(string path)
        {
            try
            {
                FileStream file = new FileStream(path, FileMode.Open);
                StreamReader sRead = new StreamReader(file);
                strLine = sRead.ReadToEnd();
                sRead.Close();
            }
            catch
            {

            }
            if (strLine.Length > 10)
            {
                strSub = strLine.Substring(strLine.Length - 10);
                return strSub;
            }
            else
            {
                return strLine;
            }
        }

        private string message;
        private string messageSub;
        private string path = Application.StartupPath;
        private int curScore=5;
        ArrayList scores = new ArrayList();

        private delegate void ChangedDelegate(FileSystemEventArgs e);

        private void ChangedEvent(FileSystemEventArgs e)
        {
            if (e.Name == "log.txt")
            {
                message = Read(path + "\\log.txt");
                messageSub = message.Substring(message.Length - 10);

                switch (messageSub)
                {
                    case "YLGanYLGan":
                        messageSub = "左边履带压杆!扣1分!\n";
                        curScore -= 1;
                        CurrentScoreLabel.Text = "当前分数：" + curScore.ToString();
                        break;
                    case "YRGanYRGan":
                        messageSub = "右边履带压杆!扣1分!\n";
                        curScore -= 1;
                        CurrentScoreLabel.Text = "当前分数：" + curScore.ToString();
                        break;
                    case "QiGanQiGan":
                        messageSub = "车体骑杆!扣2分!\n";
                        curScore -= 2;
                        CurrentScoreLabel.Text = "当前分数："+curScore.ToString();
                        break;
                    default:
                        messageSub = null;
                        break;
                }
                if (curScore >= 3)
                {
                    CurrentScoreLabel.ForeColor = Color.White;
                }
                else
                {
                    CurrentScoreLabel.ForeColor = Color.Red;
                }
                ScoreRichTextBox.Text += messageSub;
            }
        }

        private void Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            if (ScoreRichTextBox.InvokeRequired)
            {
                ScoreRichTextBox.Invoke(new ChangedDelegate(ChangedEvent), new object[] { e });
            }
        }
        #endregion

        Point startPoint = new Point(1820, 400);
        Point endPoint = new Point(1820, 500);

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.BGpictureBox.Refresh();
            if (MyUDPSocket.recvMessage!=null)
            {
                int endPointX = int.Parse(MyUDPSocket.recvMessage);
                endPoint.X = 1820 + endPointX;
                SpeedLabel.Location = endPoint;
                SpeedLabel.Text = MyUDPSocket.recvMessage + "km/h";
            }
            else
            {
                SpeedLabel.Text = "";
            }
        }

        private void BGpictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics initGra = this.BGpictureBox.CreateGraphics();
            Brush initBrush = new SolidBrush(Color.Red);
            //initGra.FillRectangle(initBrush, startPoint.X, startPoint.Y, endPoint.X - startPoint.X, startPoint.Y-endPoint.Y );
            initGra.FillRectangle(initBrush, 1820, 400, endPoint.X - startPoint.X, 100);
        }
    }
}
