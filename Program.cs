using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace EFTEST
{
    class Program
    {
        static void Main(string[] args)
        {
            Entities db = new Entities();

            var data5 = (from a in db.Users select a.StoreNo).Distinct();
            var d = from a in db.Users
                join b in db.Owners on a equals b.Users into c 
                from b in c.DefaultIfEmpty()
                select new {a.Id, a.Name,b};
            var ee = d.ToList();
            return;
            var data = from a in db.Users
                       group a by a.StoreNo into aa
                       select new
                       {
                           storeno = aa.Key,
                           state = from b in aa where b.State > aa.Average(o => o.State) select b
                       };
            var bbb = data.Count();
            var data2 = from a in db.Users
                        where a.StoreNo != null
                        group a by a.StoreNo into g
                        select new
                        {
                            storeNo = g.Key,
                            firstUser = from g2 in g where g2.CreateDate == g.Min(o => o.CreateDate) select g2
                        };
            var bb = data2.ToList();


            var data3 = from a in db.Users
                from b in db.Owners
                where a.Id == b.UserId
                select new {b.Name,username=a.Name,a.Id };
            var cc = data3.ToList();

            var data4 = from a in db.Users
                from b in a.Owners
                select new { b.Name, username = a.Name, a.Id };
            var dd = data4.ToList();
            var ff = "";
        }

    }
}
