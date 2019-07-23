--4 Trazer somente as marcas que Felipe cadastrou
select Nome from Marcas where
UsuInc = 1 

--5 Trazer somente as marcas que Giomar cadastrou
select Nome from Marcas 
where UsuInc  = 2

--7 Trazer somente a quantidade de marcas que Felipe cadastrou do maior para menor
select Nome from Marcas where
UsuInc = 1 
order by Nome desc

--8Trazer somente a quantidade de marcas que Giomar cadastrou do menor para maior
select Nome from Marcas 
where UsuInc  = 2
order by Nome asc

--10Trazer somente a quantidade de marcas que Felipe e Giomar cadastraram 
select Nome, UsuInc from Marcas 
where UsuInc = 1 or UsuInc = 2
--12Trazer somente os carros que Felipe cadastrou
select Modelo from Carros 
where UsuInc = 1

--13Trazer somente os carros que Giomar cadastrou
select Modelo from Carros 
where UsuInc = 2

--15Trazer somente a quantidade de carros que Felipe cadastrou maior para menor
select count(Modelo) 'Quantidade de carros do Felipe'from Carros
where UsuInc = 1
order by count(Modelo) desc

--16Trazer somente a quantidade de carros que Giomar cadastrou menor para maior
select count(Modelo) 'Quantidade de carros do Giomar' from Carros
where UsuInc = 2
order by count(Modelo) desc

--18Trazer somente a quantidade de carros que Felipe e Giomar cadastraram 

select count(Modelo)'Quantidade carros Giomar e Felipe' from Carros 
where UsuInc =1 or UsuInc=2
order by count(Modelo) desc;

--20Trazer somente os carros das marcas que Felipe cadastrou
select c.Modelo from Carros c
inner join Marcas m on m.Id = c.Marca
where c.UsuInc = 1;

--21Trazer somente os carros das marcas que Giomar cadastrou
select c.Modelo from Carros c
inner join Marcas m on m.Id = c.Marca
where c.UsuInc = 2;

--23Trazer somente a quantidade de carros das marcas que Felipe cadastrou maior para menor
Select count(Modelo)'Carros felipe cadastrou' from Carros 
where UsuInc=1
order by count(Modelo) desc;

--24Trazer somente a quantidade de carros das marcas que Giomar cadastrou menor para maior
select count(Modelo)'Carros que Giomar cadastrou'from Carros 
where UsuInc=2
order by count(Modelo) asc;

--26Trazer o valor total de vendas 2019 isolado
select sum(Valor) 'Valor total de vendas:' from Vendas
where year(DatInc) = 2019 

--27Trazer a quantidade total de vendas 2019 isolado
select sum(Quantidade) 'Quantidade total de vendas:' from Vendas
where year(DatInc) = 2019

--29Trazer o valor total de vendas em cada ano e ordernar do maior para o menor
select sum (Valor) 'Valor total de vendas:', year(DatInc) 'Ano:' from Vendas 
group by year(DatInc)
order by YEAR(DatInc) desc
--30Trazer a quantidade de vendas em cada ano e ordernar do maior para o menor
select sum(Quantidade)'Quantidade de vendas:', YEAR(DatInc) 'Ano:' from Vendas
group by year(DatInc)

--32Trazer o mês de cada ano que retornou a maior quantidade de vendas
--		- Tradução "Retornar agrupado por mês e ordernar do maior para menor"
select  month(DatInc) 'Mês:', sum(Quantidade) 'Vendas:' from Vendas
group by month(DatInc)
order by sum(Quantidade) desc
--		
--35Trazer o mês de cada ano que retornou o maior valor de vendas
--		- Tradução "Retornar agrupado por mês e ordernar do maior para menor"
select  month(DatInc) 'Mês:', sum(Valor) 'Valor  de vendas:' from Vendas 
group by month(DatInc)
order by sum(Valor) desc

--38Trazer o valor total de vendas que Felipe realizou
select sum(Valor)  'Valor total por Felipe: ', U.Usuario from Vendas V
inner join Usuarios U on V.UsuInc = U.Id
where V.UsuInc = 1
group by U.Usuario

--39Trazer o valor total de vendas que Giomar realizou
select sum(Valor)  'Valor total por Giomar: ', U.Usuario from Vendas V
inner join Usuarios U on V.UsuInc = U.Id
where V.UsuInc = 2
group by U.Usuario

--41Trazer a quantidade total de vendas que Felipe realizou
select sum (Quantidade) 'Quantidade total: ', U.Usuario from Vendas V
INNER JOIN Usuarios U on V.UsuInc = U.Id where V.UsuInc = 1
group by U.Usuario

--42Trazer a quantidade de vendas que Giomar realizou
select sum (Quantidade) 'Quantidade total: ', U.Usuario from Vendas V
INNER JOIN Usuarios U on V.UsuInc = U.Id where V.UsuInc = 2
group by U.Usuario

--44Trazer a quantidade total de vendas que Felipe e Giomar realizaram ordenando do maior para menor
select sum(Quantidade) 'Quantidade total: ', U.Usuario from Vendas V
INNER JOIN Usuarios U ON V.UsuInc = U.Id
group by U.Usuario
order by sum(Quantidade) desc

--45Trazer o valor de vendas que Felipe e Giomar realizaram ordenando do maior para menor
select V.Valor, U.Usuario from Vendas V
inner join Usuarios U on V.UsuInc = U.Id
order by Valor desc

--47Trazer  a marca mais vendida de todos os anos
--		- Tradução "Retornar todas as marcas que foram vendidas mas ordernada da maior para menor"

SELECT year(V.DatInc) 'Ano:', M.Nome as 'Marcas mais vendidas',  
sum(V.Quantidade) 'Quantidade de carros vendidos' from Marcas M
inner join Carros C on  C.Marca = m.Id
inner join Vendas V on V.Carro = c.Id
group by  year(V.DatInc), m.Nome
order by sum(v.Quantidade) desc

--49Trazer o valor total da marca mais vendida de todos os anos		
SELECT year(V.DatInc) 'Ano:', M.Nome as 'Marcas mais vendidas',  
sum(V.Valor) 'Valor' from Marcas M
inner join Carros C on  C.Marca = m.Id
inner join Vendas V on V.Carro = c.Id
group by  year(V.DatInc), m.Nome
order by sum(v.Valor) desc
--51Trazer a quantidade do carro mais vendido de todos os anos
select sum(Quantidade)'Quantidade de carros vendidos: ', C.Modelo from Vendas V
inner join Carros C on V.Carro = C.Id
group by C.Modelo
order by sum(Quantidade) desc

--52Trazer o valor do carro mais vendido de todos os anos
select (sum(V.Quantidade) * (sum(V.Valor))) 'Valor total:', C.Modelo from Vendas V
inner join Carros C on C.Id = V.Carro 
group by C.Modelo
order by (sum(V.Quantidade) * (sum(V.Valor))) desc