
select 

d.[Data],
tr.Aluno,
isnull (n.Nota,0) as 'nota',
iif (isnull (p.Id,0) > 0, 'Presente', 'Ausente') as 'Presenças'
from Diario d 
inner join Turmas t on d.Turma = t.Id
inner join TurmaAlunos tr on t.Id = tr.Turma
inner join Alunos a on tr.Aluno = a.Id
left join Presenca p on d.Id = p.Diario and d.Id = p.Diario
left join Notas n on tr.Aluno = n.Aluno and d.Id = n.DiarioId
