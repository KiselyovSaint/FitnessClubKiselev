//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FitnessClubKiselev.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Service
    {
        public int Id { get; set; }
        public string NameService { get; set; }
        public Nullable<int> Duration { get; set; }
        public decimal Price { get; set; }
        public byte[] Photo { get; set; }
        public string Description { get; set; }
    }
}
