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
    
    public partial class Owners
    {
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> UserId { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Store { get; set; }
        public string StoreNo { get; set; }
        public Nullable<System.Guid> StoreId { get; set; }
        public string Neighborhood { get; set; }
        public string DecorateProgress { get; set; }
        public string Remark { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> State { get; set; }
        public Nullable<int> OrderState { get; set; }
        public string FailReason { get; set; }
        public string AuditRemark { get; set; }
        public Nullable<System.DateTime> AuditDate { get; set; }
        public string GuiderCode { get; set; }
        public string GuiderName { get; set; }
        public string GuiderTel { get; set; }
        public Nullable<int> IntoShop { get; set; }
        public string AuditCode { get; set; }
        public string AuditName { get; set; }
    
        public virtual Users Users { get; set; }
    }
}