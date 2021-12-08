using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoiveDataBase.Models
{
    public class Movies
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [MaxLength(30, ErrorMessage = "Error: Title Must be 10 characters long")]
        public string Title { get; set; }
        public string Genre { get; set; }
        [Required]
        [Range(1880, 2021, ErrorMessage = "Error: Year must be between 1880 and 2021")]
        public int Year { get; set; }
        public double Runtime { get; set; }
    }


}
