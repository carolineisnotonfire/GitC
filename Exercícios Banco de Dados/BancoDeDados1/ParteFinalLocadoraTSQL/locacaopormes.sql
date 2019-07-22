select count (L.Carro) 'Alocações', month(L.Dat) 'Mês de aluguel'
from Locacao L
inner join Carros C on L.Carro = C.Id
group by month (L.Dat) 
order by count (L.Carro), month(l.Dat) desc