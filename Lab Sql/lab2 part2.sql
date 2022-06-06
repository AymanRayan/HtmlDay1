/*------part2---------*/
create database task2
use task2
create table instructor(
   id int primary key identity(100,1),
   lname varchar(225),
   fName varchar(255),
   Addr varchar(255),
   Bd date,
   salary int default 3000,
   hireDate date default getdate(),
   Otime int,
   netSalary as (salary + Otime) persisted,
   age as (year(getdate()) - year(Bd)),
     constraint c7 check(Addr in ('alex','cairo')),
	 constraint c8 check (salary between 1000 and 5000),
	 constraint c9 unique (Otime)

)
create table course(
   Cid int primary key identity,
   Cname varchar(225),
   duration int
)
alter table course 
   add constraint c10 unique (duration)

create table ins_course(
   cid int,
   Iid int

   constraint c1 foreign key(cid) references course(cid)
       on delete cascade on update cascade,
   constraint c2 foreign key (Iid) references instructor(id)
       on delete cascade on update cascade,
   constraint c3 primary key (cid,Iid)
)
create table labs(
   Lid int,
   loca varchar(225),
   capacity int,
   cid int,
    
	constraint c4 foreign key (cid) references course(cid)
	 on delete cascade on update cascade,
	 constraint c5 primary key (cid , Lid),
	 constraint c6 check(capacity < 20)
)
/*use task2
drop table labs
drop table ins_course
drop table instructor
drop table course*/

