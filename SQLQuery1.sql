create database funeralHome
create table tblDecedent(ID int identity,Family varchar(50), First varchar(50), Middle varchar(50),Birthdate varchar(50),Deathdate varchar(50),Room varchar(50),Service varchar(50))

create table tblService(ID int identity,Service varchar(50))
insert into tblService(Service) VALUES('Arrange Location')
insert into tblService(Service) VALUES('Burial')
insert into tblService(Service) VALUES('Catering')
insert into tblService(Service) VALUES('Cremation')
insert into tblService(Service) VALUES('Donation')
insert into tblService(Service) VALUES('Facility Use')
insert into tblService(Service) VALUES('Mass')
insert into tblService(Service) VALUES('Merchandise')
insert into tblService(Service) VALUES('Memorial Tribute')
insert into tblService(Service) VALUES('Obituary')
insert into tblService(Service) VALUES('Transfer')
insert into tblService(Service) VALUES('Vehicular Transport')

create table tblRoom(ID int identity,Room varchar(50))
insert into tblRoom(Room) VALUES('F-1')
insert into tblRoom(Room) VALUES('F-2')
insert into tblRoom(Room) VALUES('F-3')
insert into tblRoom(Room) VALUES('F-4')
insert into tblRoom(Room) VALUES('F-5')
insert into tblRoom(Room) VALUES('S-1')
insert into tblRoom(Room) VALUES('S-2')
insert into tblRoom(Room) VALUES('S-3')
insert into tblRoom(Room) VALUES('S-4')
insert into tblRoom(Room) VALUES('S-5')

select * from tblDecedent
select * from tblService
select * from tblRoom