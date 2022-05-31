Write queries for following scenarios
Joins: (AdventureWorks)
1. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables. Join them and produce a result set similar to the following.

Country                        Province

SELECT Person.CountryRegion.Name AS Country , Person.StateProvince.Name  AS Province
From Person.CountryRegion 
INNER JOIN Person.StateProvince 
ON Person.CountryRegion.CountryRegionCode = Person.StateProvince.CountryRegionCode

2. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables and list the countries filter them by Germany and Canada. Join them and produce a result set similar to the following.

Country                        Province

SELECT Person.CountryRegion.Name AS Country , Person.StateProvince.Name  AS Province
From Person.CountryRegion 
INNER JOIN Person.StateProvince 
ON Person.CountryRegion.CountryRegionCode = Person.StateProvince.CountryRegionCode
Where Person.CountryRegion.Name = 'Germany' or Person.CountryRegion.Name = 'Canada'

 Using Northwind Database: (Use aliases for all the Joins)

3.List all Products that has been sold at least once in last 25 years.
select distinct ProductName from Products p
inner join(select distinct ProductID 
from [order details] od
inner join orders o
on od.orderid= o.orderid
where datediff(year, o.orderdate,getdate()) < 25) od
on p.productid = od.productid

4. List top 5 locations (Zip Code) where the products sold most in last 25 years.
select top 5 ShipPostalCode 'zip_code', count(*)
from Orders o
where datediff(year,o.OrderDate,getdate()) <25
and  ShipPostalCode is not null
group by ShipPostalCode


5. List all city names and number of customers in that city.     
select City, count(*) Num_of_Customers
from Customers 
group by City
6. List city names which have more than 2 customers, and number of customers in that city
select City, count(*) Num_of_Customers
from Customers 
group by City
having count(*) > 2

7. Display the names of all customers  along with the  count of products they bought
select  c.Contactname,cid.purchased_quantity 
from Customers c
inner join (select CustomerID, sum(Quantity) purchased_quantity 
from [Order Details] od 
inner join Orders o
on od.OrderID =o.OrderID 
group by CustomerID) cid
on c.CustomerID=cid.CustomerID

8. Display the customer ids who bought more than 100 Products with count of products.
select c.CustomerID,cid.purchased_quantity 
from Customers c
inner join (select distinct CustomerID, sum(Quantity) purchased_quantity 
from [Order Details] od
inner join Orders o
on od.OrderID =o.OrderID
group by CustomerID
having sum(Quantity) >100) cid
on c.CustomerID=cid.CustomerID
order by purchased_quantity desc

9. List all of the possible ways that suppliers can ship their products. Display the results as below

    Supplier Company Name                Shipping Company Name

---------------------------------            ----------------------------------

select s1.CompanyName 'Supplier_Company_Name', 
	   s2.CompanyName 'Shipping_Company_Name' 
from Suppliers s1
cross join Shippers s2

10. Display the products order each day. Show Order date and Product Name.
select o.OrderDate, p.ProductName 
from Orders o
cross join Products p






11.Displays pairs of employees who have the same job title.
select distinct e1.EmployeeID, e1.FirstName, e1.LastName, 
				e2.EmployeeID, e2.FirstName, e2.LastName
from Employees e1, Employees e2
where e1.EmployeeID != e2.EmployeeID
and e1.Title=e2.Title
and e1.EmployeeID < e2.EmployeeID  --avoid duplicate printing


12. Display all the Managers who have more than 2 employees reporting to them.
select distinct e1.FirstName,e1.LastName 
from Employees e1
inner join Employees e2
on e2.ReportsTo = e1.EmployeeID 
group by e1.FirstName, e1.LastName
having count(e1.EmployeeID) > 2

13. Display the customers and suppliers by city. The results should have the following columns

City
Name
Contact Name,
Type (Customer or Supplier)
select 'Customer' AS Type, City, ContactName  
from Customers 
union
select 'Supplier' AS Type, City, ContactName   
from Suppliers

All scenarios are based on Database NORTHWIND.

14.List all cities that have both Employees and Customers.
select distinct City 
from Customers 
where City in (select distinct City from Employees);

15. List all cities that have Customers but no Employee.
a.        Use sub-query
b.        Do not use sub-query
select distinct City 
from Customers
where City not in (select distinct City from Employees);

select distinct c.City 
from Customers c, Employees e
where c.City <> e.City



15.List all products and their total order quantities throughout all orders.
select	p.ProductName , 
		sum(od.Quantity) as 'total_order' 
from Products p 
inner join [Order Details] od
on od.ProductID = p.ProductID 
group by p.ProductName 
order by total_order desc


17. List all Customer Cities that have at least two customers.
a.        Use union
b.        Use sub-query and no union

select City 
from Customers 
group by City 
having count(CustomerID) = 2
union
select City 
from Customers 
group by City 
having count(CustomerID) > 2

select City 
from Customers 
group by City 
having count(CustomerID) >= 2

18.List all Customer Cities that have ordered at least two different kinds of products.
--table customer->table order->table order detail->table product
--finally list city
select c.City
from Customers c
inner join Orders o
on o.CustomerID = c.CustomerID
inner join [Order Details] od
on od.OrderID = o.OrderID
inner join Products p
on p.ProductID = od.ProductID
group by c.City 
having count(distinct p.ProductID) >  1
 



19.List 5 most popular products, their average price, and the customer city that ordered most quantity of it.
--table product->table order detail->table order->table customer
--finally list city
 select top 5  
	p.ProductName, 
	avg(p.UnitPrice) as 'ave_price', 
	c.City  
from Products p 
inner join [Order Details] od
on od.ProductID = p.ProductID 
inner join Orders o 
on o.OrderID = od.OrderID
inner join Customers c  
on c.CustomerID = o.CustomerID 
group by p.ProductName, c.City 
order by sum(od.Quantity) desc 




20.List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered from. (tip: join  sub-query)

--First time I tried to calculate the quantity in order detail
--But easy to solve it via group the shipcity with sort the most order quantity.
--shipcity means the first condition and quantity means the second condition
select top 1 o.ShipCity  --sold most orders city
from Orders o
inner join [Order Details] od
on o.OrderID = od.OrderID
group by o.ShipCity 
order by count(od.Quantity) desc


21. How do you remove the duplicates record of a table?
Using group by or STE to find the duplicates row, then using delete the remove the records where are from the second row. Just keep the first one. I have not tried the methods, but they should work in theory. 
