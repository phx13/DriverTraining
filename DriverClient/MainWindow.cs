using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace DriverClient
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            SetStyle(System.Windows.Forms.ControlStyles.UserPaint, true);
            SetStyle(System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(System.Windows.Forms.ControlStyles.DoubleBuffer, true);
            UpdateStyles();
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

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                GC.Collect();
                this.Dispose();
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            BGpanel.Parent = BGpictureBox;
            BGTTlabel.Parent = BGTTpictureBox;
            BGTTlabel.Location = new Point(270, 60);
            Testlabel1.Parent = TestpictureBox1;
            Testlabel1.Location = new Point(230, 45);
            Testlabel2.Parent = TestpictureBox2;
            Testlabel2.Location = new Point(230, 45);
            Testlabel3.Parent = TestpictureBox3;
            Testlabel3.Location = new Point(130, 45);
            Testlabel4.Parent = TestpictureBox4;
            Testlabel4.Location = new Point(130, 45);
            Testlabel5.Parent = TestpictureBox5;
            Testlabel5.Location = new Point(230, 45);
            Testlabel6.Parent = TestpictureBox6;
            Testlabel6.Location = new Point(230, 45); 
            Scoretree.ExpandAll();
        }

        #region Click
        Test test = new Test();
        private void TestpictureBox1_Click(object sender, EventArgs e)
        {
            test.t1tt.Visible = true;
            test.t1t1.Visible = true;
            test.t1t2.Visible = true;
            test.t1t3.Visible = true;
            test.t1t4.Visible = true;
            test.ShowDialog();
        }

        private void TestpictureBox2_Click(object sender, EventArgs e)
        {
            test.t2tt.Visible = true;
            test.t2t1.Visible = true;
            test.ShowDialog();
        }

        private void TestpictureBox3_Click(object sender, EventArgs e)
        {
            test.t3tt.Visible = true;
            test.t3t1.Visible = true;
            test.t3t2.Visible = true;
            test.t3t3.Visible = true;
            test.t3t4.Visible = true;
            test.t3t5.Visible = true;
            test.t3t6.Visible = true;
            test.t3t7.Visible = true;
            test.t3t8.Visible = true;
            test.ShowDialog();
        }
       
        private void TestpictureBox4_Click(object sender, EventArgs e)
        {
            test.t4tt.Visible = true;
            test.t4t1.Visible = true;
            test.ShowDialog();
        }

        private void TestpictureBox5_Click(object sender, EventArgs e)
        {
            test.t5tt.Visible = true;
            test.t5t1.Visible = true;
            test.ShowDialog();
        }

        private void TestpictureBox6_Click(object sender, EventArgs e)
        {
            test.t6tt.Visible = true;
            test.t6t1.Visible = true;
            test.ShowDialog();
        }
        #endregion

        #region Mousehover
        private void TestpictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Testlabel1.ForeColor = Color.OrangeRed;
        }

        private void TestpictureBox2_MouseEnter(object sender, EventArgs e)
        {
            Testlabel2.ForeColor = Color.OrangeRed;
        }

        private void TestpictureBox3_MouseEnter(object sender, EventArgs e)
        {
            Testlabel3.ForeColor = Color.OrangeRed;
        }

        private void TestpictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Testlabel1.ForeColor = Color.White;
        }

        private void TestpictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Testlabel2.ForeColor = Color.White;
        }

        private void TestpictureBox3_MouseLeave(object sender, EventArgs e)
        {
            Testlabel3.ForeColor = Color.White;
        }

        private void TestpictureBox4_MouseEnter(object sender, EventArgs e)
        {
            Testlabel4.ForeColor = Color.OrangeRed;
        }

        private void TestpictureBox4_MouseLeave(object sender, EventArgs e)
        {
            Testlabel4.ForeColor = Color.White;
        }

        private void TestpictureBox5_MouseEnter(object sender, EventArgs e)
        {
            Testlabel5.ForeColor = Color.OrangeRed;
        }

        private void TestpictureBox5_MouseLeave(object sender, EventArgs e)
        {
            Testlabel5.ForeColor = Color.White;
        }

        private void TestpictureBox6_MouseEnter(object sender, EventArgs e)
        {
            Testlabel6.ForeColor = Color.OrangeRed;
        }

        private void TestpictureBox6_MouseLeave(object sender, EventArgs e)
        {
            Testlabel6.ForeColor = Color.White;
        }
        #endregion

        #region Log
        public static string number;
        public static string password;

        private void LoginButton_Click(object sender, EventArgs e)
        {
            number = NumberTextbox.Text;
            password = PasswordTextbox.Text;
            if (number == "" || password == "")
            {
                ErrorLabel.Text = "请输入学号或密码";
            }
            else
            {
                SQLiteDataReader sdrLogin = MySQLiteClass.Getmysqlread("select Password from Login where Number ='" + number + "'");
                sdrLogin.Read();
                if (sdrLogin.HasRows)
                {
                    if (password != sdrLogin["Password"].ToString())
                    {
                        ErrorLabel.Text = "请输入正确的学号和密码";
                    }
                    else
                    {
                        sdrLogin.Dispose();
                        MySQLiteClass.sqlClose(MySQLiteClass.Getsqlitecon());
                        ErrorLabel.Text = "欢迎回来，学员" + number;
                        BGpictureBox.Visible = true;
                        Logoutbutton.Visible = true;
                        Scorebutton.Visible = true;
                        NumberLabel.Visible = false;
                        NumberTextbox.Visible = false;
                        PasswordLabel.Visible = false;
                        PasswordTextbox.Visible = false;
                        passwordCheckBox.Visible = false;
                        LoginButton.Visible = false;
                        RegistButton.Visible = false;
                    }
                }
                else
                {
                    ErrorLabel.Text = "请输入正确的学号和密码";
                }
            }
            NumberTextbox.Text = "";
            PasswordTextbox.Text = "";
        }

        private void RegistButton_Click(object sender, EventArgs e)
        {
            number = NumberTextbox.Text;
            password = PasswordTextbox.Text;
            if (number == "" || password == "")
            {
                ErrorLabel.Text = "请输入注册学号或密码";
            }
            else
            {
                SQLiteDataReader sdrLogin = MySQLiteClass.Getmysqlread("select Number from Login where Number='" + number + "'");
                sdrLogin.Read();
                if (sdrLogin.HasRows)
                {
                    sdrLogin.Dispose();
                    ErrorLabel.Text = "该学号已注册";
                }
                else
                {
                    MySQLiteClass.Getmysqlcom("insert into Login(Number,Password) values('"+number+"','"+password+"')");
                    ErrorLabel.Text = "注册成功";
                }
            }
            NumberTextbox.Text = "";
            PasswordTextbox.Text = "";
        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            BGpictureBox.Visible = false;
            Logoutbutton.Visible = false;
            Scorebutton.Visible = false;
            Scorepanel.Visible = false;
            NumberLabel.Visible = true;
            NumberTextbox.Visible = true;
            PasswordLabel.Visible = true;
            PasswordTextbox.Visible = true;
            passwordCheckBox.Visible = true;
            LoginButton.Visible = true;
            RegistButton.Visible = true;
            ErrorLabel.Text = "";
        }

        private void Scorebutton_Click(object sender, EventArgs e)
        {
            if (Scorepanel.Visible == false)
            {
                Scorepanel.Visible = true;
            }
            else
            {
                Scorepanel.Visible = false;
            }
        }
        #endregion

        private string selectText;
        private void Scoretree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selectText = Scoretree.SelectedNode.Text;
            Scoredata.DataSource = null;
            if (selectText=="全部训练")
            {
                Scoredata.DataSource = MySQLiteClass.Getsqliteset("select 训练时间,低速挡驾驶,依次换挡驾驶,重点难点动作驾驶,各种速度驾驶,坡上驾驶,直线桩间限制路,下坡桩间限制路,“S”型限制路,车辙桥,土岭,弹坑,弯道限制路,双直角限制路,连续限制路和障碍物驾驶,道路驾驶,行军驾驶 from DirScore where Number='" + number + "'", "DirScore").Tables[0];                
            }
            else if (selectText=="基础驾驶")
            {
                Scoredata.DataSource = MySQLiteClass.Getsqliteset("select 训练时间,低速挡驾驶,依次换挡驾驶,重点难点动作驾驶,各种速度驾驶 from DirScore where Number='" + number + "'", "DirScore").Tables[0];                
            }
            else if (selectText=="单个限制路和障碍物驾驶")
            {
                Scoredata.DataSource = MySQLiteClass.Getsqliteset("select 训练时间,直线桩间限制路,下坡桩间限制路,“S”型限制路,车辙桥,土岭,弹坑,弯道限制路,双直角限制路 from DirScore where Number='" + number + "'", "DirScore").Tables[0];                
            }
            else
            {
                Scoredata.DataSource = MySQLiteClass.Getsqliteset("select 训练时间," + selectText + " from DirScore where Number='" + number + "' and " + selectText + " is not null", "DirScore").Tables[0];
            }
        }
    }
}
