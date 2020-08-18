using System;
using System.Collections.Generic;
using System.Text;

namespace PaylocityCore.ResponseModels
{
    public enum resultTypesEnum
    {
        Error,
        Redirect,
        Success
    }

    public class StdRespModel
    {
        public resultTypesEnum result { get; set; }
        public string rsltMsg { get; set; }
        public string rsltDesc { get; set; }
        public string redirect { get; set; }

    }
}
