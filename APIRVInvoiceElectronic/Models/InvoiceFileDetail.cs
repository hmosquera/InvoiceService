//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APIRVInvoiceElectronic.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class InvoiceFileDetail
    {
        public string Prefix { get; set; }
        public decimal DocumentNumber1 { get; set; }
        public string ItemCode { get; set; }
        public string ItemType { get; set; }
        public string ItemDescription { get; set; }
        public int Quantity { get; set; }
        public decimal UnitAmount { get; set; }
        public Nullable<decimal> SubTotalAmount1 { get; set; }
        public string IVAPercent { get; set; }
        public Nullable<decimal> IVAAmount { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public string Observation1 { get; set; }
    }
}
