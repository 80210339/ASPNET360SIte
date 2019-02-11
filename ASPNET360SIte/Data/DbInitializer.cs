using ASPNET360SIte.Models; using ASPNET360SIte.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET360SIte.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
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
			/*
            new Property{Build="80",Street="Cressex Road",Locality="Cressex",Town="High Wycombe",County="Buckinghamshire",PostCode="HP12 4TU",Country="Great Britain"},
            new Property{Build="15",Street="Denmark Street",Locality="Fenny Strafford",Town="Bletchley",County="Buckinghamshire",PostCode="MK2 2NH",Country="Great Britain"},
            new Property{Build="59",Street="Priory Avenue",Locality="Hughenden",Town="High Wycombe",County="Buckinghamshire",PostCode="HP13 6SN",Country="Great Britain"},
            new Property{Build="38",Street="Scott Road",Locality="Pitsmoor",Town="Sheffield",County="South Yorkshire",PostCode="S6 3Ax",Country="Great Britain"},
            new Property{Build="181",Street="West Wycombe Road ",Locality="Downley",Town="High Wycombe",County="Buckinghamshire",PostCode="HP13 8AN",Country="Great Britain"},
            new Property{Build="33",Street="Danvers Roads",Locality="Narborough",Town="Leicester",County="Leicestershire",PostCode="LE3 2AD",Country="Great Britain"},
            //new Property{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
			*/
            };
            foreach (Property s in properties)
            {
                context.Property.Add(s);
            }
            context.SaveChanges();

            var floorPlans = new FloorPlan[]
             {
            new FloorPlan{FloorPlanLabel="Ground Floor",MainImagePath="",CustomPropertyID=1},
            new FloorPlan{FloorPlanLabel="First Floor",MainImagePath="",CustomPropertyID=1},
            new FloorPlan{FloorPlanLabel="Second Floor",MainImagePath="",CustomPropertyID=1},

            new FloorPlan{FloorPlanLabel="Ground Floor",MainImagePath="",CustomPropertyID=2},
            new FloorPlan{FloorPlanLabel="First Floor",MainImagePath="",CustomPropertyID=2},
                 /*
                 new FloorPlan{FloorPlanLabel="Ground Floor",MainImagePath="",CustomPropertyID=3},
                 new FloorPlan{FloorPlanLabel="First Floor",MainImagePath="",CustomPropertyID=3},
                 new FloorPlan{FloorPlanLabel="Ground Floor",MainImagePath="",CustomPropertyID=4},
                 new FloorPlan{FloorPlanLabel="First Floor",MainImagePath="",CustomPropertyID=4},
                 new FloorPlan{FloorPlanLabel="Ground Floor",MainImagePath="",CustomPropertyID=5},
                 new FloorPlan{FloorPlanLabel="Ground Floor",MainImagePath="",CustomPropertyID=6},
                 new FloorPlan{FloorPlanLabel="First Floor",MainImagePath="",CustomPropertyID=6},
                 new FloorPlan{FloorPlanLabel="First Floor Flat",MainImagePath="",CustomPropertyID=7},
                 new FloorPlan{FloorPlanLabel="Ground Floor",MainImagePath="",CustomPropertyID=7},
                 new FloorPlan{FloorPlanLabel="First Floor",MainImagePath="",CustomPropertyID=8},
                 */
             };
            foreach (FloorPlan c in floorPlans)
            {
                context.FloorPlan.Add(c);
            }
            context.SaveChanges();

            var rooms = new Room[]
            {
            new Room{RoomLabel="Hallway",MainImagePath="",CustomFloorPlanID=1},
            new Room{RoomLabel="Living Room",MainImagePath="",CustomFloorPlanID=1},
            new Room{RoomLabel="Dinning Room",MainImagePath="",CustomFloorPlanID=1},
            new Room{RoomLabel="Kitchen",MainImagePath="",CustomFloorPlanID=1},
            new Room{RoomLabel="Ground Floor Toilet",MainImagePath="",CustomFloorPlanID=1},
            new Room{RoomLabel="Garden",MainImagePath="",CustomFloorPlanID=1},
            new Room{RoomLabel="First Floor Master Bedroom (1) ",MainImagePath="",CustomFloorPlanID=2},
            new Room{RoomLabel="On Suite Bathroom",MainImagePath="",CustomFloorPlanID=2},
            new Room{RoomLabel="First Floor Bedroom (2)",MainImagePath="",CustomFloorPlanID=2},
            new Room{RoomLabel="First Floor Hallway",MainImagePath="",CustomFloorPlanID=2},
            new Room{RoomLabel="Second Floor Bedroom (1)",MainImagePath="",CustomFloorPlanID=3},
            new Room{RoomLabel="Second Floor Bedroom (2)",MainImagePath="",CustomFloorPlanID=3},
            new Room{RoomLabel="Second Floor Bathroom",MainImagePath="",CustomFloorPlanID=3},
            new Room{RoomLabel="Second Floor Hallway",MainImagePath="",CustomFloorPlanID=3},

            new Room{RoomLabel="Hallway",MainImagePath="",CustomFloorPlanID=4},
            new Room{RoomLabel="Living Room",MainImagePath="",CustomFloorPlanID=4},
            new Room{RoomLabel="Dinning Room",MainImagePath="",CustomFloorPlanID=4},
            new Room{RoomLabel="Kitchen",MainImagePath="",CustomFloorPlanID=4},
            new Room{RoomLabel="Ground Floor Toilet",MainImagePath="",CustomFloorPlanID=4},
            new Room{RoomLabel="Garden",MainImagePath="",CustomFloorPlanID=4},
            new Room{RoomLabel="First Floor Bedroom (1) ",MainImagePath="",CustomFloorPlanID=5},
            new Room{RoomLabel="First Floor Bedroom (2)",MainImagePath="",CustomFloorPlanID=5},
            new Room{RoomLabel="First Floor Hallway",MainImagePath="",CustomFloorPlanID=5},
            new Room{RoomLabel="First Floor Bathroom",MainImagePath="",CustomFloorPlanID=5},
            };
            foreach (Room e in rooms)
            {
                context.Room.Add(e);
            }
            context.SaveChanges();
        }
    }
}

/* INSERT statements for the above dataset, as Can't get the above to load!

Delete from Property
delete from FloorPlan
delete from Room
DBCC CHECKIDENT ('Property', RESEED, 0)
DBCC CHECKIDENT ('FloorPlan', RESEED, 0)
DBCC CHECKIDENT ('Room', RESEED, 0)

select * from Property

INSERT INTO Property (Build,Street,Locality,Town,County,PostCode,Country)
SELECT '11','The Roperies','Hatters Lane','High Wycombe','Buckinghamshire','HP13 7FW','Great Britain'

INSERT INTO Property (Build,Street,Locality,Town,County,PostCode,Country)
SELECT '5','Radcliffe Road','"Lupset"','Wakefield','West Yorkshire','WF2 8RS','Great Britain'

delete from FloorPlan
delete from Room
DBCC CHECKIDENT ('FloorPlan', RESEED, 0)
DBCC CHECKIDENT ('Room', RESEED, 0)

INSERT INTO FloorPlan (FloorPlanLabel,MainImagePath,CustomPropertyID)
SELECT 'Ground Floor','',1
INSERT INTO FloorPlan (FloorPlanLabel,MainImagePath,CustomPropertyID)
SELECT 'First Floor','',1
INSERT INTO FloorPlan (FloorPlanLabel,MainImagePath,CustomPropertyID)
SELECT 'Second Floor','',1


INSERT INTO FloorPlan (FloorPlanLabel,MainImagePath,CustomPropertyID)
SELECT 'Ground Floor','',2
INSERT INTO FloorPlan (FloorPlanLabel,MainImagePath,CustomPropertyID)
SELECT 'First Floor','',2

SELECT * from FloorPlan

delete from Room
DBCC CHECKIDENT ('Room', RESEED, 0)

INSERT INTO Room (RoomLabel,MainImagePath,CustomFloorPlanID)
SELECT 'Hallway','',1
INSERT INTO Room (RoomLabel,MainImagePath,CustomFloorPlanID)
SELECT 'Living Room','',1
INSERT INTO Room (RoomLabel,MainImagePath,CustomFloorPlanID)
SELECT 'Dinning Room','',1
INSERT INTO Room (RoomLabel,MainImagePath,CustomFloorPlanID)
SELECT 'Kitchen','',1
INSERT INTO Room (RoomLabel,MainImagePath,CustomFloorPlanID)
SELECT 'Ground Floor Toilet','',1
INSERT INTO Room (RoomLabel,MainImagePath,CustomFloorPlanID)
SELECT 'Garden','',1
INSERT INTO Room (RoomLabel,MainImagePath,CustomFloorPlanID)
SELECT 'First Floor Master Bedroom (1)','',2
INSERT INTO Room (RoomLabel,MainImagePath,CustomFloorPlanID)
SELECT 'On Suite Bathroom','',2
INSERT INTO Room (RoomLabel,MainImagePath,CustomFloorPlanID)
SELECT 'First Floor Bedroom (2)','',2
INSERT INTO Room (RoomLabel,MainImagePath,CustomFloorPlanID)
SELECT 'First Floor Hallway','',2
INSERT INTO Room (RoomLabel,MainImagePath,CustomFloorPlanID)
SELECT 'Second Floor Bedroom (1)','',3
INSERT INTO Room (RoomLabel,MainImagePath,CustomFloorPlanID)
SELECT 'Second Floor Bedroom (2)','',3
INSERT INTO Room (RoomLabel,MainImagePath,CustomFloorPlanID)
SELECT 'Second Floor Bathroom','',3
INSERT INTO Room (RoomLabel,MainImagePath,CustomFloorPlanID)
SELECT 'Second Floor Hallway','',3


INSERT INTO Room (RoomLabel,MainImagePath,CustomFloorPlanID)
SELECT 'Hallway','',4
INSERT INTO Room (RoomLabel,MainImagePath,CustomFloorPlanID)
SELECT 'Living Room','',4
INSERT INTO Room (RoomLabel,MainImagePath,CustomFloorPlanID)
SELECT 'Dinning Room','',4
INSERT INTO Room (RoomLabel,MainImagePath,CustomFloorPlanID)
SELECT 'Kitchen','',4
INSERT INTO Room (RoomLabel,MainImagePath,CustomFloorPlanID)
SELECT 'Ground Floor Toilet','',4
INSERT INTO Room (RoomLabel,MainImagePath,CustomFloorPlanID)
SELECT 'Garden','',4
INSERT INTO Room (RoomLabel,MainImagePath,CustomFloorPlanID)
SELECT 'First Floor Master Bedroom (1)','',5
INSERT INTO Room (RoomLabel,MainImagePath,CustomFloorPlanID)
SELECT 'On Suite Bathroom','',5
INSERT INTO Room (RoomLabel,MainImagePath,CustomFloorPlanID)
SELECT 'First Floor Bedroom (2)','',5
INSERT INTO Room (RoomLabel,MainImagePath,CustomFloorPlanID)
SELECT 'First Floor Hallway','',5

select * from Property
Select * from FloorPlan
select * from Room

 */



