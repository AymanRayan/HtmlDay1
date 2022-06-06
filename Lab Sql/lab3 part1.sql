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
select d.Dnum , d.Dname , e.Fname + e.Lname as fullname 
   from dbo.Departments d 
   join dbo.Employee e on e.SSN = d.MGRSSN