CREATE TABLE [dbo].[Notas] (
    [Id]     INT          IDENTITY (1, 1) NOT NULL,
    [nota]   FLOAT (53)   NOT NULL,
    [aluno]  INT NOT NULL,
	[Presenca] bit not null,
    [DatInc] DATETIME     DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Table_Aluno] FOREIGN KEY ([aluno]) REFERENCES [dbo].[Aluno] ([Id])
);
