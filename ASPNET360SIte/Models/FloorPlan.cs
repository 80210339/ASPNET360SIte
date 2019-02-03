﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET360SIte.Models
{
    public class FloorPlan
    {
        public int ID { get; set; }
        public string FloorPlanLabel { get; set; }

        [Display(Name = "FloorPlan Image")]
        public string MainImagePath { get; set; }

        [NotMappedAttribute]
        public IFormFile MainImage { get; set; }

        public ICollection<Room> Room { get; set; }
    }
}