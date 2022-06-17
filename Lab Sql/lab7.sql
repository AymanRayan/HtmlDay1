use ITI
--1
create view stud
 as
  select s.St_Fname +' '+s.St_Lname as "Full Name",sc.Grade  
  from stu.Student s
  join Stud_Course sc on s.St_Id = sc.St_Id
  join stu.Course c on c.Crs_Id = sc.Crs_Id
  where sc.Grade > 50
select * from stud
--2
create view manger_topics
with encryption
as
  select i.Ins_Name ,t.Top_Name from Department d
  join Instructor i 
  on Ins_Id = Dept_Manager 
  join Ins_Course ic 
  on i.Ins_Id = ic.Ins_Id
  join stu.Course c
  on c.Crs_Id = ic.Crs_Id
  join topic t
  on t.Top_Id = c.Top_Id
select * from manger_topics
--3
create view ins_java_sd
as
   select Ins_Name,Dept_Name 
       from Department d
       join Instructor i 
	   on d.Dept_Id = i.Dept_Id
	   where Dept_Name = 'java' or Dept_Name ='sd'
select * from ins_java_sd
--4
create view v1
as
    select * from stu.Student 
	where St_Address = 'alex' or St_Address ='cairo'
	with check option

update v1 
set St_Address ='tanta'
 where St_Address='alex'

--5
use Company_SD
create view noEmployees
 as
   select Pname ,count(w.ESSn) as "No. of Employees" 
   from Project p
   join Works_for w 
   on p.Pnumber = w.Pno
   group by Pname
select * from noEmployees
--6
create schema company
alter schema company transfer departments
-----------------
create schema HummanResource
alter schema HummanResource transfer employee
--7
create clustered index i1
on Department(Manager_hiredate)
---error due to primary key --
--8
create unique index i2 
on stu.Student(St_Age)
---error age is duplicated
--9
use Company_SD
declare c1 cursor
 for select salary from Employee
 for update
 declare @sal int
 open c1 
 fetch c1 into @sal
 while @@FETCH_STATUS =0
    begin
	      if @sal < 3000
		  update Employee
		     set Salary=@sal*1.10
			 where current of c1
	      else if @sal >=3000
		  update Employee
		     set Salary=@sal*1.20
			 where current of c1
         fetch c1 into @sal 
    end
close c1
deallocate c1
--10
use ITI
declare c2 cursor
for
   select Ins_Name , Dept_Name from Department d
   join Instructor i 
   on d.Dept_Manager = i.Ins_Id
   for read only
   declare @dep varchar(20),@man varchar(20)
 open c2
   fetch c2 into @dep , @man
   while @@FETCH_STATUS =0
   begin
   select @dep ,@man
   fetch c2 into @dep,@man
   end
   select @dep ,@man
 close c2
deallocate c2
--11
declare c3 cursor
 for 
    select ST_Fname from Student
    for read only
    declare @n nvarchar(max),@cn nvarchar(20)
 open c3
    fetch c3 into @cn
       while @@FETCH_STATUS=0
       begin
       set @n=concat(@n,',',@cn)
     fetch c3 into @cn
     end
    select @n
 close c3
 deallocate c3
--12
---error due to view encryption
