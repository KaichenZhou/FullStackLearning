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

--Create a stored procedure “sp_product_order_city_[your_last_name]” 
--that accept product name as an input and top 5 cities that ordered most 
--that product combined with the total quantity of that product ordered from that city as output.





