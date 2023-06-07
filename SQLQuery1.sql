create database ProductsDB
use ProductsDB
create table Producttbl
(SN int primary key identity(1,1),Product varchar(50),Description varchar(50),Created Date )

insert into Producttbl values('Vivo','the Smartphone','12-06-2021')
insert into Producttbl values('Oppo',' the Camera phone','12-06-2021')
insert into Producttbl values('Iphone11','the Smart mobile phone','12-06-2021')

select * from Producttbl
