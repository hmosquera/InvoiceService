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
    public class FACTInvoiceHeaderController : ApiController
    {
        FACTInvoiceHeaderRepository fac = new FACTInvoiceHeaderRepository();
        public FACTInvoiceHeaderController() { }

        [HttpGet]
        public IEnumerable<InvoiceFileHeader> Get() { return fac.GetAll(); }
    }
}
