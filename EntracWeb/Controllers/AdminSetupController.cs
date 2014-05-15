using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using EntracWeb.Models;


namespace EntracWeb.Controllers
{
    public class AdminSetupController : Controller
    {
        //
        // GET: /AdminSetup/
      
        public ActionResult AdminSetup()
        {

            return View();
        }

	}
}