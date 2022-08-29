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
    public partial class ControlForm : Form
    {
        public ControlForm()
        {
            InitializeComponent();
        }
        /*
        根据定义PCB结构创建相关队列进行存储(数组形式)
        就绪队列
        运行队列
        阻塞队列
        消亡队列                          
        创建相关算法定义
        */

        List<PCB> ReadyList = new List<PCB>();//就绪队列
        List<PCB> RunningList = new List<PCB>();//运行队列
        List<PCB> BlockList = new List<PCB>();//阻塞队列
        List<PCB> DisappearList = new List<PCB>();//消亡队列

        /*
        创建进程管控相关操作
        0、进程队列初始化操作
        1、创建进程操作CreatProcess
        2、查找进程相关操作SearchProcess
        3、删除进程相关操作DeleteProcess
        4、阻塞进程相关操作BlockProcess
        5、唤醒进程相关操作WakeupProcess
        */

        public void CteatProcess(List<PCB> ReadyList,string Pname,int Pid,int Ppriority,int Ptimeslice)//创建进程
        {
            PCB pcb = new PCB();
            pcb.Pname = Pname;  //获取进程名称
            pcb.Pid = Pid;  //获取进程编号
            pcb.Ppriority = Ppriority;  //获取进程优先级
            pcb.Pstate = "就绪";  //添加进程状态
            pcb.Ptimeslice = Ptimeslice;    //默认时间片长度
            if(SearchProcess(ReadyList,Pid).Pid == Pid)
            {
                //进程号重复添加失败
                richTextBox_main.AppendText("创建失败！此进程已存在\n");
                return;
            }
            string show = "进程" + pcb.Pname + "创建成功!，进程编号是" + pcb.Pid + "\n";
            richTextBox_main.AppendText(show);
            ReadyList.Add(pcb); //加入就绪队列
            ReadyList.Sort(delegate (PCB x, PCB y) //进程优先级排序
            {
                return x.Ppriority.CompareTo(y.Ppriority);
            });
        }
        public PCB SearchProcess(List<PCB> q, int pid)   //查找指定队列中的指定进程(指定id)(为空返回空进程)
        {
            foreach (var item in q) //遍历就绪队列
                if (item.Pid == pid)    //查找就绪队列中id相符的进程
                {
                    return item;    //查找成功返回该进程
                }
            PCB p = new PCB();  //查找失败返回进程名为"无此进程"的空进程
            p.Pname = "无此进程";
            return p;
        }
        public void PrintMessage(List<PCB> P,RichTextBox R)   //遍历打印队列中详细信息
        {
            string str = "名称 编号 优先级 状态 运行时间\n";
            foreach (var item in P) //遍历就绪队列
                if(item.Pname.Length < 2)   //针对性调节输出列表
                {
                    str += "  " + item.Pname + "   " + item.Pid + "    " + item.Ppriority + "   " + item.Pstate + "    " + item.Ptimeslice + "\n";
                }else
                    str += " " + item.Pname.Substring(0, 2) + "   " + item.Pid + "    " + item.Ppriority + "   " + item.Pstate + "    " + item.Ptimeslice + "\n";
            R.Clear();  //清除原富文本框内容
            R.AppendText(str);
        }
        /*
         * 构建进程管理模块运行体
         */
        private void Show_Load(object sender, EventArgs e)
        {
            ;
        }
        private void AlgorithmBox_ItemCheck(object sender, ItemCheckEventArgs e)//设置算法单选模式
        {
            if (e.CurrentValue == CheckState.Checked) return;   //取消选中就不用进行以下操作
            for (int i = 0; i < ((CheckedListBox)sender).Items.Count; i++)
            {
                ((CheckedListBox)sender).SetItemChecked(i, false);  //将所有选项设为不选中
            }
            e.NewValue = CheckState.Checked;    //刷新

        }
        private void Exit_Click(object sender, EventArgs e) //退出程序按钮指示
        {
            this.Hide();   //关闭程序控制模块
            ProcessStartForm startForm = new ProcessStartForm();  //新建开始界面
            startForm.ShowDialog();   //打开开始界面
            
        }
        private void AddAll_Click(object sender, EventArgs e)
        {
            //判断接收数据
            if (Name1.Text == ""){
                Name1.Text = "请输入进程名称";
                return;
            }else if (Id1.Text == "")
            {
                Id1.Text = "请输入进程编号";
                return;
            }
            /*
            else if (Priority1.Text == "")
            {
                Priority1.Text = "请输入进程优先级";
                    return;
            }*/
            //接受数据
            string name = Name1.Text;
            int id = Convert.ToInt32(Id1.Text);
            //int priority = Convert.ToInt32(Priority1.Text); 
            int timeslice = Convert.ToInt32(Timeslice1.Text);
            //添加进进程
            CteatProcess(ReadyList,name,id,1,timeslice);
            //恢复输入框
            Name1.Text = "";
            Id1.Text = "";
            //Priority1.Text = "";
            Timeslice1.Text = "";
            //预览就绪队列
            this.PrintMessage(ReadyList,richTextBox_Ready);
        }
        private void ResetAll_Click(object sender, EventArgs e)
        {
            Name1.Text = "";
            Id1.Text = "";
            //Priority1.Text= "";
        }
        public int time1 = 0;   //计时容器
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (RunningList.Count == 1 && RunningList[0].Ptimeslice > 0) //运行队列为空且未运行完
            {
                RunningList[0].Ptimeslice--;
                //RunningList[0].Ppriority--;
                this.PrintMessage(RunningList, richTextBox_Running);
                time1++;
                richTextBox_main.AppendText(time1 + "秒过去……\n");
            }
            else if (RunningList.Count == 1 && RunningList[0].Ptimeslice == 0) //运行队列完成
            {
                RunningList[0].Pstate = "消亡";
                DisappearList.Add(RunningList[0]);
                richTextBox_main.AppendText("进程" + RunningList[0].Pid + "执行--->消亡\n");
                RunningList.RemoveAt(0);
                this.PrintMessage(DisappearList, richTextBox_Disappear);
                this.PrintMessage(RunningList, richTextBox_Running);
                if (RunningList.Count == 0 && ReadyList.Count != 0) Running(); //若运行队列为空且就绪队列还有进程，继续运行进程。
            }
        }
        public void Running()
        {
           if (ReadyList.Count == 0) //若就绪队列为空，无法执行
            {
                MessageBox.Show("就绪队列为空，无法执行!", "错误");

            }
            else //就绪队列非空
            {
                if (RunningList.Count == 0)
                {
                    ReadyList[0].Pstate = "执行";
                    RunningList.Add(ReadyList[0]);
                    ReadyList.RemoveAt(0);
                    richTextBox_main.AppendText("进程" + RunningList[0].Pid + "就绪--->执行\n");
                    this.PrintMessage(RunningList, richTextBox_Running);
                    this.PrintMessage(ReadyList, richTextBox_Ready);
                    timer1.Start();
                }
            }
        }
        private void ReadyP_number_TextChanged(object sender, EventArgs e)
        {
            ;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)//富文本框的基本应用初始化
        {
            richTextBox_main.SelectionStart = richTextBox_main.Text.Length;
            richTextBox_main.SelectionLength = 0;
            richTextBox_main.ScrollToCaret();
        }
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            richTextBox_main.SelectionStart = richTextBox_main.Text.Length;
            richTextBox_main.SelectionLength = 0;
            richTextBox_main.ScrollToCaret();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            this.Running();
        }
    }
}
