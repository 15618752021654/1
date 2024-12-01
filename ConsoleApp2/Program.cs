using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            //1112410011_王羽潔
            Console.Write("輸入圓半徑：");
            if (!double.TryParse(Console.ReadLine(), out double r)) 
            {
                Console.WriteLine("半徑輸入錯誤，程式結束。");
                return;
            }
            Console.Write("輸入計算精度(4~15)：");
            if (!int.TryParse(Console.ReadLine(), out int n)) 
            {
                Console.WriteLine("精度輸入錯誤，程式結束。");
                return;
            }
            if (n < 4) 
            {
                Console.WriteLine("精度小於 4，程式結束。");
                return;
            }
            if (n > 15) 
            {
                Console.WriteLine("精度大於 15，程式結束。");
                return;
            }
            double pi = CountPi(n);
            if (pi == -1) 
            {
                Console.WriteLine("圓周率計算失敗，程式結束。");
                return;
            }
            Console.WriteLine($"圓周率：{pi:0.000000}");
            Console.WriteLine($"圓周長：{GetCircumference(r, n):0.000000}");
            Console.WriteLine($"圓面積：{GetCircleArea(r, n):0.000000}");
        }
        static double CountPi(int n)
        {
            if (n < 4) return -1;    // 單一條件：n 小於 4
            if (n > 15) return -1;   // 單一條件：n 大於 15

            double pi = 0;
            for (int i = 0; i < n; i++)
            {
                pi += Math.Pow(-1, i) / (2 * i + 1);
            }
            return 4 * pi;
        }
        static double GetCircumference(double r, int n)
        {
            double pi = CountPi(n);
            if (pi == -1) return -1; // 單一條件：pi 為錯誤值
            return 2 * pi * r;
        }
        static double GetCircleArea(double r, int n)
        {
            double pi = CountPi(n);
            if (pi == -1) return -1; // 單一條件：pi 為錯誤值
            return pi * r * r;
        }
    }
}
