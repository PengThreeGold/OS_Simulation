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
    public partial class SystemStartForm : Form
    {
        public SystemStartForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();    //隐藏当前界面
            ProcessStartForm ProcessStartForm = new ProcessStartForm();    //创建页面
            ProcessStartForm.ShowDialog(); //展示进程管理模拟实验平台界面
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();    //隐藏当前界面
            MemoryCtrl MemoryCtrl = new MemoryCtrl();    //创建页面
            MemoryCtrl.ShowDialog(); //展示进程管理模拟实验平台界面
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();    //隐藏当前界面
            EquipmentCtrl Equipment = new EquipmentCtrl();
            Equipment.ShowDialog();
        }

        private void SystemStartForm_Load(object sender, EventArgs e)
        {
            ;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("退出操作系统系统模拟实验平台 ？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void SystemStartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("      确认退出 ？", "警告 ！！！", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                System.Environment.Exit(0);
                //e.Cancel = false;          //这种也可以
            }
            else
            {
                e.Cancel = true;            //取消事件的值
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
