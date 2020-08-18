using System;
using System.Collections.Generic;
using System.Text;

namespace PaylocityCore.Entities
{
    public class BenefitsModifier
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Multiplier { get; set; }
    }
}
