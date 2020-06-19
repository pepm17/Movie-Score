using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace server.Models
{
    public class Movies
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string description { get; set; }

        [Required]
        public int Score { get; set; }

        public string Image { get; set; } = "Photo image";
    }
}
