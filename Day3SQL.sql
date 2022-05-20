
/*
create view view_product_order_Zhou as
select p.ProductName, sum(od.Quantity) 'total_quantity'
from Products p
inner join [Order Details] od
on p.ProductID = od.ProductID
group by p.ProductName
--order by total_quantity desc
*/


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

exec sp_product_order_quantity_zhou




