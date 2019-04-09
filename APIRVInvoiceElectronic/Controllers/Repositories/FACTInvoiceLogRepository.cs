using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APIRVInvoiceElectronic.Models;

namespace APIRVInvoiceElectronic.Controllers.Repositories
{
    public class FACTInvoiceLogRepository
    {
        RVInvoice rv = new RVInvoice();
        public FACTInvoiceLogRepository() { }
        public IEnumerable<InvoiceLogStored> GetAll()
        {
            List<InvoiceLogStored> arr = new List<InvoiceLogStored>();
            arr = rv.InvoiceLogStoreds.ToList();
            return arr;

        }

        public InvoiceLogStored AddInvoiceLogStored(InvoiceLogStored item)
        {
            string exception = String.Empty;

            try
            {
                var documentos = new InvoiceLogStored
                {
                    opcion = item.opcion,
                    prefix = item.prefix,
                    number = item.number,
                    response = item.response,
                    respuesta = item.respuesta
                };

                rv.InvoiceLogStoreds.Add(documentos);
                rv.SaveChanges();
                return documentos;

            }
            catch (Exception ex)
            {
                exception = "Exception Message: " + ex.Message + ". InnerException: " + ex.InnerException.Message;
            }
            return item;
        }


    }
}