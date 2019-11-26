using System;
using System.Collections.Generic;
using System.Data;
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
            LinqTest.LinqShow();

            //  Entities db = new Entities();
            //  //var data5 = (from a in db.Users select a.StoreNo).Distinct();
            //  //var d = from a in db.Users
            //  //        join b in db.Owners on a equals b.Users into c
            //  //        from b in c.DefaultIfEmpty()
            //  //        select new { a.Id, a.Name, b };
            //  //var ee = d.ToList();

            //  //var d1 = from a in db.Users
            //  //         join b in db.Owners on a equals b.Users into c
            //  //         select new { a.Id, a.Name, c };
            //  //var ee1 = d1.ToList();

            //  //var d2 = from a in db.Users
            //  //         join b in db.Owners on a.Id equals (Guid?)b.UserId into c orderby a.CreateDate descending
            //  //         select new { a.Id, a.Name, c };
            //  //var ee2 = d2.ToList();
            //  var t = "234.3,";
            //var items=t.Split(new char[]{'.',','},StringSplitOptions.RemoveEmptyEntries);
            //return;
            //var d3 = from a in db.Users
            //    join b in db.Owners on a.Id equals b.UserId 
            //    select new { a.Id, a.Name};
            //var ee3 = d3.ToList();

            //var dd2 = from a in db.Users where (new[] {"包包","兔子"}).Contains(a.Name) select a;
            //var result= dd2.ToList();

            //// var q = from a in db.Users where a.Name.StartsWith("包包") select a;
            //var q = from a in db.Users where a.Name.Contains("包包") select a;

            //var dd3 =  db.Users.SingleOrDefault(o=>o.Name=="包包");



            //DataSet ds = new DataSet();
            //// 省略ds的Fill代码
            //DataTable products = ds.Tables["Product"];
            //IEnumerable<DataRow> rows = from p in products.AsEnumerable()  select p;

            //EnumerableRowCollection<DataRow> expr = from p in products.AsEnumerable()
            //    orderby p.Field<int>("SortOrder")
            //    select p;
            //DataView view = expr.AsDataView();




            //var data = from a in db.Users
            //           group a by a.StoreNo into aa
            //           select new
            //           {
            //               storeno = aa.Key,
            //               state = from b in aa where b.State > aa.Average(o => o.State) select b
            //           };
            //var bbb = data.Count();
            //var data2 = from a in db.Users
            //            where a.StoreNo != null
            //            group a by a.StoreNo into g
            //            select new
            //            {
            //                storeNo = g.Key,
            //                firstUser = from g2 in g where g2.CreateDate == g.Min(o => o.CreateDate) select g2
            //            };
            //var bb = data2.ToList();


            //var data3 = from a in db.Users
            //    from b in db.Owners
            //    where a.Id == b.UserId
            //    select new {b.Name,username=a.Name,a.Id };
            //var cc = data3.ToList();

            //var data4 = from a in db.Users
            //    from b in a.Owners
            //    select new { b.Name, username = a.Name, a.Id };
            //var dd = data4.ToList();
            //var ff = "";
        }

    }
}
