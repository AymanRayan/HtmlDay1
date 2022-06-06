use Company_SD
/*_____________lab 2 ______________*/
select * from dbo.Employee
select Fname , Lname , Salary,Dno from dbo.Employee
select Pname , Dnum ,Plocation from dbo.Project
select Fname  + Lname as fullName , Salary * 12 * 0.1 as ANNUALCOMM from dbo.Employee
select SSN , Fname from dbo.Employee where Salary > 1000
select SSN , Fname from dbo.Employee where Salary * 12 > 10000
select Fname , Salary from dbo.Employee where sex = 'f'
select Dnum ,Dname from dbo.Departments where MGRSSN = 968574
select Pnumber , Plocation ,Pname from dbo.Project where Dnum = 10
/*_____________lab 3 ______________*/
----->1
select d.Dnum , d.Dname ,e.SSN, e.Fname+space(1)+e.Lname as FullName 
   from dbo.Departments d 
   join dbo.Employee e on e.SSN = d.MGRSSN
----->2
select d.Dname , p.Pname 
  from dbo.Departments d
  join dbo.Project p on d.Dnum = p.Dnum
----->3
select de.* , e.Fname+space(1)+e.Lname as FullName
  from dbo.Dependent de
  join dbo.Employee e on e.SSN = de.ESSN
----->4
select Pnumber , Plocation , Pname 
  from Project where City = 'cairo' or City ='alex'
----->5
select * from Project where pname like 'a%'
----->6
select * from Employee 
   where Dno = 30 and Salary between 1000 and 2000
----->7
select (e.Fname+SPACE(1)+e.Lname) as FullName  from Employee e
   join Works_for w 
   on e.SSN = w.ESSn and w.Hours = 10 or w.Hours > 10 and e.Dno =10
   join Project p 
   on w.Pno = p.Pnumber and p.Pname = 'al rabwah'
----->8   
select (e.Fname+SPACE(1)+e.Lname) as FullName 
   from Employee e
   join Employee s
   on e.Superssn = s.SSN and s.Fname ='kamel' and s.Lname ='mohamed'
----->9
select p.Pname , (e.Fname+SPACE(1)+e.Lname) as FullName 
   from Employee e
   join Works_for w
   on e.SSN = w.ESSn
   join Project p
   on w.Pno = p.Pnumber order by p.Pname asc
----->10
select p.pnumber , p.dnum , e.lname , e.Bdate from Employee e
    join Departments d
	on d.MGRSSN = e.SSN
	join Project p 
	on p.City = 'cairo' and p.Dnum = d.Dnum
----->11
select * from Employee e 
  join Departments d
  on e.SSN = d.MGRSSN
----->12
select * from Employee 
   left join Dependent
   on ESSN = SSN
----->13
insert into  Employee 
 (fname,Lname,SSN,Sex,Salary,Address,Bdate,Superssn,Dno)
values
 ('ayman','rayan','102672','m','3000','st mahmodya alex','5/1/96','112233','30')
----->14
insert into  Employee 
 (fname,Lname,SSN,Sex,Address,Bdate,Dno)
values
 ('mo','ahmed','102660','m','alex','1/1/96','30')
----->15
update Employee 
set Salary = Salary + Salary * 0.2
where SSN = 102672

