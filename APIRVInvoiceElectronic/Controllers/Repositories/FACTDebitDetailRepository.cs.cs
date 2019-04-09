using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APIRVInvoiceElectronic.Models;

namespace APIRVInvoiceElectronic.Controllers.Repositories
{
    public class FACTDebitDetailRepository
    {
        RVInvoice rv = new RVInvoice();
        public FACTDebitDetailRepository() { }
        public IEnumerable<DebitFileDetail> GetAll()
        {
            List<DebitFileDetail> arr = new List<DebitFileDetail>();
            arr = rv.DebitFileDetails.ToList();
            return arr;

        }
    }
}