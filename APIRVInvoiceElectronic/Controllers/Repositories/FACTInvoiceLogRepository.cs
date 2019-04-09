using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APIRVInvoiceElectronic.Models;

namespace APIRVInvoiceElectronic.Controllers.Repositories
{
    public class FACTInvoiceLogRepository
    {
        RVInvoice rv = new RVInvoice();
        public FACTInvoiceLogRepository() { }
        public IEnumerable<InvoiceLogStored> GetAll()
        {
            List<InvoiceLogStored> arr = new List<InvoiceLogStored>();
            arr = rv.InvoiceLogStoreds.ToList();
            return arr;

        }
    }
}