use AdventureWorks2012
--1
select SalesOrderID , ShipDate 
    from Sales.SalesOrderHeader
	where OrderDate > '7/28/2002'
	and OrderDate < '7/29/2014'
--2
select ProductID, Name  
    from Production.Product
	where StandardCost < 110.00
--3
select ProductID, Name 
    from Production.Product
	where Weight is null
--4
select * from Production.Product
   where Color in ('red','silver','black')
--5
select * from Production.Product
    where name like 'b%'
--6
update Production.ProductDescription
   set Description='Chromoly steel_High of defects'
   where ProductDescriptionID=3
select Description from Production.ProductDescription
    where Description like '%[_]%'
--7
select count(TotalDue) as "no of due" , OrderDate 
   from Sales.SalesOrderHeader
   where OrderDate between '7/1/2001' and '7/31/2014'
   group by OrderDate
--8
select distinct HireDate from HumanResources.Employee
--9
select avg(distinct ListPrice) as "Average price" 
    from Production.Product
--10
select 'The '+ Name +' is only! '+CONVERT(varchar(50), ListPrice) 
   as "Price Value"
   from Production.Product
   where ListPrice between 100 and 200
--11-a
select  rowguid ,Name,SalesPersonID ,Demographics 
   into sales.store_Archive
   from Sales.Store 
--11-b
select  rowguid ,Name,SalesPersonID ,Demographics 
   into sales.store_Archivee
   from Sales.Store
   where 1=2
--12
select getdate()
union
select format(getDate(),'dd-mm-yy hh:mm:ss tt')


select format(getDate(),'dd-MM-yy')
union
select format(getDate(),'yy-mm-dd')
union
select format(getDate(),'dddd')
union
select format(getDate(),'MMMM')
union
select format(getDate(),'yyyy')
union
select format(getDate(),'hhhh')
union
select format(getDate(),'tttt')


