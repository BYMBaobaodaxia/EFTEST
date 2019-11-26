using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------start------------------------------------");
            var path = @"E:/工作文档/BI/aa.txt";
           // if (File.Exists(path)) File.Delete(path);
           //FileStream fs= File.Create(@"E:/工作文档/BI/aa.txt");
          byte[] b=   Encoding.GetEncoding("utf-8").GetBytes("呵呵");
          File.WriteAllBytes(path, b);
            Console.WriteLine("----------------------------end------------------------------------");
        }
    }
}
