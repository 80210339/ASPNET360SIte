using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET360SIte.Models
{
    public class Room
    {
        public int ID { get; set; }
        public string RoomLabel { get; set; }

        [Display(Name = "Room Image")]
        public string MainImagePath { get; set; }

        [NotMappedAttribute]
        public IFormFile MainImage { get; set; }

        public int CustomFloorPlanID { get; set; }

        //public ICollection<FloorPlan> FloorPlan { get; set; }

    }
}
