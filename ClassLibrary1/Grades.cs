//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Grades
    {
        public System.Guid Id { get; set; }
        public string IconUrl { get; set; }
        public string Name { get; set; }
        public Nullable<int> Sort { get; set; }
        public Nullable<int> OrderQuantityMin { get; set; }
        public Nullable<decimal> OrderMoneyMin { get; set; }
        public Nullable<int> State { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> DeleteDate { get; set; }
    }
}