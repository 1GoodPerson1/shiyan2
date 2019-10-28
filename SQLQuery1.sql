
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

insert into  login values('张三','123456');
insert into  login values('李四','123456');

select * from login where name='张三'and pwd='123456'
