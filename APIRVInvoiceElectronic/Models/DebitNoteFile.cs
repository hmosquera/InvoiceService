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
    
    public partial class DebitNoteFile
    {
        public string DNPrefix { get; set; }
        public decimal DNNumber { get; set; }
        public string DocumentNumber { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
        public string InvoiceNumber { get; set; }
        public decimal SubTotalAmount { get; set; }
        public decimal TaxTotalAmount { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public int CauseId { get; set; }
        public decimal ReteFuente { get; set; }
        public string Observation1 { get; set; }
    }
}
