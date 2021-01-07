create database Laptops
go

use Laptops

create Table Laptop
(
	Model varchar(100),
	Name varchar(50) UNIQUE,
	Release_Date date,
	Approved bit,
	Promoted bit,
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
	Name varchar(50),
	Manufacturer varchar(50),
	Version varchar(50),
	primary key(Name),
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
	Size varchar(50),
	Manufacturer varchar(50),
	HDD varchar(50),
	SDD varchar(50),
	Laptop_Model varchar(100),
	primary key(Size,Manufacturer,Laptop_Model),
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
	foreign key (Laptop_Model) references Laptop,
	foreign key (Store_Name) references Store,
)

create Table USB_Type
(
	Laptop_Model varchar(100),
	Type varchar(50),
	number int,

	primary key (Laptop_Model,Type),
	foreign key (Laptop_Model) references Laptop ON DELETE CASCADE
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
	foreign key (K_Type,K_Light,Laptop_Model) references Keyboard ON DELETE CASCADE
)

create Table Search_log
(
	UserID int not null,
	Laptop_Model varchar(100) not null,
	search_Date date not null,
	primary key(UserID,Laptop_Model),
	foreign key(UserID) references S_User,
	foreign Key(Laptop_Model) references Laptop,

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
	OS_Name varchar(50),
	S_Size varchar(50),
	S_Manufacturer varchar(50),
	SC_Type varchar(50),
	SC_Resolution varchar(50),
	SC_Size float,

	primary key(Laptop_Model,K_Type,K_Light,P_Brand,P_ModelNum,R_Size,R_DDR,GPU_Model_Number,OS_Name,S_Size,S_Manufacturer,SC_Type,SC_Resolution,SC_Size),
	foreign key (Laptop_model) references Laptop ,
	foreign key (K_Type,K_Light,Laptop_model) references KeyBoard ,
	foreign key (P_Brand,P_ModelNum) references Processor ,
	foreign key (R_Size,R_DDR,Laptop_Model) references RAM ,
	foreign key (GPU_Model_Number) references Graphics_Card ,
	foreign key (OS_Name) references Operating_System ,
	foreign key (S_Size,S_Manufacturer,Laptop_Model) references Storage ,
	foreign key (SC_Type,SC_Resolution,SC_Size,Laptop_Model) references Screen ,

	
)


INSERT INTO Roles Values (1,'Admin')
INSERT INTO Roles Values (2,'Store')
INSERT INTO Roles Values (3,'User')
INSERT INTO Roles Values (0,'Store_WAITING_APPROVAL')

INSERT INTO Manufacturer_Data Values ('ASUS','RAYA: 1 Abdel Hamid Loutfy St, Makram Ebeid, Nasr city, Cairo, Egypt')
INSERT INTO Manufacturer_Data Values ('Acer','Mantrac: 30 Lebonan St,1st Floor, Mohandseen, Giza')
INSERT INTO Manufacturer_Data Values ('Lenovo','MAS Egypt: 26 Jeddah St., off Mohi Eldin Abou Elezz,Dokki, Giza')
INSERT INTO Manufacturer_Data Values ('Samsung','Samsung Service Center: 15 Wadi Al Nile, Gazirat Mit Oqbah, Agouza, Giza Governorate')

INSERT INTO Processor VALUES('Intel', 'Core i3')
INSERT INTO Processor VALUES('Intel', 'Core i5')
INSERT INTO Processor VALUES('Intel', 'Core i7')


INSERT INTO Graphics_Card VALUES ('GTX 960 2GB','Nvidia',2,1253)
INSERT INTO Graphics_Card VALUES ('GTX 3070 8GB','Nvidia',8,1730)
INSERT INTO Graphics_Card VALUES ('GTX 1070 TI 8GB','Nvidia',8,1683)