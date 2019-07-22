select count (L.Carro) 'Alocações', year(L.Dat) 'Ano de aluguel'
from Locacao L
inner join Carros C on L.Carro = C.Id
group by year (L.Dat) 
order by count (L.Carro), year(l.Dat) desc