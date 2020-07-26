using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Report
    {
        public int ID { get; set; }

        public string EnglishName { get; set; }

        public string ArabicName { get; set; }

        public ICollection<Parameter> Reports { get; set; }
    }
}
