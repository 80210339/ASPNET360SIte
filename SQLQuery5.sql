
select * from Property
Select * from FloorPlan
select * from Room

Delete from Property
delete from FloorPlan
delete from Room
DBCC CHECKIDENT ('Property', RESEED, 0)
DBCC CHECKIDENT ('FloorPlan', RESEED, 0)
DBCC CHECKIDENT ('Room', RESEED, 0)


select * from Property
Select * from FloorPlan
select * from Room

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
