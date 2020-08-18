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
    public class EmployeePtPageModel : IPageModel
    {
        public StdRespModel Resp { get; set; }

        public Employee Employee { get; set; }

        public List<Dependant> Dependants { get; set; }

        //went down a road to customize modifiers but fell flat
        public BenefitsModifier Modifier { get; set; }

        public double RawPayPrYr { get; set; }

        public double EmpBenefitsCostsPrChk { get; set; }

        public double EmpBenefitsCostsPrYr { get; set; }

        public double DepBenefitsCostsPrChk { get; set; }

        public double DepBenefitsCostsPrYr { get; set; }

        public double EmpContributionCostPrChk { get; set; }

        public double EmpContributionCostPrYr { get; set; }

        public double GrossPayPrChk { get; set; }

        public double GrossPayPrYr { get; set; }

        public EmployeePtPageModel()
        {

        }
    }
}
