using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using APIRVInvoiceElectronic.Models;
using System.Web.Mvc;



namespace APIRVInvoiceElectronic.Controllers.Repositories
{
    public class FACTInvoiceHeaderRepository
    {
        RVInvoice rv = new RVInvoice();
        public FACTInvoiceHeaderRepository() { }
        public IEnumerable<InvoiceFileHeader> GetAll()
        {
            List<InvoiceFileHeader> arr = new List<InvoiceFileHeader>();
            arr = rv.InvoiceFileHeaders.ToList();
            return arr;

        }
    }
}