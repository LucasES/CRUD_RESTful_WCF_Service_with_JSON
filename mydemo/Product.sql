CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NULL, 
    [Price] MONEY NULL, 
    [Quantity] INT NULL, 
    [CreationDate] DATE NULL	
)
