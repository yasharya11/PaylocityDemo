using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaylocityCore.ResponseModels;

namespace Paylocity.Models.PageModels.Shared
{
    interface IPageModel
    {
        public StdRespModel Resp { get; set; }
    }
}
