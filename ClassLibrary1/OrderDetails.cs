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
    
    public partial class OrderDetails
    {
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> OwnerFKId { get; set; }
        public string Remark { get; set; }
        public Nullable<System.DateTime> NextDate { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CurrStatus { get; set; }
        public string FollowUser { get; set; }
        public Nullable<System.Guid> OrderFKId { get; set; }
        public string IntoShop { get; set; }
    }
}
