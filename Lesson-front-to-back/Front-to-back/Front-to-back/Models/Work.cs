using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front_to_back.Models
{
    public class Work : BaseEntity
    {
        public string Image { get; set; }
        public string Header { get; set; }

        public string Description { get; set; }
    }
}
