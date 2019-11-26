using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTEST
{
    public static class LinqTest
    {

        public static void LinqShow()
        {
            Func<Student, bool> func = new Func<Student, bool>(o => o.age > 20);
            List<Student> list = DataList.DataInit();
            list.BymWhereStudent(o => o.age > 28);
            IEnumerable<Student> newlist = list.BymWhereEnumerable<Student>(func);
            list = newlist.ToList();
            List<int> list2 = new List<int> { 1, 23, 454, 65, 212, 66, 43, 7 };
            IEnumerable<int> re = list2.BymWhereEnumerable<int>(o => o > 100);

           
            Action<Student> action = new Action<Student>(o =>{});
        }

        public static List<Student> BymWhereStudent(this List<Student> list, Func<Student, bool> fun)
        {
            return (List<Student>) list.Where(item => fun.Invoke(item));
        }

        /// <summary>
        /// 通用泛型委托
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iList"></param>
        /// <param name="fun"></param>
        /// <returns></returns>
        public static IEnumerable<T> BymWhereEnumerable<T>(this IEnumerable<T> iList, Func<T, bool> fun)
        {
            foreach (var item in iList)
            {
                if (fun.Invoke(item))
                {
                    yield return item;
                }
            }
        }

    }
}
