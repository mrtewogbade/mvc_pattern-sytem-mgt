using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace system_mgt.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}