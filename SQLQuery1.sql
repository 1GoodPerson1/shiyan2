
use master
create database test
go

use test
go

create table login
(
	name varchar(4) primary key,
	pwd varchar(10) 
)

insert into  login values('����','123456');
insert into  login values('����','123456');

select * from login where name='����'and pwd='123456'
