﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Movies.Client.Models
{
    public class Movie
    {
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public string Rating { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public string ImageUrl { get; set; }

    }
}
