select a.Aluno, sum (n.Nota) / count (d.Data) as 'Nota' from Alunos a 
inner join TurmaAlunos tr on a.Id = tr.Aluno 
inner join Diario d on tr.Turma = d.Turma
left join Notas n on d.Id = n.DiarioId and a.Id = n.Aluno
where tr.Turma  = 3
group by a.Aluno

