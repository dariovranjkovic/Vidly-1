﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_1.Models;

namespace Vidly_1.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customer { get; set; }
    }
}