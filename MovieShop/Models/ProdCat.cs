//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProdCat
    {
        public int ProdCatID { get; set; }
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
    
        public virtual Categories Categories { get; set; }
        public virtual Products Products { get; set; }
    }
}
