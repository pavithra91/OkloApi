using OkloApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OkloApi.Controllers
{
    public class ServiceController : ApiController
    {
        [HttpPost]
        public dynamic RejectRequest(Invoice obj)
        {
            return Json(new { Succeeded = "true" });
        }

        [HttpPost]
        public dynamic OkloDocumentApi(Invoice obj)
        {
            return Json(new { Succeeded = "true" });
        }
    }
}
