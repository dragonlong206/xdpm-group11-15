using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 7;
            TinhToan tt = new TinhToan();

            int kq = tt.Tong(a, b);

            Console.WriteLine(a.ToString() + " + " + b.ToString() + " = " + kq.ToString());

        }
    }
}
