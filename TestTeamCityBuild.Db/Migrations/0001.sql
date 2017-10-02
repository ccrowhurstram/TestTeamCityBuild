-- <Migration ID="7939ecb8-9bb2-4899-9374-1901abe72ada" />
GO

PRINT N'Creating [dbo].[TestTable]'
GO
CREATE TABLE [dbo].[TestTable]
(
[Id] [int] NOT NULL,
[TestCol] [nchar] (10) NULL
)
GO
PRINT N'Creating primary key [PK_TestTable] on [dbo].[TestTable]'
GO
ALTER TABLE [dbo].[TestTable] ADD CONSTRAINT [PK_TestTable] PRIMARY KEY CLUSTERED  ([Id])
GO
