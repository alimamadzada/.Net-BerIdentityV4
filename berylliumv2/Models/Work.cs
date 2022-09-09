using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace berylliumv2.Models
{
    public class Work : BaseEntity
    {
        public string Path { get; set; }
        [Required]
        public string Name { get; set; }
        [NotMapped]
        public IFormFile Img{ get; set; }
        [Required]
        public string City { get; set; }
    }
}
