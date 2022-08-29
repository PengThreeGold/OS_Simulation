using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SystemSim
{
    public partial class SynchronizationForm : Form
    {
        public Boolean mutex = true;
        int empty = 10;
        int full = 0;
        int time = 0;
        int flag = 1;
        public void ShowCache(int full)
        {
            this.button1.BackColor = Color.White;
            this.button2.BackColor = Color.White;
            this.button3.BackColor = Color.White;
            this.button4.BackColor = Color.White;
            this.button5.BackColor = Color.White;
            this.button6.BackColor = Color.White;
            this.button7.BackColor = Color.White;
            this.button8.BackColor = Color.White;
            this.button9.BackColor = Color.White;
            this.button10.BackColor = Color.White;
            for (int i = 0;i < full; i++)
            {
                if (i == 0) this.button1.BackColor = Color.Red;
                else if (i == 1) this.button2.BackColor = Color.Red;
                else if (i == 2) this.button3.BackColor = Color.Red;
                else if (i == 3) this.button4.BackColor = Color.Red;
                else if (i == 4) this.button5.BackColor = Color.Red;
                else if (i == 5) this.button6.BackColor = Color.Red;
                else if (i == 6) this.button7.BackColor = Color.Red;
                else if (i == 7) this.button8.BackColor = Color.Red;
                else if (i == 8) this.button9.BackColor = Color.Red;
                else if (i == 9) this.button10.BackColor = Color.Red;
            }
        }
        public Boolean wait(Boolean mutex)  //互斥信号量
        {
            if (mutex)  //信号为true
            {
                this.mutex = false;
                return false;
            }
            else  //信号为false
            {
                this.mutex = true;
                return false;
            } 
        }
        public Boolean signal(int cache,string who) //根据缓冲池状态判断生产者消费者运行情况
        {
            if(who == "producer" && - 1 < cache && cache< 10) 
                return false;
            else if(who == "consumer" && 0 < cache && cache < 11) 
                return false;
            else return true;
        }
        public void producer()
        {
            if (wait(mutex)) return;    //检测信号（如真并锁定）
            if (signal(full,"producer")) return;   //检测缓冲池是否满载
            empty--;
            full++;
            richTextBox1.AppendText(time + "s：已生产一个产品\n");
            this.ShowCache(full);
            wait(mutex);    //释放信号
        }
        public void consumer()
        {
            if (wait(mutex)) return;    //检测信号（如真并锁定）
            if (signal(full, "consumer")) return;   //检测缓冲池是否空载
            empty++;
            full--;
            richTextBox1.AppendText(time + "s：已消费一个产品\n");
            this.ShowCache(full);
            wait(mutex);    //释放信号
        }
        public void Running()
        {
            timer1.Start(); //运行定时任务
        }
        public SynchronizationForm()
        {
            Control.CheckForIllegalCrossThreadCalls = false; //加载时 取消跨线程检查
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.SelectionLength = 0;
            richTextBox1.ScrollToCaret();
        }
        private void buttonexit_Click(object sender, EventArgs e)
        {
            this.Hide();   //关闭程序控制模块
            ProcessStartForm startForm = new ProcessStartForm();  //新建开始界面
            startForm.ShowDialog();   //打开开始界面
        }
        private void buttonrunning_Click(object sender, EventArgs e)
        {
            Running();  //调用运行函数
        }
        private void buttonstop_Click(object sender, EventArgs e)
        {
            if (buttonstop.Text == "暂停")
            {
                flag = 0;
                buttonstop.Text = "继续";
            }
            else if (buttonstop.Text == "继续")
            {
                flag = 1;
                buttonstop.Text = "暂停";
                Running();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if (flag == 1) Parallel.Invoke(producer, consumer); else timer1.Stop();
        }
    }
}
