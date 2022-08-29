using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemSim
{
    public class PCB
    {
        /*
       声明进程相关变量类
       */
        public string Pname //进程名
        {
            get;
            set;
        }
        public int Pid  //进程id
        {
            get;
            set;
        }
        public int Ppriority //进程优先级（1、2……）
        {
            get;
            set;
        }
        public string Pstate    //进程状态（就绪，运行，阻塞，消亡）
        {
            get;
            set;
        }
        public int Ptimeslice   //时间片长度
        {
            get;
            set;
        }
        public double Presponserate    //进程响应比
        {
            get;
            set;
        }
        public int Parrivetime  //进程到达时间
        {
            get;
            set;
        }
        public int Povertime    //进程运行结束时间
        {
            get;
            set;
        }

    }
}
