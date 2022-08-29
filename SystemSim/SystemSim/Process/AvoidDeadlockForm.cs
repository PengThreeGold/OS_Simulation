using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemSim
{
    public partial class AvoidDeadlockForm : Form
    {
        int FALSE =0;
        int TRUE = 1;
        static int W = 10;
        static int R = 10;
        int[] temp=new int[100];
        static int xl = 0;
        int M; // 总进程数
        int N; // 资源种类
        int[] AllResource=new int[W];  // 各种资源的数目总和
        int[,] Max=new int[W,R];        // 最大需求矩阵，M个进程对N类资源最大资源需求
        int[] Available =new int[R];    // 可利用资源向量，
        int[,] Allocation=new int[W,R]; // 分配矩阵，各个进程M已经得到N类资源的资源数
        int[,] Need=new int[W,R];       // M个进程还需要N类资源的资源量
        int[] Request=new int[R];       // 进程的请求资源个数

        public AvoidDeadlockForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ;
        }
        private void datamaker_Click(object sender, EventArgs e)
        {
            Random random = new Random();   //随机生成数
            this.M = random.Next(4, 7); //进程数在[4,6]
            this.N= random.Next(4, 7);  //资源总数在[4,6]
            //string s = null;
            for (int i = 0; i < AllResource.Length; i++)    //随机分配各类资源资源数（Max10）
            {
                AllResource[i]= random.Next(1,10);
            }
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    do
                    {
                      this.Max[i,j] = random.Next(AllResource[j]) % 10 + 1;
                    } while (Max[i,j] > AllResource[j]);
                }
            }
            for (int i = 0; i < M; i++) //随机分配各进程已得到资源数
            {
                for (int j = 0; j < N; j++)
                {
                    do
                    {
                       Allocation[i,j]= random.Next(0,0);
                       
                    } while (Allocation[i,j] > Max[i,j]);
                }
            }
            int p;
            for (int j = 0; j < N; j++) //计算剩余可利用资源
            {
                p = AllResource[j];
                for (int i = 0; i < M; i++)
                {
                    p = p - Allocation[i,j];// 减去已经被占据的资源
                    Available[j] = p;
                    if (Available[j] < 0)
                        Available[j] = 0;
                }
            }
            for (int i = 0; i < M; i++) //计算各进程仍需要资源数
                for (int j = 0; j < N; j++)
                    Need[i,j] = Max[i,j] - Allocation[i,j];//三个矩阵之间存在的关系
            show(); //显示三个数据表
        }
        public void show()
        {
            int i, j;
            //展示当前各种资源的总数量
            textBox_All.Text = "";
            for (j = 0; j < N; j++)
            {
                textBox_All.Text += AllResource[j] + " ";
            }
            //展示当前剩余资源量（各种资源的总数量减去已分配后剩余的资源量  ）
            textBox_Now.Text = "";
            int sum = 0;
            for (j = 0; j < N; j++)
            {
                textBox_Now.Text += Available[j] + " ";
               sum +=Available[j];
            }
            //展示总数量表格
            DataTable dt_all = new DataTable();
            dt_all.Columns.Add("进程", typeof(string));
            for (i = 0; i < N; i++)
            {
                dt_all.Columns.Add("资源" + i, typeof(string));
            }
            for (i = 0; i < M; i++)
            {
                DataRow dr = dt_all.NewRow();
                dr["进程"] = "进程" + i;
                for (j = 0; j < N; j++)
                    dr["资源" + j] = Max[i, j];
                dt_all.Rows.Add(dr);
            }
            dataGridView_max.DataSource = dt_all;
            //展示所需资源数
            DataTable dt_need = new DataTable();
            dt_need.Columns.Add("进程", typeof(string));
            for (i = 0; i < N; i++)
            {
                dt_need.Columns.Add("资源"+i, typeof(string));
            }
            for (i = 0; i < M; i++)
            {
                DataRow dr = dt_need.NewRow();
                dr["进程"] = "进程"+i;
                for(j=0;j<N;j++)
                dr["资源" + j] = Need[i, j];
                dt_need.Rows.Add(dr);
            }
            dataGridView_need.DataSource = dt_need;
            //展示当前已得到资源数
            DataTable dt_get = new DataTable();
            dt_get.Columns.Add("进程", typeof(string));
            for (i = 0; i < N; i++)
                {
                    dt_get.Columns.Add("资源" + i, typeof(string));
                }
            for (i = 0; i < M; i++)
            {
                DataRow dr = dt_get.NewRow();
                dr["进程"] = "进程" + i;
                for (j = 0; j < N; j++)
                    dr["资源" + j] = Allocation[i,j];
                dt_get.Rows.Add(dr);
            }
            dataGridView_get.DataSource = dt_get;
            //分配异常警告
            if (sum == 0)
            {
                MessageBox.Show("此次资源分配完成，目前所有资源可利用的数量为 0", "警告");
            }
        }
        public void Distribution(int k)    //进行资源分配
        {
            int j;
            //系统试探着把资源分配给进程Pi,并修改下面的数据结构Distribution
            for (j = 0; j < N; j++)
            {
                Available[j] = Available[j] - Request[j];
                Allocation[k,j] = Allocation[k,j] + Request[j];
                Need[k,j] = Need[k,j] - Request[j];
            }
        }
        public void Recycling(int k)   //进行资源回收
        {
            int j;
            for (j = 0; j < N; j++)
            {
                Available[j] = Available[j] + Request[j];
                Allocation[k,j] = Allocation[k,j] - Request[j];
                Need[k,j] = Need[k,j] + Request[j];
            }
        }

        public int Safe()  //安全状态
        {
            int[] Work = new int[R];
            int[] Finish=new int[W];   //设置两个向量Work和Finish.
            int i, j, k,m;
            for (j = 0; j < N; j++)
                Work[j] = Available[j]; //在执行安全算法之前，初始化
            for (i = 0; i < M; i++)
                Finish[i] = FALSE;    //系统初始化，将各进程的初始完成状态设置为false
           
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < N; j++)
                {
                    for (m = 0; m < M; m++)
                    {
                        if (Finish[m] == FALSE && Need[m,j] <= Work[j])
                        {
                            Work[j] = Work[j] + Allocation[m,j];
                            Finish[m] = this.TRUE; //当有足够的资源分配给进程时，设置为true
                            temp[xl] = m;         //记录安全进程序列
                            xl++;
                        }
                    }
                }
            }
            systemmessageshow.Text = "";
            for (k = 0; k < M;) //省略K++,一次访问即可
            {
                if (Finish[k] == FALSE)
                {
                    systemmessageshow.Text = "";
                    systemmessageshow.Text="经安全性算法检查，此时系统处于不安全状态! 本次分配不成功!!!";
                    return 1;
                }
                else
                {
                    systemmessageshow.Text = "";
                    systemmessageshow.Text = "经安全性算法检查，此时系统安全，分配成功。" + Environment.NewLine +  "此时系统的安全序列是：\n";
                    string safanumber = "";
                    for (i = 1; i < xl; i++)
                    {
                        safanumber += temp[i] + "->";
                    }
                    systemmessageshow.Text += safanumber;
                    return 0;
                }
            }
            return 1;
        }
        // 银行家算法
        public void Bank()
        {
            int i = 0, j = 0;
            char flag = 'Y';
            while (flag == 'Y')
            {
                string[] sArray=null;
                i = -1;
                while (i < 0 || i >= M)
                {
                    sArray = Regex.Split(textBox2.Text, " ", RegexOptions.IgnoreCase);
                    i = int.Parse(sArray[0]);
                    foreach (string mm in sArray) Console.WriteLine(mm.ToString() + "<br>");
                    if (i < 0 || i >= M)
                    systemmessageshow.Text="对不起，输入的进程号不存在，请重新输入!\n" ;
                }
                for (j = 0; j < N; j++)
                {
                    Request[j] = int.Parse(sArray[j+1]);
                    if (Request[j] > Need[i,j])
                    {
                        systemmessageshow.Text = "";
                        systemmessageshow.Text = "进程"+i+"申请的资源数大于进程"+i+"还需要"+j+ "类资源的数量!若继续执行系统将处于不安全状态!";
                        label10.ForeColor = Color.Red;
                        flag = 'N';
                        break;
                    }
                    else
                    {
                        if (Request[j] > Available[j])
                        {
                            systemmessageshow.Text = "";
                            systemmessageshow.Text = " 进程"+i+"申请的资源数大于系统可用"+j+ "类资源的数量!若继续执行系统将处于不安全状态!";
                            label10.ForeColor = Color.Red;
                            flag = 'N';
                            break;
                        }

                    }
                }
                if (flag == 'Y')
                {
                    Distribution(i);  // 调用Distribution(i)函数，改变资源数
                    temp[xl] = i;
                    xl++;
                    // 若系统安全
                    if (Safe()!=0)
                    {
                        Recycling(i); // 调用Recycling(i)函数，恢复资源数
                        show();     // 输出资源分配情况
                    }
                    else            // 若系统不安全，输出资源分配情况
                        show();
                    flag = 'N';
                }
            }
        }
        private void apply_Click(object sender, EventArgs e)
        {
            xl = 0; //安全进程序列计数器归零
            if (textBox2.Text == "") MessageBox.Show("请输入各进程获得资源量");    //判空
            Bank(); //运行
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();   //关闭程序控制模块
            ProcessStartForm startForm = new ProcessStartForm();  //新建开始界面
            startForm.ShowDialog();   //打开开始界面
        }

        private void systemmessageshow_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
