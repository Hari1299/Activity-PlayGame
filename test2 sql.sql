--1
select city,count(au_id)au_count from authors group by city

--2
select au_fname,au_lname from authors where city not in(
select city from publishers where pub_name='New Moon Books')

--3
create proc proc_query(@aufname varchar(20),@aulname varchar(20),@price float)
as
begin
   update titles set price=@price where title_id in(
   select title_id from titleauthor where au_id in(
   select au_id from authors where au_fname=@aufname and au_lname=@aulname))
end

exec proc_query "Johnson","white",12

--4
create function function_calculatetax(@qty int)
returns float
as
begin
declare
  @tax float
  set @tax=0
  if(@qty>0 and @qty<10)
     set @tax=2
  else if(@qty>=10and @qty<20)
     set @tax=5
   else if(@qty>=20 and @qty<30)
     set @tax=6
   else 
     set @tax=7.5
	 return @tax
	 end
	 select title_id,qty,dbo.function_calculatetax(qty) as Tax from sales;
