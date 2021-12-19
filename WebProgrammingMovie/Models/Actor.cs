﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgrammingMovie.Models
{
    public class Actor
    {
        public int Id { get; set; }

        [Display(Name = "Oyuncu Adı")]
        public string ActorName { get; set; }

        public int? MovieId { get; set; }
        [ForeignKey("MovieId")]
        public Movie Movie { get; set; }

    }
}
