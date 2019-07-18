CREATE TABLE [dbo].[Livros] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Registro]    INT            NOT NULL,
    [Titulo]      VARCHAR (200)  NOT NULL,
    [Isbn]        VARCHAR (15)   NOT NULL,
    [Genero]      INT            NOT NULL,
    [Editora]     INT            NOT NULL,
    [Sinopse]     NVARCHAR (MAX) NULL,
    [Observações] VARCHAR (1000) NULL,
    [Ativo]       BIT            NOT NULL,
    [UsuInc]      INT            NOT NULL,
    [UsuAlt]      INT            NOT NULL,
    [DataInc]     DATETIME       NOT NULL,
    [DataAlt]     DATETIME       NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

