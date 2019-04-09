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
    public class FACTInvoiceDetailController : ApiController
    {
        FACTInvoiceDetailRepository fac = new FACTInvoiceDetailRepository();
        public FACTInvoiceDetailController() { }

        [HttpGet]
        public IEnumerable<InvoiceFileDetail> Get() { return fac.GetAll(); }
    }
}
