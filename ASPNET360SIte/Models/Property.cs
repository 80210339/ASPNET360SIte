using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET360SIte.Models
{
        public class Property
        {
            public int ID { get; set; }
            public string Build { get; set; }
            public string Street { get; set; }
            public string Locality { get; set; }
            public string Town { get; set; }
            public string County { get; set; }
            public string Country { get; set; }

            [MaxLength(10)]
            public string PostCode { get; set; }

            [Display(Name = "Property Image")]
            public string MainImagePath { get; set; }

            public string CustomAgentID { get; set; }

            [NotMappedAttribute]
            public IFormFile MainImage { get; set; }

        // public int FloorPlanID { get; set; }
        //public FloorPlan FloorPlan { get; set; }      --included as required for the foreach code in Properties/detail page


    }

}
