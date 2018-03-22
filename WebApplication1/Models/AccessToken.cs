using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class AccessToken
    {
        public int Id { get; set; }
        [Required]
        public string Val { get; set; }
        [Required]
        public DateTime CreateTime { get; set; }
    }
}