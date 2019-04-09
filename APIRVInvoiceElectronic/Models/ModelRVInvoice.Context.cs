﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class RVInvoice : DbContext
    {
        public RVInvoice()
            : base("name=RVInvoice")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CreditFileDetail> CreditFileDetails { get; set; }
        public virtual DbSet<CreditNoteFile> CreditNoteFiles { get; set; }
        public virtual DbSet<DebitFileDetail> DebitFileDetails { get; set; }
        public virtual DbSet<DebitNoteFile> DebitNoteFiles { get; set; }
        public virtual DbSet<InvoiceFileDetail> InvoiceFileDetails { get; set; }
        public virtual DbSet<InvoiceFileHeader> InvoiceFileHeaders { get; set; }
        public virtual DbSet<InvoiceLogStored> InvoiceLogStoreds { get; set; }

        public virtual ObjectResult<InvoiceLogStored_Result> InvoiceLogStored(Nullable<int> opcion, string prefix, string number, string response, string respuesta)
        {
            var opcionParameter = opcion.HasValue ?
                new ObjectParameter("opcion", opcion) :
                new ObjectParameter("opcion", typeof(int));
    
            var prefixParameter = prefix != null ?
                new ObjectParameter("prefix", prefix) :
                new ObjectParameter("prefix", typeof(string));
    
            var numberParameter = number != null ?
                new ObjectParameter("number", number) :
                new ObjectParameter("number", typeof(string));
    
            var responseParameter = response != null ?
                new ObjectParameter("response", response) :
                new ObjectParameter("response", typeof(string));
    
            var respuestaParameter = respuesta != null ?
                new ObjectParameter("respuesta", respuesta) :
                new ObjectParameter("respuesta", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<InvoiceLogStored_Result>("InvoiceLogStored", opcionParameter, prefixParameter, numberParameter, responseParameter, respuestaParameter);
        }
    }
}