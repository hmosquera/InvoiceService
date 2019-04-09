using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APIRVInvoiceElectronic.Models;

namespace APIRVInvoiceElectronic.Controllers.Repositories
{
    public class FACTDebitHeaderRepository
    {
        RVInvoice rv = new RVInvoice();
        public FACTDebitHeaderRepository() { }
        public IEnumerable<DebitNoteFile> GetAll()
        {
            List<DebitNoteFile> arr = new List<DebitNoteFile>();
            arr = rv.DebitNoteFiles.ToList();
            return arr;
        }
    }
}