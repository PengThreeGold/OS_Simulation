using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SystemSim
{
    public partial class EquipmentCtrl : Form
    {
        public EquipmentCtrl()
        {
            InitializeComponent();
        }

        private void EquipmentCtrl_Load(object sender, EventArgs e)
        {
            ;
        }

        private void EquipmentCtrl_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            SystemStartForm systemStartForm = new SystemStartForm();
            systemStartForm.ShowDialog();
        }

        int[] Tracknumber_List = new int[10];   //定义磁道号序列列表

        string algorithm;   //定义算法模式

        Random r = new Random();    //随机数对象

        int[] small = new int[10];  //scan算法小数组
        int[] big = new int[10];    //scan算法大数组
        int[] scan = new int[10];   //scan算法数组
        int[] cscan = new int[10];  //cscan算法数组

        int vpoint = 0; //定义磁道访问指针
        int smallp = 0; //小数组指针
        int bigp = 0;   //大数组指针
        int scanp = 0;  //scan数组指针
        int cscanp = 0; //cscan数组指针
        int zerop = -1; //0柱面定位指针

        int times = 0;  //寻道时间
        int zero = 0;   //是否回归0柱面（0否）

        //首次访问信号
        int flag1 = 0;
        int flag2 = 0;
        int flag3 = 0;
        int flag4 = 0;

        bool repeat(int temp,int i)    //鉴定当前随机数是否存在于数组中（存在true）(且不包含初始柱面27)
        {
            for (int j = 0; j < i; j++)
            {
                if (Tracknumber_List[j] == temp || temp == 27) return true;
            }
            return false;
        }
        private void random_apply_Click(object sender, EventArgs e)
        {
            number_list.Clear();    //格式化磁道号序列文本框
            string str = "";    //磁道号序列
            Random r = new Random();    //随机函数类对象
            for (int i = 0; i < Tracknumber_List.Length; i++)   //生成随机的磁道号序列且不重复
            {
                int temp = r.Next(1, 101);  //生成随机数
                while (this.repeat(temp, i))    //确保加入数组中的数唯一
                {
                    temp = r.Next(1, 101);
                }
                Tracknumber_List[i] = temp;
                str += Tracknumber_List[i] + " ";   //磁道号序列字符串相加
            }
            number_list.Text = str; //文本框显示磁道号序列

        }

        void reset()
        {
            //初始化寻道指针
            vpoint = 0; 
            smallp = 0;
            bigp = 0;
            scanp = 0;
            cscanp = 0;
            //初始化常量
            times = 0;
            zerop = -1;
            minlong = 101;
            //初始化数组
            scan = new int[10];
            cscan = new int[10];
            //初始化信号量
            flag1 = 0;
            flag2 = 0;
            flag3 = 0;
            flag4 = 0;
        }
        private void run_Click(object sender, EventArgs e)
        {
            if(number_list.Text == "")  //验证是否存在磁道号序列
            {
                MessageBox.Show("请生成磁道号序列");
                return;
            }
            if(algorithm == "") //验证是否选择磁盘调度算法
            {
                MessageBox.Show("请选择磁盘调度算法");
                return;
            }
            this.reset();
            if (flag1 == 0)
            {
                chart1.Series["Series1"].Points.Clear();
                chart1.Series["Series1"].Points.AddXY(0, 27);   //初始柱面
                richTextBox1.AppendText("算法1从初始柱面 27 出发\n");
            }
            if (flag2 == 0)
            {
                chart1.Series["Series2"].Points.Clear();
                chart1.Series["Series2"].Points.AddXY(0, 27);   //初始柱面
                richTextBox1.AppendText("算法2从初始柱面 27 出发\n");
            }
            if (flag3 == 0)
            {
                chart1.Series["Series3"].Points.Clear();
                chart1.Series["Series3"].Points.AddXY(0, 27);   //初始柱面
                richTextBox1.AppendText("算法3从初始柱面 27 出发\n");
            }
            if (flag4 == 0)
            {
                chart1.Series["Series4"].Points.Clear();
                chart1.Series["Series4"].Points.AddXY(0, 27);   //初始柱面
                richTextBox1.AppendText("算法4从初始柱面 27 出发\n");
            }
            timer1.Start();
        }

        private void compare_Click(object sender, EventArgs e)
        {
            algorithm = "compare";
            this.reset();
            this.reset();
            if (flag1 == 0)
            {
                chart1.Series["Series1"].Points.Clear();
                chart1.Series["Series1"].Points.AddXY(0, 27);   //初始柱面
                richTextBox1.AppendText("算法1从初始柱面 27 出发\n");
            }
            if (flag2 == 0)
            {
                chart1.Series["Series2"].Points.Clear();
                chart1.Series["Series2"].Points.AddXY(0, 27);   //初始柱面
                richTextBox1.AppendText("算法2从初始柱面 27 出发\n");
            }
            if (flag3 == 0)
            {
                chart1.Series["Series3"].Points.Clear();
                chart1.Series["Series3"].Points.AddXY(0, 27);   //初始柱面
                richTextBox1.AppendText("算法3从初始柱面 27 出发\n");
            }
            if (flag4 == 0)
            {
                chart1.Series["Series4"].Points.Clear();
                chart1.Series["Series4"].Points.AddXY(0, 27);   //初始柱面
                richTextBox1.AppendText("算法4从初始柱面 27 出发\n");
            }
            timer2.Start();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();   //关闭程序控制模块
            SystemStartForm SystemStartForm = new SystemStartForm();  //新建开始界面
            SystemStartForm.ShowDialog();   //打开开始界面
        }
        //获取用户选择的算法
        private void radioButton1_Click(object sender, EventArgs e)
        {
            algorithm = radioButton1.Text;
            richTextBox1.AppendText("已选择算法"+algorithm+"\n");
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            algorithm = radioButton2.Text;
            richTextBox1.AppendText("已选择算法" + algorithm + "\n");
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            algorithm = radioButton3.Text;
            richTextBox1.AppendText("已选择算法" + algorithm + "\n");
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            algorithm = radioButton4.Text;
            richTextBox1.AppendText("已选择算法" + algorithm + "\n");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (algorithm == "FCFS")
            {
                this.FCFS();
            }
            else if(algorithm == "SSTF")
            {
                this.SSTF();
            }
            else if (algorithm == "SCAN")
            {
                this.SCAN();
            }
            else if (algorithm == "C-SCAN")
            {
                this.CSCAN();
            }
        }  

        void FCFS()
        {
            flag1 = 1;  //标记已经运行
            if (vpoint == 10)
            {
                timer1.Stop();
                richTextBox1.AppendText("FCFS寻道算法寻道时间为：" + times + "\n");
                return;
            }
            chart1.Series["Series1"].Points.AddXY(vpoint+1, Tracknumber_List[vpoint]);    //显示寻道情况
            if (vpoint > 0)  //计算寻道时间
            {
                times += Math.Abs(Tracknumber_List[vpoint] - Tracknumber_List[vpoint - 1]);
            }
            else times +=Math.Abs(Tracknumber_List[vpoint] - 27);
            richTextBox1.AppendText("到达柱面" + Tracknumber_List[vpoint] + "\n"); //显示到达情况
            richTextBox1.AppendText("已寻道" + times + "s\n"); //显示到达情况
            vpoint++;
        }


        int[] sstf = new int[10];   //临时算法使用数组
        int minlong = 101;    //最近磁道量
        void SSTF()
        {
            flag2 = 1;
            if (vpoint == 10)   //结束标志
            {
                timer1.Stop();
                richTextBox1.AppendText("SSTF寻道算法寻道时间为：" + times + "\n");
                return;
            }

            for(int i = vpoint; i < Tracknumber_List.Length; i++)
            {
                if (vpoint == 0)    //首位
                {
                    sstf = Tracknumber_List;    //初始化该算法临时数组
                    if (Math.Abs(sstf[i] - 27) < minlong)   //判断最近磁道
                    {
                        int temp = sstf[vpoint];
                        sstf[vpoint] = sstf[i];
                        sstf[i] = temp;
                        minlong = Math.Abs(sstf[vpoint] - 27);   //更新最近磁道量
                    }
                }
                //其余位置
                else
                {
                    if(Math.Abs(sstf[i] - sstf[vpoint - 1]) < minlong)
                    {
                        int temp = sstf[vpoint];
                        sstf[vpoint] = sstf[i];
                        sstf[i] = temp;
                        minlong = Math.Abs(sstf[vpoint] - sstf[vpoint - 1]);
                    }
                }
            }

            if(vpoint == 0)
            {
                times += Math.Abs(sstf[vpoint] - 27);
            }else times += Math.Abs(sstf[vpoint] - sstf[vpoint-1]);

            chart1.Series["Series2"].Points.AddXY(vpoint+1, sstf[vpoint]); //显示寻道情况
            richTextBox1.AppendText("到达柱面" + sstf[vpoint] + "\n"); //显示到达情况
            richTextBox1.AppendText("已寻道" + times + "s\n"); //显示到达情况
            //重置记录信息
            minlong = 101;

            vpoint++;
        }

        void SCAN()
        {
            if (vpoint == 10)   //结束标志
            {
                timer1.Stop();
                richTextBox1.AppendText("SCAN寻道算法寻道时间为：" + times + "\n");
                return;
            }

            if (flag3 == 0) //初次运行,计算整体运行轨迹
            {
                big = new int[10];
                bigp = 0;
                smallp = 0;
                small = new int[10];
                
                for (int i = 0; i < Tracknumber_List.Length; i++)
                {
                    if (Tracknumber_List[i] < 27)
                    {
                        small[smallp] = Tracknumber_List[i];
                        smallp++;
                    }
                    else
                    {
                        big[bigp] = Tracknumber_List[i];
                        bigp++;
                    }
                }
                //先小再大
                Array.Sort(small);
                Array.Reverse(small);
                for (int i = 0; i < smallp; i++)
                {
                    scan[scanp] = small[i];
                    scanp++;
                }
                Array.Sort(big);
                for (int i = 0; i < big.Length; i++)
                {
                    if (big[i] != 0)
                    {
                        scan[scanp] = big[i];
                        scanp++;
                    }
                }
            }
            flag3 = 1;  //标记为以进行初始化操作

            if (vpoint == 0)
            {
                times += Math.Abs(scan[vpoint] - 27);
            }else times += Math.Abs(scan[vpoint] - scan[vpoint-1]);

            chart1.Series["Series3"].Points.AddXY(vpoint + 1, scan[vpoint]); //显示寻道情况
            richTextBox1.AppendText("到达柱面" + scan[vpoint] + "\n"); //显示到达情况
            richTextBox1.AppendText("已寻道" + times + "s\n"); //显示到达情况
            vpoint++;
        }
        
        void CSCAN()
        {
            if (vpoint == 10)   //结束标志
            {
                timer1.Stop();
                richTextBox1.AppendText("CSCAN寻道算法寻道时间为：" + times + "\n");
                return;
            }
            if (flag3 == 0) //初次运行,计算整体运行轨迹
            {
                big = new int[10];
                bigp = 0;
                small = new int[10];
                smallp = 0;

                for (int i = 0; i < Tracknumber_List.Length; i++)
                {
                    if (Tracknumber_List[i] < 27)
                    {
                        small[smallp] = Tracknumber_List[i];
                        smallp++;
                    }
                    else
                    {
                        big[bigp] = Tracknumber_List[i];
                        bigp++;
                    }
                }
                //先大返0再大
                Array.Sort(big);
                for (int i = 0; i < big.Length; i++)
                {
                    if (big[i] != 0)
                    {
                        cscan[cscanp] = big[i];
                        cscanp++;
                    }
                }
                zerop = cscanp;
                Array.Sort(small);
                for (int i = 0; i < small.Length; i++)
                {
                    if (small[i] != 0)
                    {
                        cscan[cscanp] = small[i];
                        cscanp++;
                    }
                }
            }
            flag3 = 1;  //标记为以进行初始化操作
            if(vpoint == zerop && zero == 0)
            {
                chart1.Series["Series4"].Points.AddXY(vpoint+0.5, 0); //显示寻道情况
                richTextBox1.AppendText("回到0柱面重新扫描");
                zero = 1;   //标记已经回归过0柱面
                //return;
            }
            if (vpoint == 0)
            {
                times += Math.Abs(cscan[vpoint] - 27);
            }
            else times += Math.Abs(cscan[vpoint] - cscan[vpoint - 1]);

            chart1.Series["Series4"].Points.AddXY(vpoint + 1, cscan[vpoint]); //显示寻道情况
            richTextBox1.AppendText("到达柱面" + cscan[vpoint] + "\n"); //显示到达情况
            richTextBox1.AppendText("已寻道" + times + "s\n"); //显示到达情况
            vpoint++;
        }
        int[] all_times = new int[4];
        private void timer2_Tick(object sender, EventArgs e)
        {
            flag1 = 1;  //标记已经运行
            if (vpoint == 10)
            {
                timer2.Stop();
                //richTextBox1.AppendText("FCFS寻道算法寻道时间为：" + times + "\n");
                all_times[0] = times;
                this.reset();
                timer3.Start();
                return;
            }
            chart1.Series["Series1"].Points.AddXY(vpoint + 1, Tracknumber_List[vpoint]);    //显示寻道情况
            if (vpoint > 0)  //计算寻道时间
            {
                times += Math.Abs(Tracknumber_List[vpoint] - Tracknumber_List[vpoint - 1]);
            }
            else times += Math.Abs(Tracknumber_List[vpoint] - 27);
            //richTextBox1.AppendText("到达柱面" + Tracknumber_List[vpoint] + "\n"); //显示到达情况
            //richTextBox1.AppendText("已寻道" + times + "s\n"); //显示到达情况
            vpoint++;

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            flag2 = 1;
            if (vpoint == 10)   //结束标志
            {
                timer3.Stop();
                //richTextBox1.AppendText("SSTF寻道算法寻道时间为：" + times + "\n");
                all_times[1] = times;
                this.reset();
                timer4.Start();
                return;
            }

            for (int i = vpoint; i < Tracknumber_List.Length; i++)
            {
                if (vpoint == 0)    //首位
                {
                    sstf = Tracknumber_List;    //初始化该算法临时数组
                    if (Math.Abs(sstf[i] - 27) < minlong)   //判断最近磁道
                    {
                        int temp = sstf[vpoint];
                        sstf[vpoint] = sstf[i];
                        sstf[i] = temp;
                        minlong = Math.Abs(sstf[vpoint] - 27);   //更新最近磁道量
                    }
                }
                //其余位置
                else
                {
                    if (Math.Abs(sstf[i] - sstf[vpoint - 1]) < minlong)
                    {
                        int temp = sstf[vpoint];
                        sstf[vpoint] = sstf[i];
                        sstf[i] = temp;
                        minlong = Math.Abs(sstf[vpoint] - sstf[vpoint - 1]);
                    }
                }
            }

            if (vpoint == 0)
            {
                times += Math.Abs(sstf[vpoint] - 27);
            }
            else times += Math.Abs(sstf[vpoint] - sstf[vpoint - 1]);

            chart1.Series["Series2"].Points.AddXY(vpoint + 1, sstf[vpoint]); //显示寻道情况
            //richTextBox1.AppendText("到达柱面" + sstf[vpoint] + "\n"); //显示到达情况
            //richTextBox1.AppendText("已寻道" + times + "s\n"); //显示到达情况
            //重置记录信息
            minlong = 101;
            vpoint++;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (vpoint == 10)   //结束标志
            {
                timer4.Stop();
                //richTextBox1.AppendText("SCAN寻道算法寻道时间为：" + times + "\n");
                all_times[2] = times;
                this.reset();
                timer5.Start();
                return;
            }

            if (flag3 == 0) //初次运行,计算整体运行轨迹
            {
                big = new int[10];
                bigp = 0;
                smallp = 0;
                small = new int[10];

                for (int i = 0; i < Tracknumber_List.Length; i++)
                {
                    if (Tracknumber_List[i] < 27)
                    {
                        small[smallp] = Tracknumber_List[i];
                        smallp++;
                    }
                    else
                    {
                        big[bigp] = Tracknumber_List[i];
                        bigp++;
                    }
                }
                //先小再大
                Array.Sort(small);
                Array.Reverse(small);
                for (int i = 0; i < smallp; i++)
                {
                    scan[scanp] = small[i];
                    scanp++;
                }
                Array.Sort(big);
                for (int i = 0; i < big.Length; i++)
                {
                    if (big[i] != 0)
                    {
                        scan[scanp] = big[i];
                        scanp++;
                    }
                }
            }
            flag3 = 1;  //标记为以进行初始化操作

            if (vpoint == 0)
            {
                times += Math.Abs(scan[vpoint] - 27);
            }
            else times += Math.Abs(scan[vpoint] - scan[vpoint - 1]);

            chart1.Series["Series3"].Points.AddXY(vpoint + 1, scan[vpoint]); //显示寻道情况
            //richTextBox1.AppendText("到达柱面" + scan[vpoint] + "\n"); //显示到达情况
            //richTextBox1.AppendText("已寻道" + times + "s\n"); //显示到达情况
            vpoint++;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (vpoint == 10)   //结束标志
            {
                timer5.Stop();
                all_times[3] = times;
                int[] temp = all_times;
                Array.Sort(temp);
                richTextBox1.AppendText("四种算法寻道时间最短为：" + temp[0] + "\n");
                richTextBox1.AppendText("优点分析：SSTF 是常见的，并且具有自然的吸引力，因为它比 FCFS 具有更好的性能。\n" +
                    "对于磁盘负荷较大的系统，SCAN 和 C-SCAN 表现更好，因为它们不太可能造成饥饿问题。");
                return;
            }
            if (flag3 == 0) //初次运行,计算整体运行轨迹
            {
                big = new int[10];
                bigp = 0;
                small = new int[10];
                smallp = 0;

                for (int i = 0; i < Tracknumber_List.Length; i++)
                {
                    if (Tracknumber_List[i] < 27)
                    {
                        small[smallp] = Tracknumber_List[i];
                        smallp++;
                    }
                    else
                    {
                        big[bigp] = Tracknumber_List[i];
                        bigp++;
                    }
                }
                //先大返0再大
                Array.Sort(big);
                for (int i = 0; i < big.Length; i++)
                {
                    if (big[i] != 0)
                    {
                        cscan[cscanp] = big[i];
                        cscanp++;
                    }
                }
                zerop = cscanp;
                Array.Sort(small);
                for (int i = 0; i < small.Length; i++)
                {
                    if (small[i] != 0)
                    {
                        cscan[cscanp] = small[i];
                        cscanp++;
                    }
                }
            }
            flag3 = 1;  //标记为以进行初始化操作
            if (vpoint == zerop && zero == 0)
            {
                chart1.Series["Series4"].Points.AddXY(vpoint + 0.5, 0); //显示寻道情况
                //richTextBox1.AppendText("回到0柱面重新扫描");
                zero = 1;   //标记已经回归过0柱面
                //return;
            }
            if (vpoint == 0)
            {
                times += Math.Abs(cscan[vpoint] - 27);
            }
            else times += Math.Abs(cscan[vpoint] - cscan[vpoint - 1]);

            chart1.Series["Series4"].Points.AddXY(vpoint + 1, cscan[vpoint]); //显示寻道情况
            //richTextBox1.AppendText("到达柱面" + cscan[vpoint] + "\n"); //显示到达情况
            //richTextBox1.AppendText("已寻道" + times + "s\n"); //显示到达情况
            vpoint++;
        }
    }
}
