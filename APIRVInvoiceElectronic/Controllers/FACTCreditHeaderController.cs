using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using APIRVInvoiceElectronic.Controllers.Repositories;
using APIRVInvoiceElectronic.Models;

namespace APIRVInvoiceElectronic.Controllers
{
    public class FACTCreditHeaderController : ApiController
    {
        FACTCreditHeaderRepository fac = new FACTCreditHeaderRepository();
        public FACTCreditHeaderController() { }

        [HttpGet]
        public IEnumerable<CreditNoteFile> Get() { return fac.GetAll(); }
    }
}
