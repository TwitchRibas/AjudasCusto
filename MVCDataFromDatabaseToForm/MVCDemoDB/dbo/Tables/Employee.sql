CREATE TABLE [dbo].[Employee]
(
	[Id] INT NULL, 
	[IDEmpregado] INT NOT NULL, 
	[PrimeiroNome] NVARCHAR(50) NOT NULL, 
	[UltimoNome] NVARCHAR(50) NOT NULL, 
	[Contacto] INT NOT NULL, 
	[NumContribuinte] INT NOT NULL, 
	[Morada] NVARCHAR(100) NOT NULL, 
	CONSTRAINT [PK_Employee] PRIMARY KEY ([IDEmpregado])
)
