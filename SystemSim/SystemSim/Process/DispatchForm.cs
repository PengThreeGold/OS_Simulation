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
    public partial class DispatchForm : Form
    {
        public DispatchForm()
        {
            InitializeComponent();
        }
        //创建四个进程队列，分别存放四种不同状态下的进程
        List<PCB> ReadyList = new List<PCB>();  //就绪队列
        List<PCB> RunningList = new List<PCB>();    //运行队列
        List<PCB> BlockList = new List<PCB>();  //阻塞队列
        List<PCB> DisappearList = new List<PCB>();  //消亡队列
        public string Algorithm = "";    //定义全局变量Algorithm（程序调度算法）
        /*
        创建进程管控相关操作
        0、进程队列初始化操作
        1、创建进程操作CreatProcess
        2、查找进程相关操作SearchProcess
        3、删除进程相关操作DeleteProcess
        4、阻塞进程相关操作BlockProcess
        5、唤醒进程相关操作WakeupProcess
        */
        public void CreateProcess(List<PCB> ReadyList, string Pname, int Pid, int Ppriority, int Ptimeslice,double Presponserate,int Parrivetime)//创建进程
        {
            PCB pcb = new PCB();    //新建进程
            pcb.Pname = Pname;  //获取进程名称
            pcb.Pid = Pid;  //获取进程编号
            pcb.Ppriority = Ppriority;  //获取进程优先级
            pcb.Pstate = "就绪";  //添加进程状态
            pcb.Ptimeslice = Ptimeslice;    //获取时间片长度
            pcb.Presponserate = Presponserate;  //获取程序响应比
            pcb.Parrivetime = Parrivetime;  //获取进程到达时间
            //pcb.Povertime = Povertime;  //获取进程运行结束时间
            if (SearchProcess(ReadyList, Pid).Pid == Pid)
            {
                //进程号重复添加失败
                richTextBox_main.AppendText("创建失败！此进程已存在\n");
                return;
            }
            string show = "进程" + pcb.Pname + "创建成功!，进程编号是" + pcb.Pid + "\n";
            richTextBox_main.AppendText(show);  //展示实时创建信息
            ReadyList.Add(pcb); //加入就绪队列
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
        public void DeleteProcess(List<PCB> q, int pid)  //删除指定队列中的指定进程(指定id)
        {
            PCB p = SearchProcess(q, pid);  //根据pid在指定队列查找该进程
            if (p.Pname == "无此进程") //调用查找方法查找进程
            {
                richTextBox_main.AppendText("删除失败！没有此进程\n");
                return;
            }
            q.Remove(p);
            richTextBox_main.AppendText("删除成功！\n");
            DisappearList.Add(p);
            //查找成功并删除
        }
        public void BlockProcess(int pid)
        {
            PCB p = SearchProcess(RunningList, pid);  //根据pid在运行队列查找该进程
            if (p.Pname == "无此进程")
            {
                richTextBox_main.AppendText("阻塞失败！没有此进程\n");
                return;
            }
            RunningList.Remove(p);  //将阻塞进程从运行队列移除
            BlockList.Add(p);  //将阻塞进程添加进阻塞队列
            richTextBox_main.AppendText("阻塞成功！已将进程" + p.Pid + "阻塞\n");
        }
        public void WakeupProcess(int pid)
        {
            PCB p = SearchProcess(BlockList, pid);  //根据pid在阻塞队列查找该进程
            if (p.Pname == "无此进程")
            {
                richTextBox_main.AppendText("唤醒失败！没有此进程\n");
            }
            BlockList.Remove(p);   //将唤醒进程从阻塞进程删除
            RunningList.Add(p);  //将阻塞进程添加进运行队列
            richTextBox_main.AppendText("唤醒成功！已将进程" + p.Pid + "唤醒\n");
        }
        /*
         * 以下为运行所需针对设计函数
         */
        public void PrintMessage(List<PCB> P, RichTextBox R)   //遍历打印队列中详细信息
        {
            string str = "名称 编号 优先级 状态  运行时间\n";
            foreach (var item in P) //遍历就绪队列
                if (item.Pname.Length < 2)   //针对性调节输出列表
                {
                    str += "  " + item.Pname + "   " + item.Pid + "    " + item.Ppriority + "   " + item.Pstate + "    " + item.Ptimeslice + "\n";
                }
                else
                    str += " " + item.Pname.Substring(0, 2) + "   " + item.Pid + "    " + item.Ppriority + "   " + item.Pstate + "    " + item.Ptimeslice + "\n";
            R.Clear();  //清除原富文本框内容
            R.AppendText(str);
        }
        public void SetResponseRate(List <PCB> P)   //更新当前队列各进程响应比并进行响应比排序
        {
            //响应比 =（等待时间+要求服务时间）/ 要求服务时间,即RR=（w+s）/s=1+w/s
            foreach (var item in P)
                item.Presponserate = ((time1*1.0 - item.Parrivetime) / item.Ptimeslice) + 1;    //求每次即将运行时所有进程的响应比
            if (P.Count > 1)    //队列存在两个及两个以上元素时进行排序
            {
                P.Sort(delegate (PCB x, PCB y) //对当前队列按照队列响应比排序（递减）
                {
                    return y.Presponserate.CompareTo(x.Presponserate);
                });
            }
        }
        /*
         * 以下为各控件功能设计
         */
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox_main.SelectionStart = richTextBox_main.Text.Length;
            richTextBox_main.SelectionLength = 0;
            richTextBox_main.ScrollToCaret();
        }
        private void Start_Click(object sender, EventArgs e)
        {
            this.Running();
        }
        int RRTimeslice = 0;    //定义RR算法中时间片长度
        private void AddAll_Click(object sender, EventArgs e)
        {
            //判断接收数据
            if (Name2.Text == "")
            {
                MessageBox.Show("请输入进程名称");
                return;
            }
            else if (Id2.Text == "")
            {
                MessageBox.Show("请输入进程编号");
                return;
            }
            else if (Priority2.Text == "")
            {
                MessageBox.Show("请输入进程优先级");
                return;
            }
            else if (Timeslice2.Text == "")
            {
                MessageBox.Show("请输入进程运行时间");
                return;
            }
            //接受数据
            string name = Name2.Text;
            int id = Convert.ToInt32(Id2.Text);
            int priority = Convert.ToInt32(Priority2.Text);
            int timeslice = Convert.ToInt32(Timeslice2.Text);
            //根据算法选择数据输入形式
            if (Algorithm == "")
            {
                MessageBox.Show("请选择进程调度算法");
                return;
            }
            else if(Algorithm == "时间片轮转RR调度算法")
            {
                if (Timeslice_number.Text == "")
                {
                    MessageBox.Show("请输入RR算法中时间片长度");
                    return;
                }
                RRTimeslice = Convert.ToInt32(Timeslice_number.Text);   //获取RR算法中时间片长度
                this.CreateProcess(ReadyList, name, id, 1, timeslice, 1, time1);    //创建进程（默认优先级1，响应比1）
            }
            else if (Algorithm == "短进程优先SPF调度算法")
            {
                this.CreateProcess(ReadyList, name, id, 1, timeslice,1,time1);    //创建进程（默认优先级1，响应比1）
                ReadyList.Sort(delegate (PCB x, PCB y) //就绪队列对进程运行时间排序
                {
                    return x.Ptimeslice.CompareTo(y.Ptimeslice);
                });
                this.PrintMessage(ReadyList,richTextBox_Ready); //进程就绪队列打印
            }
            else if (Algorithm == "先来先服务FCFS调度算法")
            {
                this.CreateProcess(ReadyList, name, id, 1, timeslice, 1d,time1);    //创建进程（默认优先级1，响应比1）
            }
            else if (Algorithm == "高优先级优先PSA调度算法")
            {
                this.CreateProcess(ReadyList, name, id, priority, timeslice, 1d,time1);  //创建进程（默认响应比1）
                ReadyList.Sort(delegate (PCB x, PCB y) //就绪队列进行进程优先级排序
                {
                    return x.Ppriority.CompareTo(y.Ppriority);
                });
            }
            else if (Algorithm == "高响应比高优先HRRN调度算法")
            {
                this.CreateProcess(ReadyList, name, id, 1, timeslice, 1d, time1);  //创建进程（默认优先级1，响应比1）
            }
            //预览就绪队列
            this.PrintMessage(ReadyList, richTextBox_Ready);
            //恢复输入框
            Name2.Text = "";
            Id2.Text = "";
            Priority2.Text = "";
            Timeslice2.Text = "";
        }
        private void Exit_Click(object sender, EventArgs e) //退出按钮
        {
            this.Hide();   //关闭程序控制模块
            ProcessStartForm startForm = new ProcessStartForm();  //新建开始界面
            startForm.ShowDialog();   //打开开始界面
        }
        private void ResetAll_Click(object sender, EventArgs e) //重置按钮
        {
            //恢复输入框
            Name2.Text = "";
            Id2.Text = "";
            Priority2.Text = "";
            Timeslice2.Text = "";
        }
        private void AlgorithmBox_ItemCheck(object sender, ItemCheckEventArgs e)    //实现checkedlistbox单选功能
        {
            if (e.CurrentValue == CheckState.Checked) return;   //取消选中就不用进行以下操作
            for (int i = 0; i < ((CheckedListBox)sender).Items.Count; i++)
            {
                ((CheckedListBox)sender).SetItemChecked(i, false);  //将所有选项设为不选中
            }
            e.NewValue = CheckState.Checked;    //刷新
            Algorithm = AlgorithmBox.Text;  //赋值
            richTextBox_main.AppendText("-->" + Algorithm +"\n"); //展示
            //恢复输入框
            Name2.Text = "";
            Id2.Text = "";
            Priority2.Text = "";
            Timeslice2.Text = "";
            Timeslice_number.Text = "";
        }
        /*
         * 以下为计时器设计
         */
        int time1 = 0;  //定义计时器容器
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (RunningList.Count == 1 && RunningList[0].Ptimeslice > 0) //运行队列不为空且未运行完
            {
                RunningList[0].Ptimeslice--;    //运行时间减一
                RunningList[0].Parrivetime = time1; //修改进程到达时间
                this.PrintMessage(RunningList, richTextBox_Running);    //更新运行队列
                time1++;    //计时器加一
                richTextBox_main.AppendText(time1 + "秒过去……\n"); //更新进程运行情况
            }
            else if (RunningList.Count == 1 && RunningList[0].Ptimeslice == 0) //运行队列完成
            {
                RunningList[0].Pstate = "消亡";   //修改运行完成后进程的状态
                DisappearList.Add(RunningList[0]);  //将运行完成的进程加入消亡队列
                richTextBox_main.AppendText("进程" + RunningList[0].Pid + "执行--->消亡\n");  //更新进程运行情况
                RunningList.RemoveAt(0);    //从运行队列中移除
                this.PrintMessage(DisappearList, richTextBox_Disappear);    //更新消亡队列
                this.PrintMessage(RunningList, richTextBox_Running);    //更新运行队列
                if (RunningList.Count == 0 && ReadyList.Count != 0) //若运行队列为空且就绪队列还有进程，继续运行。
                    Running();
                else time1=0;   //计时器归零
            }
            if(Algorithm == "时间片轮转RR调度算法")
            {
                if (RunningList.Count == 1 && RunningList[0].Ptimeslice > 0 && time1 > 0 && time1 % RRTimeslice == 0)    //该时间片使用完但进程没运行完
                {
                    /*
                    * 设计RR调度算法
                    * 同一时间先插入，后到达
                    */
                    RunningList[0].Pstate = "就绪";
                    RunningList[0].Parrivetime = time1;
                    List<PCB> temppcb = new List<PCB>();    //新建中转队列
                    foreach (var item in ReadyList) //将就绪队列中所有元素移动到中转队列中
                        temppcb.Add(item);
                    ReadyList.Clear();  //清空就绪队列
                    ReadyList.Add(RunningList[0]);  //将运行队列运行一个时间片结束后（但进程未运行完）的进程加入到就绪队列队首
                    foreach (var item in temppcb)   //将中转队列中的所有元素（即为原就绪队列中的所有元素）添加到就绪队列
                        ReadyList.Add(item);
                    ReadyList.Sort(delegate (PCB x, PCB y) //就绪队列进行进程优先级排序（该方式保证了同一时间先插入，后到达的设计目的）
                    {
                        return x.Parrivetime.CompareTo(y.Parrivetime);
                    });
                    richTextBox_main.AppendText("进程" + RunningList[0].Pid + "执行--->就绪\n");  //更新进程运行情况
                    RunningList.RemoveAt(0);    //从运行队列移除该时间片已完成的进程
                    this.PrintMessage(RunningList, richTextBox_Running);    //更新运行队列
                    this.PrintMessage(ReadyList, richTextBox_Ready);    //更新就绪队列
                    if (RunningList.Count == 0 && ReadyList.Count != 0) //若运行队列为空且就绪队列还有进程，继续运行进程。
                        Running();
                    else time1 = 0;   //运行队列运行完成，计时器归零
                }
            }
        }
        /*
         * 以下为运行调用函数
         */
        public void Running()
        {
            if (Algorithm == "")
            {
                MessageBox.Show("请选择进程调度算法");
                return;
            }
            this.UsualRun();
        }
        public void UsualRun()
        {
            if (ReadyList.Count == 0) //若就绪队列为空，无法执行
            {
                MessageBox.Show("就绪队列为空，无法执行!", "错误");

            }
            else if (Algorithm == "高响应比高优先HRRN调度算法")
            {
                if (RunningList.Count == 0) //运行队列为空
                {
                    this.SetResponseRate(ReadyList);
                    ReadyList[0].Pstate = "执行";
                    RunningList.Add(ReadyList[0]);
                    ReadyList.RemoveAt(0);
                    richTextBox_main.AppendText(RunningList[0].Pname + "响应比为" + RunningList[0].Presponserate + "\n");
                    richTextBox_main.AppendText("进程" + RunningList[0].Pid + "就绪--->执行\n");
                    this.PrintMessage(RunningList, richTextBox_Running);
                    this.PrintMessage(ReadyList, richTextBox_Ready);
                    timer1.Start();
                }
            }
            else
            {
                if (RunningList.Count == 0) 
                {
                    ReadyList[0].Pstate = "执行";
                    RunningList.Add(ReadyList[0]);
                    ReadyList.RemoveAt(0);
                    richTextBox_main.AppendText("进程" + RunningList[0].Pid + "就绪--->执行\n");
                    this.PrintMessage(RunningList, richTextBox_Running);
                    this.PrintMessage(ReadyList, richTextBox_Ready);
                    this.SetResponseRate(ReadyList);
                    timer1.Start();
                }
            }
        }

        private void AlgorithmBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DispatchForm_Load(object sender, EventArgs e)
        {

        }
    }
}
