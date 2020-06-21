using System;
using System.Collections.Generic;
using System.Text;

namespace MovieScore.Core.DTOs
{
    public class MovieDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Score { get; set; }
        public DateTime? Date { get; set; }
    }
}
