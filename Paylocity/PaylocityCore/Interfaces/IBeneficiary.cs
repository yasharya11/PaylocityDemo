using System;
using System.Collections.Generic;
using System.Text;
using PaylocityCore.Entities;

namespace PaylocityCore.Interfaces
{
    interface IBeneficiary
    {
        public int Id { get; set; }

        public string Fname { get; set; }

        public string Lname { get; set; }

        public DateTime Dob { get; set; }

        public BenefitsModifier Modifier { get; set; }
    }
}
