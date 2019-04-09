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
    public class FACTDebitDetailController : ApiController
    {
        FACTDebitDetailRepository fac = new FACTDebitDetailRepository();
        public FACTDebitDetailController() { }

        [HttpGet]
        public IEnumerable<DebitFileDetail> Get() { return fac.GetAll(); }
    }
}
