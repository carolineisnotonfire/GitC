select C.NomeCarro, (count(L.Carro)) as 'Alocações', year(L.Dat) 'Ano:' from Locacao L
inner join Carros C on L.Carro = C.Id
group by C.NomeCarro, Year(L.Dat)
order by C.NomeCarro, Year(L.Dat) desc