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
    public class FACTInvoiceLogController : ApiController
    {
        FACTInvoiceLogRepository fac = new FACTInvoiceLogRepository();
        public FACTInvoiceLogController() { }

        [HttpGet]
        public IEnumerable<InvoiceLogStored> Get() { return fac.GetAll(); }

        public IHttpActionResult Post(InvoiceLogStored item)
        {
            try
            {
                if (item.opcion != 0)
                {
                    return Ok(fac.AddInvoiceLogStored(item));
                }
                else
                {
                    return Ok(fac.AddInvoiceLogStored(item));
                }
            }
            catch
            {
                return StatusCode(HttpStatusCode.BadRequest);
            }
        }
    }


}
