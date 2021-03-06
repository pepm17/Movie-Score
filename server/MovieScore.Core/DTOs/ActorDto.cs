﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MovieScore.Core.DTOs
{
    public class ActorDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int Score { get; set; }
    }
}
