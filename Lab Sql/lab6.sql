use ITI
--1
create function 
 getmonth(@da date)
returns varchar(20)
    begin
	declare @mo varchar(20)= format(@da,'MMMM')
	return @mo
	end
select dbo.getmonth(GETDATE())
--2
create function 
  getrange(@x int , @y int)
  returns @t table 
        (number int)
  as 
  begin
  declare @z int = @x 
  while @z < @y - 1 
  begin
    set @z +=1
	insert into @t (number) values(@z)
  end
  return
  end

  select * from dbo.getrange(10,20)
--3
create function getStuData(@id int)
returns table 
  as
  return 
  (select St_fname + ' '+ St_lname as "Full name", Dept_Name
  from Student s join Department d 
  on s.Dept_Id = d.Dept_Id
  where St_Id = @id )
  select * from getStuData(5)
--4
create function chec(@id int)
returns varchar(50)
    begin
	declare @fir varchar(20)
	declare @last varchar(20)
	select @fir = st_fname from stu.Student where St_Id=@id
	select @last = st_lname from stu.Student where St_Id=@id
	if (@fir is null)
	 return 'First name is null'
    else if (@last is null)
	 return 'Last name is null'
    else if (@fir is null and @last is null)
	return 'First name & last name are null'
	return 'First name & last name are not null'
   end
select dbo.chec(10)
--5
create function mangerData(@id int)
returns table 
  as 
  return(select Dept_Name,Ins_Name,Manager_hiredate 
         from Department join Instructor
		 on Dept_Manager = Ins_Id
		 where Dept_Manager = @id)
select * from mangerData(5)

--6
create function stuName(@str varchar(20),@id int)
returns @t1 table
     (studata varchar(50))
	 as
	 begin 
	 if(@str = 'first name')
	 begin
	 insert into @t1 select isnull(St_Fname,'first name')  
	                from Student where St_Id = @id
	 end
	 else if (@str ='last name')
	 begin
	 insert into @t1 select isnull(St_lname,'last name') 
	                from Student where St_Id = @id
	 end
	 else if (@str = 'full name')
	 begin
	 insert into @t1 select isnull(St_Fname+' '+St_Lname,'full name') 
	                from Student where St_Id = @id
	 end
	 return
end
select * from stuName('first name',10)
select * from stuName('last name',10)
select * from stuName('full name',10)
--7
select St_Id, SUBSTRING(St_Fname,1,len(st_fname)-1) 
  from Student
--8
select * from Stud_Course 
update Stud_Course 
  set Grade = null 
  where st_id in (select s.St_Id from Department d 
       join Student s
       on d.Dept_Id = s.Dept_Id
       where Dept_Name = 'sd')

--9
create table dailyt(
   id int,
   dtra int
)
create table lastt(
    id int,
    ltra int
)
insert into dailyt values (1,1000),(2,2000),(3,1000)
insert into lastt values (1,4000),(4,2000),(2,10000)
merge into lastt as l
    using dailyt as d
    on l.id = d.id
    when matched
	then
     update
	  set l.ltra = d.dtra
    when not matched
	then 
	insert values (d.id,d.dtra);
  
--10 ---ITIStud 123
create schema stu
alter schema stu transfer student 
alter schema stu transfer course



--bonus
   create table t1 (
      id int,
	  nam varchar(20),
	  hyr hierarchyid 
   ) 
   insert into t1 (id,nam,hyr) 
      values (1,'ayman','/'),(2,'ahmed','/1/')
