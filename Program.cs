using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_27
{   //题目要求当n取值连续0,1,2....t时(n*n+a*n+b)得到素数,这个连续值最大t能够达到多少.此时的a和b为何值
    //**************************   时间优化    *****************************
    //n=0时,公式=b得到素数,所以b为素数
    //n=1时,公式=1+b+a
    //n=40时(一定是多于40个的),公式=1600+40a+b
    //i在循环到n之前一旦产生非素数立即break,避免多余循环
    //**********************************************************************
    class Program
    {

        public static bool Primes(int x)
        {
            if (x < 0) { return false; }
            for (int m = 2; m * m <=x; m++)
            {
                if (x % m == 0)
                {
                    return false ;
                }
               
            }
           
            return true;      
        }
        public static void Formula(int absolute) 
        {
            int sum=0;
            int ix = 39;
            int ax = 0;
            int bx = 0;
            for (int a = -absolute; a < absolute; a++)
            {
                for (int b = 1; b < absolute && Primes(b); b++)
                {
                    for (int i = 0; i < absolute; i++)
                    {
                         sum = i * i + a * i + b;
                         Console.WriteLine(sum);
                       if(Primes(sum)==false)
                       {
                           
                           if (i > ix) 
                           { 
                            ax = a;
                            bx = b;
                            ix = i;
                           }
                           break;
                       }
                    }
                }
            }
            Console.WriteLine("最大连续素数值为" + ix+1+"此时公式为n²+" + ax + "n+" + bx + ";a*b=" + ax * bx);
        }
        static void Main(string[] args)
        {
             Formula(1000) ;
             Console.ReadLine();


        }
    }
}
