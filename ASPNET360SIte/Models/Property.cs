using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET360SIte.Models
{
    using Microsoft.AspNetCore.Http;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Threading.Tasks;

    namespace IdentityCustomisationTest.Models
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

            [NotMappedAttribute]
            public IFormFile MainImage { get; set; }

            public ICollection<FloorPlan> FloorPlan { get; set; }

        }
    }

}
