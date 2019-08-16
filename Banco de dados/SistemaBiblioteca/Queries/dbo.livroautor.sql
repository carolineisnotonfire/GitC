CREATE TABLE [dbo].[LivroAutor] (
    [Livro] INT NOT NULL,
    [Autor] INT NOT NULL,
    CONSTRAINT [FK_Table_Livros] FOREIGN KEY ([Livro]) REFERENCES [dbo].[Livros] ([Id]),
    CONSTRAINT [FK_Table_Autores] FOREIGN KEY ([Autor]) REFERENCES [dbo].[Autores] ([Id])
);

