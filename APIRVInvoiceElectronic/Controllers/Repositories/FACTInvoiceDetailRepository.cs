using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APIRVInvoiceElectronic.Models;

namespace APIRVInvoiceElectronic.Controllers.Repositories
{
    public class FACTInvoiceDetailRepository
    {
        RVInvoice rv = new RVInvoice();
        public FACTInvoiceDetailRepository() { }
        public IEnumerable<InvoiceFileDetail> GetAll()
        {
            List<InvoiceFileDetail> arr = new List<InvoiceFileDetail>();
            arr = rv.InvoiceFileDetails.ToList();
            return arr;

        }
    }
}