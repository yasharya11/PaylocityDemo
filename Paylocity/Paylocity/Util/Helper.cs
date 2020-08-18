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
using PaylocityCore.Entities;
using PaylocityCore.BusinessRules;

namespace Paylocity.Util
{
    public static class Helper
    {
        public async static Task<List<Employee>> GetEmployees(PaylocityDbContext db)
        {
            return await db.Paylocity_Employees.ToListAsync();
        }

        public static void ExeEmployeeCalculations(ref EmployeePtPageModel employee)
        {
            employee.RawPayPrYr = (double)employee.Employee.PayPrChk * BR.NUM_CHKS_PRYR;

            employee.EmpBenefitsCostsPrYr = CalcEmployeeBenefitCostPrYr(employee.Employee.Fname, employee.Employee.Fname);

            employee.EmpBenefitsCostsPrChk = employee.EmpBenefitsCostsPrYr / BR.NUM_CHKS_PRYR;

            employee.DepBenefitsCostsPrYr = CalcDependantBenefitCostPrYr(employee.Dependants);

            employee.DepBenefitsCostsPrChk = employee.DepBenefitsCostsPrYr / BR.NUM_CHKS_PRYR;

            employee.EmpContributionCostPrYr = (employee.EmpBenefitsCostsPrYr + employee.DepBenefitsCostsPrYr) * (1 - BR.PERC_COMPANY_CONTRIBUTION);

            employee.EmpContributionCostPrChk = employee.EmpContributionCostPrYr / BR.NUM_CHKS_PRYR;

            employee.GrossPayPrYr = employee.RawPayPrYr - employee.EmpContributionCostPrYr;

            employee.GrossPayPrChk = employee.GrossPayPrYr / BR.NUM_CHKS_PRYR;
        }

        public static double CalcEmployeeBenefitCostPrYr(string fname, string lname)
        {
            double cost = 0;

            if(fname[0]=='A'|| fname[0] == 'a' 
                || lname[0] == 'A' || lname[0] == 'a')
            {
                cost = (BR.EMP_CST_OF_BENEFITS * BR.A_NAME_MULTIPLIER);
            }
            else
            {
                cost = (BR.EMP_CST_OF_BENEFITS);
            }

            return cost;
        }

        public static double CalcDependantBenefitCostPrYr(List<Dependant> dependants)
        {
            double cost = 0;
            //Now add the dependants
            foreach (Dependant dependant in dependants)
            {
                if (dependant.Fname[0] == 'A' || dependant.Fname[0] == 'a'
                    || dependant.Lname[0] == 'A' || dependant.Lname[0] == 'a')
                {
                    cost = cost + (BR.DEP_CST_OF_BENEFITS * BR.A_NAME_MULTIPLIER);
                }
                else
                {
                    cost = cost + (BR.DEP_CST_OF_BENEFITS);
                }
            }

            return cost;
        }

        //Clicker Project Reference Code

        //public async static Task<Click> AddClick(ContactDbContext db, string clickedBy)
        //{
        //    Click newClick = new Click(clickedBy);
        //    await db.Contact_Clicks.AddAsync(newClick);
        //    await db.SaveChangesAsync();
        //    return newClick;
        //}

        //public async static Task<Click> EditClick(ContactDbContext db, string clickedBy, int id)
        //{
        //    Click newClick = new Click(clickedBy);
        //    await db.Contact_Clicks.AddAsync(newClick);
        //    db.SaveChanges();
        //    return newClick;
        //}
    }
}
