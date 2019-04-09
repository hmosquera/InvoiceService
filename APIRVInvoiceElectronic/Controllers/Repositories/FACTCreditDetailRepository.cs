using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APIRVInvoiceElectronic.Models;

namespace APIRVInvoiceElectronic.Controllers.Repositories
{
    public class FACTCreditDetailRepository
    {
        RVInvoice rv = new RVInvoice();
        public FACTCreditDetailRepository() { }
        public IEnumerable<CreditFileDetail> GetAll()
        {
            List<CreditFileDetail> arr = new List<CreditFileDetail>();
            arr = rv.CreditFileDetails.ToList();
            return arr;

        }
    }
}