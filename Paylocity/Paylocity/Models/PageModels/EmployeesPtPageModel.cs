using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Paylocity.Models.PageModels.Shared;
using PaylocityCore.Entities;
using PaylocityCore.ResponseModels;

namespace Paylocity.Models.PageModels
{
    public class EmployeesPtPageModel : IPageModel
    {
        public StdRespModel Resp { get; set; }

        public IEnumerable<Employee> Employees { get; set; }

        public string htm { get; set; }

        public EmployeesPtPageModel()
        {
            Employees = new List<Employee>();
        }
    }
}
