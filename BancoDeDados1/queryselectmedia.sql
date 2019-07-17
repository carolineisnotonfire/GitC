--select temp.*, IIF(temp.Media >= 7, 'Aprovado', 'Reprovado') as 'Status' from
--(select Nome, Materia, ((nota1 + nota2 + nota3 + nota4 + nota5+ nota6 / 6) as 'Media'
--from Diario1) temp;

select Nome, Materia, ((nota1 + nota2 + nota3 + nota4 + nota5+ nota6) / 6) as 'Media',
IIF(((nota1 + nota2 + nota3 + nota4 + nota5+ nota6) / 6) >= 7, 'Aprovado', 'Reprovado') as 'Status'
from Diario1