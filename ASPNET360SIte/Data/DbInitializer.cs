using ASPNET360SIte.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET360SIte.Data
{
    public class DbInitializer
    {
        /*
        public static void Initialize(ASPNET360SIteContext context)
        {
            // context.Database.EnsureCreated();

            // Look for any students.
            if (context.Property.Any())
            {
                return;   // DB has been seeded
            }

            var properties = new Property[]
            {
            new Property{Build="11",Street="The Roperies",Locality="Hatters Lane",Town="High Wycombe",County="Buckinghamshire",PostCode="HP13 7FW",Country="Great Britain"},
            new Property{Build="5",Street="Radcliffe Road",Locality="Lupset",Town="Wakefield",County="West Yorkshire",PostCode="WF2 8RS",Country="Great Britain"},
            new Property{Build="80",Street="Cressex Road",Locality="Cressex",Town="High Wycombe",County="Buckinghamshire",PostCode="HP12 4TU",Country="Great Britain"},
            new Property{Build="15",Street="Denmark Street",Locality="Fenny Strafford",Town="Bletchley",County="Buckinghamshire",PostCode="MK2 2NH",Country="Great Britain"},
            new Property{Build="59",Street="Priory Avenue",Locality="Hughenden",Town="High Wycombe",County="Buckinghamshire",PostCode="HP13 6SN",Country="Great Britain"},
            new Property{Build="38",Street="Scott Road",Locality="Pitsmoor",Town="Sheffield",County="South Yorkshire",PostCode="S6 3Ax",Country="Great Britain"},
            new Property{Build="181",Street="West Wycombe Road ",Locality="Downley",Town="High Wycombe",County="Buckinghamshire",PostCode="HP13 8AN",Country="Great Britain"},
            new Property{Build="33",Street="Danvers Roads",Locality="Narboorugh",Town="Leicester",County="Liecestershire",PostCode="LE3 2AD",Country="Great Britain"},
            //new Property{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };
            foreach (Property s in properties)
            {
                context.Property.Add(s);
            }
            context.SaveChanges();

            var floorPlans = new FloorPlan[]
            {
            new FloorPlan{FloorPlanLabel="Ground Floor",MainImagePath="",=1},
            new FloorPlan{CourseID=4022,Title="Microeconomics",Credits=3},
            new FloorPlan{CourseID=4041,Title="Macroeconomics",Credits=3},
            new FloorPlan{CourseID=1045,Title="Calculus",Credits=4},
            new FloorPlan{CourseID=3141,Title="Trigonometry",Credits=4},
            new FloorPlan{CourseID=2021,Title="Composition",Credits=3},
            new FloorPlan{CourseID=2042,Title="Literature",Credits=4}
            };
            foreach (FloorPlan c in floorPlans)
            {
                context.FloorPlan.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollment.Add(e);
            }
            context.SaveChanges();
        }
        */
    }
}




