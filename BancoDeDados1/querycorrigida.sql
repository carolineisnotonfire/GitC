--select TipoDog, (sum(TotalVendas)) as 'Vendas',
--MONTH(DataVendas) as 'Mes'
--
--from FTZEZE 
--group by TipoDog, DataVendas
--order by TipoDog
--
--select * from FTZEZE where TipoDog like 'Dog Soya'

select TipoDog, sum(TotalVendas) as 'Vendas', MONTH(DataVendas) as 'Mês'
from FTZEZE --where MONTH(DataVendas) between 1 and 2
group by TipoDog, MONTH(DataVendas)
order by 'Vendas' desc

--correção do professor