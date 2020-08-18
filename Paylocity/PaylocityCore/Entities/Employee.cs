using System;
using System.Collections.Generic;
using System.Text;
using PaylocityCore.Interfaces;

namespace PaylocityCore.Entities
{
    public class Employee : IBeneficiary
    {
        public int Id { get; set; }

        public string Fname { get; set; }

        public string Lname { get; set; }

        public DateTime Dob { get; set; }
        
        public BenefitsModifier Modifier { get; set; }
    }
}
