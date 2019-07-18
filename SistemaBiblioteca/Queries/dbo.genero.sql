CREATE TABLE [dbo].[Genero] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [Tipo]      VARCHAR (200)  NOT NULL,
    [Descricao] VARCHAR (1000) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

