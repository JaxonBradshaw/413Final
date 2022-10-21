using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _413Final.Models
{
    public class Quote
    {
        [Key]
        public int QuoteId { get; set; }
        [Required]
        public string QuoteWords { get; set; } //Lol have to use QuoteWords instead of Quote because that's the class lul
        [Required]
        public string Author { get; set; } //just doing author instead of both author and speaker because I think author encompases both
        [Required]
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        public string Citation { get; set; }


    }
}
