insert into NotasAluno(nome, nota, materia) values ('samantha', 10, 'matematica')
select nome, (SUM (nota) / count(nota)) as 'media', materia, count (nota) as 'provas' from NotasAluno
group by nome, materia;