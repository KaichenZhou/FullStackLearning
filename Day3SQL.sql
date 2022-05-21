--Day3 SQL
--1. Create a view named “view_product_order_[your_last_name]”, 
--list all products and total ordered quantity for that product.
create view view_product_order_Zhou 
as
select p.ProductName, sum(od.Quantity) 'total_quantity'
from Products p
inner join [Order Details] od
on p.ProductID = od.ProductID
group by p.ProductName

select * from view_product_order_Zhou

--2.Create a stored procedure “sp_product_order_quantity_[your_last_name]” 
--that accept product id as an input and total quantities of order as output parameter.
create proc sp_product_order_quantity_zhou
@product_id int,
@total_quantity varchar(20) out
as
begin
select @product_id= p.productid,
@total_quantity = sum(od.Quantity)
from Products p
inner join [Order Details] od
on p.ProductID = od.ProductID 
group by p.ProductID
end

begin
declare @total_quantity varchar(20) 
exec sp_product_order_quantity_zhou 2, @total_quantity out
print  @total_quantity 
end 

select * from [Order Details]

--3.Create a stored procedure “sp_product_order_city_[your_last_name]” 
--that accept product name as an input and top 5 cities that ordered most 
--that product combined with the total quantity of that product ordered from that city as output.
-- incompleted question
create proc sp_product_order_city_Zhou
@product_name varchar(30),
@order_city varchar(30) out
as
begin
select @product_name = p1.ProductName
from 
(select top 5  
	p.ProductName, 
	sum(od.Quantity) as 'order_quantity', 
	c.City  
from Products p 
inner join [Order Details] od
on od.ProductID = p.ProductID 
inner join Orders o 
on o.OrderID = od.OrderID
inner join Customers c  
on c.CustomerID = o.CustomerID
group by p.ProductName, c.City 
order by sum(od.Quantity) desc)p1
end
begin
declare @order_city varchar(30) 
exec sp_product_order_city_Zhou 2, @order_city out
print  @order_city 
end 



--4.Create 2 new tables “people_your_last_name” “city_your_last_name”.
--City table has two records: 
--{Id:1, City: Seattle}, 
--{Id:2, City: Green Bay}. 
--People has three records: 
--{id:1, Name: Aaron Rodgers, City: 2}, 
--{id:2, Name: Russell Wilson, City:1}, 
--{Id:3, Name: Jody Nelson, City:2
--Remove city of Seattle. If there was anyone from Seattle, 
--put them into a new city “Madison”. 
--Create a view “Packers_your_name” lists all people from Green Bay. 
--If any error occurred, no changes should be made to DB. 
--(after test) Drop both tables and view.

create table people_zhou (id int, name varchar(20),city_id int)
insert into people_zhou(id,name,city_id) values(1,'Aaron Rodgers',2)
insert into people_zhou(id,name,city_id) values(2,'Russell Wilson',1)
insert into people_zhou(id,name,city_id) values(3,'Jody Nelson',2)
create table city_zhou (city_id int, city varchar(20))
insert into city_zhou(city_id,city) values(1,'Settle')
insert into city_zhou(city_id,city) values(2,'Green Bay')
update city_zhou 
set city = 'Madison' where city = 'Settle'
create view Packers_Kaichen_Zhou as
select * from people_zhou p 
join city_zhou c 
on p.city_id=c.city_id 
where c.city='Greenbay'
begin tran
rollback
drop table people_zhou,city_zhou
drop view Packers_Kaichen_Zhou

--5. Create a stored procedure “sp_birthday_employees_[you_last_name]” 
--that creates a new table “birthday_employees_your_last_name” 
--and fill it with all employees that have a birthday on Feb. 
--(Make a screen shot) drop the table. 
--Employee table should not be affected.
create proc sp_birthday_employees_Zhou as
begin
select EmployeeID,LastName,FirstName
into birthday_employees_Zhou
from Employees 
where month(BirthDate) = '02'
end
drop table birthday_employees_Zhou

--6.How do you make sure two tables have the same data?
--Assuming I created 2 tables such as table1 and table2
--both tables have a 'name' column and a 'age' column
select * 
from table1 
inner join table2
on table1.name = table2.name and table1.age=table2.age



