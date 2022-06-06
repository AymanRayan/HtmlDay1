use ITI
--1
select COUNT(St_Age) from Student
--2
select  Ins_Name from Instructor
select distinct Ins_Name from Instructor
--3
select St_Id as "Student ID" ,isnull(St_Fname+' '+St_Lname ,'No Name')as "Student Full Name" 
,Dept_Name as "Department name"
     from Student s 
	 join Department d 
	 on d.Dept_Id = s.Dept_Id
--4
select Ins_Name , Dept_Name 
     from Instructor i
     left join Department d 
	 on d.Dept_Id = i.Dept_Id
--5
select St_Fname+' '+St_Lname as "Student Full Name" ,crs_Name
      from Student x 
	  join Stud_Course y on x.St_Id = y.St_Id
	  join Course c on c.Crs_Id =y.Crs_Id
	  and y.Grade is not null
--6
select COUNT(crs_id),top_name 
    from Course c join Topic t
	on t.Top_Id = c.Top_Id
	group by Top_Name
--7
select max(salary) as "max salary",min(salary) as "min salary" 
    from Instructor
--8
select * from Instructor
    where Salary < (select AVG(Salary) 
	from Instructor)
--9
select dept_name from Department d
    join Instructor i 
	on d.Dept_Id = i.Dept_Id
	and i.Salary = (select min(salary) 
	from Instructor)
--10
select top(2) salary 
  from Instructor
  order by Salary desc
--11
select Ins_Name,isnull(convert(varchar(25),Salary),'bonus') as Salary  
   from Instructor

--12
select AVG(isnull(salary,0)) as "Average Salary" 
    from Instructor
--13
select x.St_Fname, s.* from Student x
     join Student s 
	 on x.St_super = s.St_Id
--14
select * 
  from (select *,ROW_NUMBER() over(partition by dept_id order by salary desc ) 
  as R 
        from Instructor) as t1
where R <=2
--15
select  *
 from (select *,DENSE_RANK() over(partition by dept_id order by newid()) as d
       from student) as t2
where d = 1
