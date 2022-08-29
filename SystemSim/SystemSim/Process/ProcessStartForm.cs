using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemSim
{
    public partial class ProcessStartForm : Form
    {
        public ProcessStartForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();    //隐藏当前界面
            ControlForm controlForm = new ControlForm();    //创建页面
            controlForm.ShowDialog(); //展示进程控制界面
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DispatchForm dispatchForm = new DispatchForm();
            dispatchForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SynchronizationForm synchronizationForm = new SynchronizationForm();
            synchronizationForm.ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AvoidDeadlockForm avoidDeadlockForm = new AvoidDeadlockForm();
            avoidDeadlockForm.ShowDialog();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            /*
            DialogResult dr = MessageBox.Show("确定退出系统模拟器吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
            */
            this.Hide();   //关闭程序控制模块
            SystemStartForm SystemStartForm = new SystemStartForm();  //新建开始界面
            SystemStartForm.ShowDialog();   //打开开始界面
        }
        private void StartForm_Load(object sender, EventArgs e)
        {
            ;
        }

       
    }
}
