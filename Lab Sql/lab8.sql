--1
use ITI
alter proc nostudent @dept varchar(20)
  as
  select count(st_id) as [No of students],@dept as "Department"
  from Student s  join Department d
  on s.Dept_Id = d.Dept_Id
  where d.Dept_Name = @dept

nostudent 'java'
nostudent 'sd'
--2
use Company_SD
alter proc che 
as
   declare @name varchar(20)
   select @name=Pname from Project 
   where Pnumber = 100
   if(
    (select count(ESSn)
	from Works_for join Project 
	on Pnumber = Pno 
	where Pnumber=100) >= 3)
	begin
	select 'The no of employees in '
	+ @name +' is 3 or more' as "Masseage"
	end
	else
	begin
	  select 'The following employees work for '+@name 
	  as "Masseage"
	  select fname ,lname from Employee 
	  join Works_for on ESSn = SSN
	  where Pno =100
    end
che

--3
create proc updateEmp @Oid int , @Nid int ,@Pid int
as
  begin try
     update Works_for 
      set ESSn = @Nid ,  
      where ESSn = @Oid and Pno = @Pid
   end try
   begin catch
     select 'Something went Wrong try again later'
   end catch
--4
create table Audit_history
(
  projectNo int,
  userName varchar(100),
  ModifiedDate date,
  Budget_old int,
  Budget_new int
)
alter trigger t1
on project
after update
as
    if UPDATE(budget)
	begin 
	    declare @OldB int ,@NewB int , @Pn int
		select @OldB=budget from deleted
		select @NewB=budget from inserted
		select @pn=Pnumber from inserted
		insert into Audit_history
		values(@pn,SUSER_NAME(),GETDATE(),@OldB,@NewB)
    end

update Project set budget = 1300
where budget = 1200
select * from Audit_history
select * from Project
--5
use ITI
create trigger t2
on department 
instead of insert
as
  select 'insert in department not allowed for user '+SUSER_NAME()
--6
use Company_SD
create trigger t3
on employee
after insert
as
   if (MONTH(GETDATE()) = 3)
   rollback
   else
   select 'Welcome to our company'
--7
create table Audit_student
(
  [Server User Name] varchar(100),
  [Date] date,
  Note varchar(50)
)

alter trigger t4 
on student
after insert 
as
   declare @id int
   declare @note varchar(50)
   select @id=St_id from inserted
   set @note = SUSER_NAME()+' insert new row with id = '+convert(varchar(3),@id)+' in Student table'
   insert into Audit_student ([Server User Name],[Date],Note)
   values (@@SERVERNAME,GETDATE(),@note)

--8
alter trigger t5 
on student
instead of delete
as
   declare @id int
   select @id=St_id from deleted
   insert into Audit_student
   values(@@SERVERNAME,GETDATE(),SUSER_NAME()+
   'try to delete row with id = '+convert(varchar(20),@id))


insert into student (St_Id,St_Fname,St_Age,St_Lname) 
values (100,'ayman',26,'rayan')
select * from Audit_student
delete Student where St_Id = 100
select * from Audit_student