using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APIRVInvoiceElectronic.Models;

namespace APIRVInvoiceElectronic.Controllers.Repositories
{
    public class FACTCreditHeaderRepository
    {
        RVInvoice rv = new RVInvoice();
        public FACTCreditHeaderRepository() { }
        public IEnumerable<CreditNoteFile> GetAll()
        {
            List<CreditNoteFile> arr = new List<CreditNoteFile>();
            arr = rv.CreditNoteFiles.ToList();
            return arr;
        }
    }
}