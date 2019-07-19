select 
A.Nome,
sum(NT.Nota) / count(NT.Nota) as 'media',
iif ((sum(NT.Nota) / count(NT.Nota)) >= 7, 'Aprovado', 'Reprovado') as 'status media',
iif (Sum(convert(money, NT.Presenca)) / convert(money, count(nt.presenca)) * 100 >= 75, 'Aprovado',
'Reprovado') as 'Status'

from Aluno A
inner join Notas NT on A.Id = nt.aluno
group by a.Nome