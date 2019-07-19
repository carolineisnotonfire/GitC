--select * from Livros
--select * from Biblioteca
--select Livros.Nome , Biblioteca.Nome fro
--
--select 
--	BL.Nome,
--	count(LV.Id) as 'Quantidade de livros'
--
--from Biblioteca BL
--inner join Livros LV on BL.Id = LV.Biblioteca
--group by BL.Nome

select BL.Nome,
count (LV.Id) as 'Quantidade de livros',
US.Nome as 'Username' from Biblioteca BL

inner join Livros LV on BL.Id = LV.Biblioteca
inner join Usuario US on LV.UsuInc = US.Id

group by BL.Nome, US.Nome
