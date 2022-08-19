using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace berylliumv2.Models
{
    public class Work : BaseEntity
    {
        public string Path { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
}
