//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public Nullable<decimal> ProductPrice { get; set; }
        public Nullable<decimal> Cost_Price { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Nullable<int> BrandId { get; set; }
        public Nullable<int> ClickCount { get; set; }
        public Nullable<int> Product_StatusId { get; set; }
        public Nullable<int> PictureId { get; set; }
        public Nullable<int> Stock { get; set; }
        public Nullable<System.DateTime> CreationTime { get; set; }
        public Nullable<int> Capacity { get; set; }
        public Nullable<int> PackingId { get; set; }
    
        public virtual Product_Status Product_Status { get; set; }
        public virtual Product Product1 { get; set; }
        public virtual Product Product2 { get; set; }
        public virtual Product_Status Product_Status1 { get; set; }
    }
}
