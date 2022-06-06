use Company_SD
--1/a-b 
select Dependent_name, d.Sex  from Employee e
     join Dependent d 
     on SSN = ESSN and e.sex ='f'
     and d.Sex = 'f'
union all
select Dependent_name, d.Sex from Employee e
     join Dependent d
     on SSN = ESSN and e.sex ='m'
     and d.Sex ='m'

--2
select Pname ,SUM(Hours) as Hr_Per_Week from Project
    join Works_for on Pnumber = Pno
	group by Pname

--3
select * from Departments 
 where Dnum = (select Dno from Employee 
               where SSN = (select min(SSN) from Employee))

--4
select Dname ,max(Salary) as maxSal ,min(Salary) as minSal,
   AVG(Salary) as avgSal
   from Employee join Departments 
   on Dno = Dnum group by Dname

--5
select Fname +' ' + Lname as FullName from Employee
    join Departments
	on SSN = MGRSSN
    where SSN not in (select ESSN 
	                  from Dependent) 
--6
select Dnum ,Dname,COUNT(SSN) as noOfEmp  from Employee
  join Departments on Dno = Dnum
  group by Dname ,Dnum
  having AVG(Salary) < (select AVG(isnull(Salary,0)) 
                        from Employee)

--7
select d.Dnum , lname , fname , pname from Employee
   join Departments d on Dno = Dnum
   join Project p on p.Dnum = d.Dnum
   order by d.Dnum ,Lname,Fname

--8

select Max(Salary) as Salary from Employee
union all
select Max(Salary) as Salary
   from Employee
   where Salary < (select MAX(salary) from Employee)
     
--9
select fname ,lname from Employee 
   where fname in (select Dependent_name from Dependent)

--10
select SSN , fname +' ' +lname as FullName from Employee
    where Exists (select ESSN from Dependent 
	               where SSN = ESSN)
--11
insert into Departments (Dname,Dnum,MGRSSN,[MGRStart Date])
values ('DEPT IT','100','112233','1-11-2006')

--12/a
update Departments
  set MGRSSN = '968574'
where Dnum = '100'
--12/b
update Departments 
 set MGRSSN = '102672'
 where Dnum = 20
--12/c
update Employee
 set Superssn = '102672'
 where SSN = '102660'
--13
begin try
   begin transaction
      update Departments set MGRSSN ='102672'
            where  MGRSSN = '223344'
      update Employee set Superssn = '102672'
            where Superssn ='223344'
      delete Dependent where ESSN = '223344'
      update Works_for set ESSn = '102672'
            where ESSn = '223344'
      delete Employee where SSN ='223344'
   commit 
end try
begin catch
   rollback
end catch

--14
update Employee 
    set salary = Salary + Salary * 0.3
    where SSN in (select ESSN  from Works_for
                 join Project 
			     on Pno = Pnumber 
			     and pname ='Al Rabwah')








