using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EquipmentSells.Controllers
{
    public class EqipmentsController : Controller
    {
        // GET: Eqipments
        public ActionResult Index()
        {
            return View();
        }
    }
}