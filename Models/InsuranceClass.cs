using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceApp.Models
{
    public class InsuranceClass
    {
        public int InsuranceId { get; set; }
        public string InsuranceName { get; set; }
        public string InsuranceCategory { get; set; }
        public string InsuranceCompany { get; set; }
        public string DateOfJoining { get; set; }
        public string DateOfEnd { get; set; }
        public string PhotoFileName { get; set; }
    }
}
