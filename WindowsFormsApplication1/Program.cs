using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
   public static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        public static void Main(string[] aa)
        {
        var newB=    Byte.Parse("rew");
            // 范德萨
         File.Create(@"E:/工作文档/BI/aa.txt", newB);
         
        }
    }
}
