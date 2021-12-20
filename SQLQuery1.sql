create database Drzava
use Drzava
create table drzava(
    id int identity(0,1),
    naziv nvarchar(30),
    kontinent nvarchar(30),
    glavniGrad nvarchar(30),
    povrsina int,
    brStan int
)

insert into drzava
values('Srbija','Evropa','Beograd',88361,7000000),
('Irska','Evropa','Dablin',70273,5000000),
('Novi Zeland','Australija i Okeanija','Velington',268021,5000000)
