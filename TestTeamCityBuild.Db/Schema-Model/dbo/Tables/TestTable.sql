CREATE TABLE [dbo].[TestTable]
(
[Id] [int] NOT NULL,
[TestCol] [nchar] (10) NULL
)
GO
ALTER TABLE [dbo].[TestTable] ADD CONSTRAINT [PK_TestTable] PRIMARY KEY CLUSTERED  ([Id])
GO
