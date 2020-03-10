using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Sem_3.Models
{
    public class Insurance
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeleteAt { get; set; }
        public virtual ICollection<InsurancePackage> InsurancePackages { get; set; }

    }
}