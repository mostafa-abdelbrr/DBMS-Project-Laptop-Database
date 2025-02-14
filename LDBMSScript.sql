create database Laptops
go

use Laptops

create Table Laptop
(
	Model varchar(100),
	Name varchar(50) UNIQUE,
	Release_Date date,
	Approved bit,
	Promoted varchar(50),
	--Usb_Ports_Num int,
	--Processer_Mnum varchar(50),
	--GPU_Mnum varchar(50),
	primary key(Model),
)

create Table Processor
(
	Brand varchar(50),
	ModelNum varchar(50),
	primary key(Brand,ModelNum),
)

create Table Graphics_Card
(	
	Model_Number varchar(50) NOT NULL ,
	Manufacturer varchar(50) NOT NULL,
	Vram float NOT NULL,
	Clock_Speed float NOT NULL,
	primary key(Model_number),
)


create table Manufacturer_Data
(
	Name varchar(50),
	Official_service_centre_address varchar(100),
	primary key(Name),
	
)

create table Manufacturered_By
(
	Name varchar(50),
	
	Laptop_Model varchar(100),
	Manufacturing_Date date,
	primary key(Name,Laptop_Model),
	foreign key (Laptop_Model) references Laptop, 
	foreign key (Name) references Manufacturer_Data, 
)


create table Store
(
	Name varchar(50) NOT NULL,
	Phone bigint UNIQUE NOT NULL,
	Address varchar(100) NOT NULL,
	primary key (Name),
	constraint AK_Phone Unique (Phone),
)

create table Operating_System
(
	Name varchar(50) NOT NULL ,
	Manufacturer varchar(50) NOT NULL  ,
	Version varchar(50) NOT NULL ,
	primary key(Manufacturer,Name,Version),
)
create table Roles
(
	RoleID int,
	Role varchar(50)
	primary key (Role)
	
)
create table S_User
(
	ID int,
	Email nvarchar(100) NOT NULL UNIQUE ,
	UserName nvarchar(50) NOT NULL UNIQUE ,
	Role Varchar(50) NOT NULL ,
	DataShareConsent bit NOT NULL,
	Password varchar(50) NOT NULL,
	primary key(ID),
	constraint AK_UN Unique (UserName),
	constraint AK_Email Unique (Email),
	Foreign key (Role) references Roles 
)



create Table KeyBoard
(
	Type varchar(50),
	Light varchar(50),
	Laptop_Model varchar(100),
	primary key(Type,Light,Laptop_Model),
	Foreign key (Laptop_Model) references Laptop On Delete Cascade On Update Cascade,
)

create Table Screen
(
	Type varchar(50),
	Resolution varchar(50),
	Size float,
	Laptop_Model varchar(100),
	primary key(Type,Resolution,Size,Laptop_Model),
	foreign key (Laptop_Model) references Laptop ON DELETE CASCADE,
)

create table Storage
(
	
	HDD_Manufacturer varchar(50),
	SSD_Manufacturer varchar (50),
	HDD_Size int,
	SDD_Size int,
	Laptop_Model varchar(100),
	primary key(HDD_Manufacturer,SSD_Manufacturer,HDD_Size,SDD_Size,Laptop_Model),
	foreign key (Laptop_Model) references Laptop ON DELETE CASCADE,
)

create table RAM
(
	Size varchar(50),
	DDR varchar(50),
	Laptop_Model varchar(100),
	primary key(Size,DDR,Laptop_Model),
	foreign key(Laptop_Model) references Laptop ON DELETE CASCADE ,
)

create table Rating
(
	Laptop_Model varchar(100),
	User_ID int,
	Rating float,
	primary key(Laptop_Model,User_ID),
	foreign key (Laptop_Model) references Laptop,
	foreign key (User_ID) references S_User,
)

create table Owner
(
	User_ID int,
	Store_Name varchar(50),
	primary key (User_ID,Store_Name),
	foreign key (User_ID) references S_User ON DELETE CASCADE,
	foreign key (Store_Name) references Store ON DELETE CASCADE
)

create Table Bought_From
(
	Laptop_Model varchar(100),
	Store_Name varchar(50),
	Price float NOT NULL,
	InStock int NOT NULL,
	primary key(Laptop_Model,Store_Name),
	foreign key (Laptop_Model) references Laptop on delete cascade on update cascade,
	foreign key (Store_Name) references Store,
)

create Table USB_Type
(
	Laptop_Model varchar(100),
	USB2_Number int,
	USB3_Number int,


	primary key (Laptop_Model,USB2_Number,USB3_Number),
	foreign key (Laptop_Model) references Laptop ON DELETE CASCADE,
	constraint AK_LMU Unique (Laptop_Model),
)

create table M_Contact_Info
(
	M_Name varchar(50),
	Phone int,
	primary key(M_Name,Phone),
	foreign key (M_Name) references Manufacturer_Data(Name),
)

create table K_Languages
(
	Laptop_Model varchar(100),
	K_Type varchar(50),
	K_Light varchar(50),
	Language varchar(50),
	primary key (Laptop_Model,K_Type,K_Light,Language),
	foreign key (K_Type,K_Light,Laptop_Model) references Keyboard ON DELETE CASCADE on update cascade
)

create Table Search_log
(
	UserID int not null,
	Laptop_Model varchar(100) not null,
	search_Date varchar(50) not null,
	primary key(UserID,Laptop_Model,search_Date),
	foreign key(UserID) references S_User,
	foreign Key(Laptop_Model) references Laptop on delete cascade on update cascade,

)

create Table Composed_Of
(
	Laptop_Model varchar(100),
	K_Type varchar(50),
	K_Light varchar(50),
	P_Brand varchar(50),
	P_ModelNum varchar(50),
	R_Size varchar(50),
	R_DDR varchar(50),
	GPU_Model_Number varchar(50),
	OS_Manufacturer varchar(50),
	OS_Name varchar(50),
	OS_Ver varchar (50),
	HDD_Manufacturer varchar(50),
	HDD_Size int,
	SSD_Size int,
	SSD_Manufacturer varchar(50),
	USB2 int,
	USB3 int,
	SC_Type varchar(50),
	SC_Resolution varchar(50),
	SC_Size float,

	primary key(Laptop_Model,K_Type,K_Light,P_Brand,P_ModelNum,R_Size,R_DDR,GPU_Model_Number,OS_Name,SSD_Manufacturer,HDD_Manufacturer,SC_Type,SC_Resolution,SC_Size,USB2,USB3),
	foreign key (Laptop_model) references Laptop ,
	foreign key (K_Type,K_Light,Laptop_model) references KeyBoard on update cascade,
	foreign key (P_Brand,P_ModelNum) references Processor on update cascade,
	foreign key (R_Size,R_DDR,Laptop_Model) references RAM on update cascade,
	foreign key (GPU_Model_Number) references Graphics_Card on update cascade,
	foreign key (OS_Manufacturer,OS_Name,OS_Ver) references Operating_System (Manufacturer,Name,Version) on update cascade,
	foreign key (HDD_Manufacturer,SSD_Manufacturer,HDD_Size,SSD_Size,Laptop_Model) references Storage(HDD_Manufacturer,SSD_Manufacturer,HDD_Size,SDD_Size,Laptop_Model) on update cascade,
	foreign key (SC_Type,SC_Resolution,SC_Size,Laptop_Model) references Screen on update cascade,
	foreign key (Laptop_Model,USB2,USB3) references USB_Type(Laptop_Model,USB2_Number,USB3_Number) on update cascade,

	
)
go
create procedure Edit @LM varchar(100),@KT varchar(50),@KL varchar(50),@PB varchar(50),@PMN varchar(50),@RS varchar(50),@RDDR varchar(50),@GPUMN varchar(50),@GPUMAN varchar(50),@VRAM float,@CS float,@OSN varchar(50),@OSMAN varchar(50),@OSV varchar(50),@HDDMAN varchar(50),@SSDMAN varchar(50),@HDDSIZE int,@SSDSIZE int,@SCT varchar(50),@SCR varchar(50),@SCS float,@U2 int,@u3 int
AS
update KeyBoard set Type=@KT ,Light=@KL where Laptop_Model=@Lm
--update Processor set Brand=@PB , ModelNum=@PMN
update RAM set Size=@RS , DDR=@RDDR where Laptop_Model=@LM
Update Graphics_Card set Manufacturer=@GPUMAN , Vram=@VRAM , Clock_Speed=@CS where Model_Number=@GPUMN
--update os
update Storage set HDD_Manufacturer=@HDDMAN , SSD_Manufacturer=@SSDMAN ,HDD_Size=@HDDSIZE,SDD_Size=@SSDSIZE where Laptop_Model=@LM
update USB_Type set USB2_Number=@U2, USB3_Number=@u3 where Laptop_Model=@LM
update Screen set Type=@SCT , Resolution=@SCR , Size=@SCS where Laptop_Model=@LM
GO
create procedure RemoveLaptop @LM varchar(100)
AS
Delete from Composed_Of where Laptop_Model=@LM
Delete from Laptop where Model=@LM
Delete from Bought_From where Laptop_Model=@LM
GO

create procedure getnewID @newID int OUTPUT 
AS
Select @newID = Max(ID) + 1  From S_User 
return @newID
GO



CREATE PROCEDURE fillComposedOf @lapModel varchar(50), @procbrand varchar(50),@pnum varchar(50),@gpu varchar(50),@osmanu varchar(50),@osname varchar(50),@osver varchar(50)
AS
Begin
declare @ktype varchar (50)
declare @klight varchar(50)

declare @rsize varchar(50)
declare @ddr varchar(50)


declare @hddmanu varchar(50)
declare @hddsize int
declare @ssdsize int
declare @ssdmanu varchar(50)

declare @usb2 int
declare @usb3 int

declare @screentype varchar(50)
declare @screenres varchar(50)
declare @screensize float

SELECT @ktype = Type From KeyBoard Where Laptop_Model = @lapModel

select @klight = Light From KeyBoard Where Laptop_Model = @lapModel
select @rsize = Size From RAM where Laptop_Model = @lapModel
select @ddr = DDR From RAM where Laptop_Model = @lapModel
select @hddmanu = HDD_Manufacturer FROM Storage where Laptop_Model = @lapModel
select @hddsize = HDD_Size FROM Storage where Laptop_Model = @lapModel
select @ssdsize = SDD_Size FROM Storage where Laptop_Model = @lapModel
select @ssdmanu = SSD_Manufacturer FROM Storage where Laptop_Model = @lapModel
select @usb2 = USB2_Number From USB_Type WHere Laptop_Model = @lapModel
select @usb3 = USB3_Number From USB_Type WHere Laptop_Model = @lapModel

select @screentype = Type From Screen Where Laptop_Model = @lapModel
select @screenres = Resolution From Screen Where Laptop_Model = @lapModel
select @screensize = Size From Screen Where Laptop_Model = @lapModel

INSERT INTO Composed_Of VALUES (@lapModel,@ktype,@klight,@procbrand,@pnum,@rsize,@ddr,@gpu,@osmanu,@osname,@osver,@hddmanu,@hddsize,@ssdsize,@ssdmanu,@usb2,@usb3,@screentype,@screenres,@screensize)

END
GO

create procedure getpromotedlaptops
AS
Select * from Laptop l,Composed_Of c where l.Promoted = 'Promoted'
GO




INSERT INTO Roles Values (1,'Admin')
INSERT INTO Roles Values (2,'Store')
INSERT INTO Roles Values (3,'User')
INSERT INTO Roles Values (0,'Store_WAITING_APPROVAL')

INSERT INTO S_User VALUES (0,'-','1','Admin',0,'1')

INSERT INTO Manufacturer_Data Values ('ASUS','RAYA: 1 Abdel Hamid Loutfy St, Makram Ebeid, Nasr city, Cairo, Egypt')
INSERT INTO Manufacturer_Data Values ('Acer','Mantrac: 30 Lebonan St,1st Floor, Mohandseen, Giza')
INSERT INTO Manufacturer_Data Values ('Lenovo','MAS Egypt: 26 Jeddah St., off Mohi Eldin Abou Elezz,Dokki, Giza')
INSERT INTO Manufacturer_Data Values ('Samsung','Samsung Service Center: 15 Wadi Al Nile, Gazirat Mit Oqbah, Agouza, Giza Governorate')
INSERT INTO Manufacturer_Data Values ('DELL','Al Masreya: Abdo Morad Al Mohamei, Al Huwaiteyah, Agouza, Giza Governorate 12654')
INSERT INTO Manufacturer_Data Values ('Apple','3 Ibn El Nabih Street zamalek Cairo، 11211')
INSERT INTO Manufacturer_Data Values ('Huawei','14 Mossadak, Ad Doqi, Dokki, Giza Governorate')
INSERT INTO Manufacturer_Data Values ('Razer','--')
INSERT INTO Manufacturer_Data Values ('Toshiba','Al Araby Service Center:Bahtim, Shubra El Kheima 2, Al Qalyubia Governorate')
INSERT INTO Manufacturer_Data Values ('Microsoft','--')
INSERT INTO Manufacturer_Data Values ('Sony','Al Araby Service Center:Bahtim, Shubra El Kheima 2, Al Qalyubia Governorate')
INSERT INTO Manufacturer_Data Values ('Sharp','Al Araby Service Center:Bahtim, Shubra El Kheima 2, Al Qalyubia Governorate')
INSERT INTO Manufacturer_Data Values ('LG','Talaat Harb St., Downtown Cairo 11566')










INSERT INTO Processor VALUES('Intel', 'Core i3')
INSERT INTO Processor VALUES('Intel', 'Core i5')
INSERT INTO Processor VALUES('Intel', 'Core i7')
INSERT INTO Processor VALUES('Intel', 'Core i9')
INSERT INTO Processor VALUES('Intel', 'Core i3 i3-9350KF')
INSERT INTO Processor VALUES('Intel', 'Core i3 i3-9300T')
INSERT INTO Processor VALUES('Intel', 'Core i3 i3-9350K')
INSERT INTO Processor VALUES('Intel', 'Core i3 i3-9320')
INSERT INTO Processor VALUES('Intel', 'Core i5-9600T')
INSERT INTO Processor VALUES('Intel', 'Core i5-9600K')
INSERT INTO Processor VALUES('Intel', 'Core i5-9600KF')
INSERT INTO Processor VALUES('Intel', 'Core i5-9600')
INSERT INTO Processor VALUES('Intel', 'Core i7-9850HL')
INSERT INTO Processor VALUES('Intel', 'Core i7-9750HF')
INSERT INTO Processor VALUES('Intel', 'Core i7-9700K')
INSERT INTO Processor VALUES('Intel', 'Core i7-9700')

INSERT INTO Processor VALUES('AMD', 'Ryzen 3')
INSERT INTO Processor VALUES('AMD', 'Ryzen 5')
INSERT INTO Processor VALUES('AMD', 'Ryzen 7')
INSERT INTO Processor VALUES('AMD', 'Ryzen 9')


INSERT INTO Graphics_Card VALUES ('GTX 960 2GB','Nvidia',2,1253)
INSERT INTO Graphics_Card VALUES ('GTX 970 4GB','Nvidia',4,1178)
INSERT INTO Graphics_Card VALUES ('GTX 1060 6GB','Nvidia',6,1708)
INSERT INTO Graphics_Card VALUES ('GTX 1060 3GB','Nvidia',3,1708)
INSERT INTO Graphics_Card VALUES ('GTX 960 2GB','Nvidia',2,1253)
INSERT INTO Graphics_Card VALUES ('GTX 1080 8GB','Nvidia',8,1733)
INSERT INTO Graphics_Card VALUES ('GTX 980 4GB','Nvidia',4,1216)
INSERT INTO Graphics_Card VALUES ('GTX 3070 8GB','Nvidia',8,1730)
INSERT INTO Graphics_Card VALUES ('MX450','Nvidia',4,1518)
INSERT INTO Graphics_Card VALUES ('GTX 1070 TI 8GB','Nvidia',8,1683)

INSERT INTO Graphics_Card VALUES ('Radeon RX 6800','AMD',4,1700)
INSERT INTO Graphics_Card VALUES ('Radeon RX 5700','AMD',4,1725)
INSERT INTO Graphics_Card VALUES ('Radeon RX 5600 XT ','AMD',4,1130)
INSERT INTO Graphics_Card VALUES ('Radeon RX 6800 XT','AMD',4,2250)
INSERT INTO Graphics_Card VALUES ('Radeon RX 560','AMD',4,1292)


INSERT INTO Operating_System VALUES	('DOS','Microsoft','-')
INSERT INTO Operating_System VALUES	('No OS','N/A','-')

INSERT INTO Operating_System VALUES	('Windows','Microsoft','7')
INSERT INTO Operating_System VALUES	('Windows','Microsoft','8')
INSERT INTO Operating_System VALUES	('Windows','Microsoft','8.1')
INSERT INTO Operating_System VALUES	('Windows','Microsoft','10')

INSERT INTO Operating_System VALUES	('Mac OSX','Apple','Sierra')
INSERT INTO Operating_System VALUES	('Mac OSX','Apple','High Sierra')
INSERT INTO Operating_System VALUES	('Mac OSX','Apple','Mojave')
INSERT INTO Operating_System VALUES	('Mac OSX','Apple','Catalina')
INSERT INTO Operating_System VALUES	('Mac OSX','Apple','Big Sur')

INSERT INTO Operating_System VALUES	('Ubuntu','Canonical','14')
INSERT INTO Operating_System VALUES	('Ubuntu','Canonical','15')
INSERT INTO Operating_System VALUES	('Ubuntu','Canonical','16')

