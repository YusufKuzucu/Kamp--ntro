--select
--Select CustomerID adı,ContactName şırketadi,City şehir from Customers

--select * from Customers where City='london'

--select * from Products where CategoryID=1 or CategoryID=3
--select * from Products where CategoryID=1 and UnitPrice>10
--select * from Products where CategoryID=1 order by  UnitPrice desc


--select COUNT(*) from Products where CategoryID=2

--select CategoryID,COUNT(*) from Products where UnitPrice>20 group by CategoryID having COUNT(*)<10

--select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName 
--from Products inner join Categories on Products.CategoryID=Categories.CategoryID
--where Products.UnitPrice>10

--DTO data transformation object

--select * from Products left join [Order Details]
--on Products.ProductID=[Order Details].ProductID
 
select * from Customers c left join Orders o
on c.CustomerID= o.CustomerID
where o.CustomerID is null