using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Paylocity.Models;
using Paylocity.Models.Shared;
using Paylocity.Models.PageModels;
using Paylocity.Util;
using PaylocityCore.ResponseModels;

namespace Paylocity.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private PaylocityDbContext _db;

        public HomeController(ILogger<HomeController> logger, PaylocityDbContext db)
        {
            _db = db;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ViewEmployees()
        {
            EmployeesPtPageModel modelOut = new EmployeesPtPageModel();
            modelOut.Resp = new PaylocityCore.ResponseModels.StdRespModel();

            try
            {
                modelOut.Employees = await _db.Paylocity_Employees.ToListAsync();
                modelOut.Resp.result = PaylocityCore.ResponseModels.resultTypesEnum.Success;
            }
            catch(Exception ex)
            {
                StdRespModel ErrorOut = new StdRespModel();
                ErrorOut.rsltMsg = "There was an error getting the records";
                ErrorOut.rsltDesc = ex.Message;
                return Json(ErrorOut);
            }

            return View("ViewEmployeesPt", modelOut);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
