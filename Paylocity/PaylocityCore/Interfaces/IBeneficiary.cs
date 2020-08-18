using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using PaylocityCore.Entities;

namespace PaylocityCore.Interfaces
{
    interface IBeneficiary
    {
        public string Fname { get; set; }

        public string Lname { get; set; }

        public DateTime Dob { get; set; }

        public BenefitsModifier Modifier { get; set; }
    }
}
