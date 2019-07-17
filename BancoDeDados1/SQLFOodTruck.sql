--insert into FTZEZE (TipoDog, TotalVendas, DataVendas) values ('Dog Egg', 50, '2019-01-17')
select TipoDog, (sum(TotalVendas)) as 'Vendas',
MONTH(DataVendas) as 'Mes'

from FTZEZE 
group by TipoDog, DataVendas
order by TipoDog

