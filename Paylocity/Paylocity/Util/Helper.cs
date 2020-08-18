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

namespace Paylocity.Util
{
    public class Helper
    {
        public async static Task<List<Employee>> GetEmployees(PaylocityDbContext db)
        {
            return await db.Paylocity_Employees.ToListAsync();
        }

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
