//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExamPM
{
    using System;
    using System.Collections.Generic;
    
    public partial class Accounting
    {
        public int ID { get; set; }
        public Nullable<int> IDMedicine { get; set; }
        public Nullable<int> IDPharmacy { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string Price { get; set; }
    
        public virtual Medicine Medicine { get; set; }
        public virtual Pharmacy Pharmacy { get; set; }
    }
}
