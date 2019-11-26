using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTEST
{
    public static class DataList
    {
        public static List<Student> DataInit()
        {
            List<Student> list = new List<Student>()
            {
                new Student {id = 1, name = "小王", age = 25},
                new Student {id = 1, name = "莉莉", age = 27},
                new Student {id = 1, name = "王芳", age = 20},
                new Student {id = 1, name = "陈翁", age = 30},
                new Student {id = 1, name = "李晓", age = 26},
                new Student {id = 1, name = "方芳丽", age = 32}
            };
            return list;
        }
    }
}
