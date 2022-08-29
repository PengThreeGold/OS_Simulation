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
    public partial class MemoryCtrl : Form
    {
        public MemoryCtrl()
        {
            InitializeComponent();
        }

        private void MemoryCtrl_Load(object sender, EventArgs e)
        {
            ;
        }
        string algorithm = "None"; //算法模式
        int lackcounts = 0;  //缺页次数
        int vpoint = 0;            //页面访问指针
        //int rpoint;            //页面替换指针
        int pagelistlong;   //访问序列长度-1
        int lackflag = 1;           //缺页标志，0为不缺页，1为缺页(默认缺页)
        int[] pagelist = new int[20];     //访问序列
        string[] disk = new string[3];  //存储块（保存当前页号）
        int[] wait = new int[3];    //物理块等待时间（优先级）

        private void random_list_Click(object sender, EventArgs e)
        {
            disk1.Text = "";
            disk2.Text = "";
            disk3.Text = "";
            vpoint = 0; //更换序列访问指针归零
            string str = "";    //显示访问序列
            Random r = new Random(); //随机函数类对象
            pagelistlong = r.Next(3,10) + 0;   //申请随机访问序列个数[3,10]( +0 操作 确保为得到int型)
            for(int i = 0; i <= pagelistlong; i++)
            {
                pagelist[i] = r.Next(1,10) + 1; //
                str += pagelist[i] + " ";
            }
            page_list.Text = str;
            richTextBox1.AppendText("随机生成访问序列长度为："+(pagelistlong+1)+"\n");
        }
        //获取算法模式
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            algorithm = radioButton1.Text;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            algorithm = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            algorithm = radioButton3.Text;
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            ;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (algorithm == "最佳页面置换算法（OPT）")
            {
                this.OPT();
            }else if (algorithm == "先进先出页面置换算法（FIFO）")
            {
                this.FIFO();
            }else this.LRU();
        }

        public void OPT()   //最佳页面置换算法（OPT）
        {
            //通过指针位置判断运算状态
            if (vpoint > pagelistlong)
            {
                richTextBox1.AppendText("\nOPT算法下缺页率为" + ((lackcounts) / (pagelistlong + 1.0)) + "\n" + "-----------------运行结束--------------\n");
                timer1.Stop();  //执行完此次结束
                return; //跳出此次
            }

            int emptyflag = 0;  //物理块为空信号（0为无空块，1为有空块）
            int emptydisk = -1; //首个为空的物理块号（为-1则没记录空的物理块号）
            int max = 0;    //最远页面所在物理块号（0，1，2）
            wait[0] = 20; wait[1] = 20; wait[2] = 20;    //初始化等待时长
            disk[0] = disk1.Text; disk[1] = disk2.Text; disk[2] = disk3.Text;   //获取各物理块当前页面信息序列

            //不缺页情况（命中）
            for (int i = 0; i < 3; i++)
            {
                if (disk[i] == "")  //判断是否存在空物理块
                {
                    emptyflag = 1;  //标记有空物理块
                    if (emptydisk == -1)    //储存第一个为空的物理块块号
                    {
                        emptydisk = i;
                    }
                }
                if (Convert.ToString(pagelist[vpoint]) == disk[i])  //判断是否缺页
                {
                    lackflag = 0;   //表示不缺页
                    /* 注意
                     * 此处也可不使用缺页标记量
                     * 直接进行return即可
                     * 为了符合整体数据结构运算体
                     * 此处采用缺页标记量
                     */
                    richTextBox1.AppendText("\n命中页面" + pagelist[vpoint] + "\n");
                    vpoint++;   //递增访问指针
                    break;
                }
            }

            //缺页情况
            if (emptyflag == 1 && lackflag == 1)    //存在物理块为空时
            {
                disk[emptydisk] = Convert.ToString(pagelist[vpoint]); //将页面序号存入空物理块
                disk1.Text = disk[0]; disk2.Text = disk[1]; disk3.Text = disk[2];//输出物理块信息序列
                richTextBox1.AppendText("\n物理块" + (emptydisk+1) + "正在访问页面" + disk[emptydisk] + "\n");  //富文本框显示运行情况
                vpoint++;    //递增访问指针
            }
            else if (emptyflag == 0 && lackflag == 1)   //物理块不为空时
            {
                //不存在空物理块。计算各个页面最近值
                for (int i = vpoint; i <= pagelistlong; i++)    //从替换指针到页面列表尾指针遍历
                {
                    if (Convert.ToString(pagelist[i]) == disk[0] && wait[0] == 20)  //记录距离最近的同页面位置（wait[0] == 20判断是否为首次记录）
                    {
                        wait[0] = i - vpoint + 1;
                    }
                    else if (Convert.ToString(pagelist[i]) == disk[1] && wait[1] == 20) //记录距离最近的同页面位置
                    {
                        wait[1] = i - vpoint + 1;
                    }
                    else if (Convert.ToString(pagelist[i]) == disk[2] && wait[2] == 20) //记录距离最近的同页面位置
                    {
                        wait[2] = i - vpoint + 1;
                    }
                }
                for (int i = 0; i < 3; i++) //计算最远页面所在物理块号
                {
                    if (wait[i] > wait[max])
                    {
                        max = i;
                    }
                }
                richTextBox1.AppendText("\n物理块 1 中页面还需等待 " + wait[0] + "s 到达\n" + "物理块 2 中页面还需等待 " + wait[1] + "s 到达\n" + "物理块 3 中页面还需等待 " + wait[2] + "s 到达\n");
                //置换距离最远物理块的页面
                /* 注意
                 * 此处可以不设计中转变量
                 * 替换执行次序即可（更改->输出）换为（输出->更改）
                 */
                string tempdisk = disk[max];    //设置中转变量
                disk[max] = Convert.ToString(pagelist[vpoint]); //执行替换操作
                richTextBox1.AppendText("\n物理块 " + (max + 1) + " 将页面" + tempdisk + "置换为页面" + disk[max] + "\n");
                disk1.Text = disk[0]; disk2.Text = disk[1]; disk3.Text = disk[2];   //输出物理块信息序列
                lackflag = 1;   //重置缺页标志（默认缺页）
                vpoint++;   //递增指针变量
            }
            
            if (lackflag == 1)  //计算缺页次数
            {
                lackcounts++;   //缺页次数加1
            }
            lackflag = 1;   //重置缺页标志（默认缺页）
        }
        public void FIFO()  //先进先出页面置换算法（FIFO）
        {
            int emptyflag = 0;  //物理块为空信号
            int emptydisk = -1; //首个为空的物理块号
            //通过指针位置判断运算状态
            if (vpoint > pagelistlong)
            {
                richTextBox1.AppendText("FIFO算法下缺页率为" + ((lackcounts) / (pagelistlong + 1.0)) + "\n" + "-----------------运行结束--------------\n");
                timer1.Stop();  //执行完此次结束
                return; //跳出此次
            }
            richTextBox1.AppendText("物理块 1 已等待" + wait[0] + "\n物理块 2 已等待" + wait[1] + "\n物理块 3 已等待" + wait[2] + "\n");
            disk[0] = disk1.Text;disk[1] = disk2.Text;disk[2] = disk3.Text;//获取物理块信息序列
            //不缺页情况（命中）
            for (int i = 0; i < 3; i++)
            {
                if (disk[i] == "")
                {
                    emptyflag = 1;  //标记有物理块为空
                    if (emptydisk == -1)
                    {
                        emptydisk = i;  //储存第一个为空的物理块块号
                    }
                }
                if (Convert.ToString(pagelist[vpoint]) == disk[i])
                {
                    lackflag = 0;   //表示不缺页
                    //wait[0]; wait[1]; wait[2];   //保留物理块等待时间(程序末尾需要统一加一)
                    richTextBox1.AppendText("命中页面" + pagelist[vpoint] + "。所有物理块等待时间不变" + "\n");
                    vpoint++;   //递增访问指针
                    break;
                }
            }
            //缺页情况
            if (emptyflag == 1 && lackflag == 1)    //存在物理块为空时
            {
                disk[emptydisk] = Convert.ToString(pagelist[vpoint]); //将页面序号存入空物理块
                disk1.Text = disk[0];disk2.Text = disk[1];disk3.Text = disk[2];//输出物理块信息序列
                richTextBox1.AppendText("物理块" + (emptydisk+1) + "正在访问页面" + disk[emptydisk] + "\n");  //富文本框显示运行情况
                vpoint++;    //递增访问指针
            }
            else if (emptyflag == 0 && lackflag == 1)
            {
                //获取等待最久物理块
                int max = 0;
                for (int i = 0; i < wait.Length; i++)
                {

                    if (wait[i] > wait[max])
                    {
                        max = i;
                    }
                }
                //置换等待最久物理块的页面
                string tempdisk = disk[max];
                disk[max] = Convert.ToString(pagelist[vpoint]);
                richTextBox1.AppendText("物理块" + (max+1) + "将页面" + tempdisk + "置换为页面" + disk[max] + "\n");
                disk1.Text = disk[0];disk2.Text = disk[1];disk3.Text = disk[2];//输出物理块信息序列
                lackflag = 1;   //表示缺页
                wait[max] = 0; //重置物理块等待时间
                vpoint++;   //递增访问指针
            }
            //递增各（已存页面）物理块等待时间（缺页情况下）
            for (int i = 0; i < 3; i++)
            {
                if (disk[i] != "" && lackflag == 1)
                {
                    wait[i]++;
                }
            }
            if (lackflag == 1)
            {
                lackcounts++;   //缺页次数加1
            }
            lackflag = 1;   //重置缺页标志（默认缺页）
        }

        public void LRU()   //最近最久未使用算法
        {
            int emptyflag = 0;  //物理块为空信号
            int emptydisk = -1; //首个为空的物理块号
            //通过指针位置判断运算状态
            if (vpoint > pagelistlong)
            {
                richTextBox1.AppendText("LRU算法下缺页率为"+( (lackcounts) / (pagelistlong + 1.0)) +"\n" + "-----------------运行结束--------------\n");
                timer1.Stop();  //执行完此次结束
                return; //跳出此次
            }
            richTextBox1.AppendText("物理块 1 已等待" + wait[0] + "\n物理块 2 已等待" + wait[1] + "\n物理块 3 已等待" + wait[2] + "\n");
            disk[0] = disk1.Text;disk[1] = disk2.Text;disk[2] = disk3.Text;//获取当前物理块存储的页号信息
            //不缺页情况（命中）
            for (int i = 0; i < 3; i++)
            {
                if (disk[i] == "")
                {
                    emptyflag = 1;  //标记有物理块为空
                    if(emptydisk == -1)
                    {
                        emptydisk = i;  //储存第一个为空的物理块块号
                    }
                }
                if (Convert.ToString(pagelist[vpoint]) == disk[i])
                {
                    lackflag = 0;   //表示不缺页
                    wait[i] = 0;   //重置物理块等待时间(程序末尾需要统一加一)
                    richTextBox1.AppendText("命中页面" + pagelist[vpoint] + "。物理块" + (i+1) +"的等待时间重置" + "\n");
                    vpoint++;   //递增访问指针
                    break;
                }
            }
            //缺页情况
            if (emptyflag == 1 && lackflag == 1)    //存在物理块为空时
            {
                disk[emptydisk] = Convert.ToString(pagelist[vpoint]); //将页面序号存入空物理块
                disk1.Text = disk[0];disk2.Text = disk[1];disk3.Text = disk[2];//输出物理块信息序列
                richTextBox1.AppendText("物理块" + (emptydisk+1) + "正在访问页面" + disk[emptydisk] + "\n");  //富文本框显示运行情况
                vpoint++;    //递增访问指针
            }
            else if (emptyflag == 0 && lackflag == 1)
            {
                //获取等待最久物理块
                int max = 0;
                for (int i = 0; i < wait.Length; i++)
                {

                    if (wait[i] > wait[max])
                    {
                        max = i;
                    }
                }
                //置换最近最久未访问页面
                string tempdisk = disk[max];
                disk[max] = Convert.ToString(pagelist[vpoint]);
                richTextBox1.AppendText("物理块" + (max+1) + "将页面" + tempdisk + "置换为页面" + disk[max] + "\n");
                disk1.Text = disk[0];disk2.Text = disk[1];disk3.Text = disk[2];//输出物理块信息序列
                lackflag = 1;   //表示缺页
                wait[max] = 0; //重置物理块等待时间
                vpoint++;   //递增访问指针
            }
            //递增各（已存页面）物理块等待时间
            for (int i = 0; i < 3; i++)
            {
                if (disk[i] != "")
                {
                    wait[i]++;
                }
            }  
            if (lackflag == 1) 
            {
                lackcounts++;   //缺页次数加1
            }
            lackflag = 1;   //重置缺页标志（默认缺页） 
        }
        private void start_Click(object sender, EventArgs e)
        {
            lackcounts = 0; //初始化缺页次数
            vpoint = 0; //初始化指针
            wait[0] = 0; wait[1] = 0; wait[2] = 0;  //初始化物理块等待时间
            disk1.Text = "";disk2.Text = "";disk3.Text = "";    //初始化物理块展示输出框
            if (algorithm == "None")
            {
                MessageBox.Show("请选择算法");
            }else timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();   //隐藏程序控制模块
            SystemStartForm SystemStartForm = new SystemStartForm();  //新建开始界面
            SystemStartForm.ShowDialog();   //打开开始界面
        }
    }
}