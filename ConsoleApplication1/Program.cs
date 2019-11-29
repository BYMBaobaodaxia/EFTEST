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
            //  Console.WriteLine("----------------------------start------------------------------------");
            //  var path = @"E:/工作文档/BI/aa"+DateTime.Now.ToLongTimeString()+".txt";
            // // if (File.Exists(path)) File.Delete(path);
            // //FileStream fs= File.Create(@"E:/工作文档/BI/aa.txt");
            //byte[] b=   Encoding.GetEncoding("utf-8").GetBytes("呵呵");
            //File.WriteAllBytes(path, b);
            //  Console.WriteLine("----------------------------end------------------------------------");
            Console.OutputEncoding = Encoding.Default;
            int argsLength = args.Length;
            Console.WriteLine("Main函数参数args的长度：" + argsLength.ToString());
            for (int i = 0; i < argsLength; i++)
            {
                Console.Write("第" + i.ToString() + "位是：");
                Console.WriteLine(args[i].ToString());
            }
            Console.ReadLine();


            var a = 0;
            var b = "(" + a + 0 + 1 + 2 + ")";


            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add(",", "");
            Stack<string> str = new Stack<string>();
        }
    }
}
