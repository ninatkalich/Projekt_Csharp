create database gabinet_kosmetyczny
go
use gabinet_kosmetyczny
go
CREATE TABLE [dbo].[Klienci](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[imie] [nchar](50) NOT NULL,
	[nazwisko] [nchar](50) NOT NULL,
	[p³ec] [nchar](10) NOT NULL,
	[pierwsza_rejestracja] [date] NOT NULL,
 CONSTRAINT [PK_[Klienci] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Pracownicy](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[imie] [nvarchar](50) NOT NULL,
	[nazwisko] [nvarchar](50) NOT NULL,
	[p³eæ] [nvarchar](50) NOT NULL,
	[Pilêgnacja_D³oni] [bit] NOT NULL,
	[Makijarz] [bit] NOT NULL,
	[Stylizacja_brwi] [bit] NOT NULL,
	[Masa¿e] [bit] NOT NULL,
 CONSTRAINT [PK_Pracownicy] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Pracownicy] ADD  CONSTRAINT [DF_Pracowicy_Pilêgnacja_D³oni]  DEFAULT ((0)) FOR [Pilêgnacja_D³oni]
GO

ALTER TABLE [dbo].[Pracownicy] ADD  CONSTRAINT [DF_Pracowicy_[Makijarz]  DEFAULT ((0)) FOR [Makijarz]
GO

ALTER TABLE [dbo].[Pracownicy] ADD  CONSTRAINT [DF_Pracowicy_Stylizacja_brwi]  DEFAULT ((0)) FOR [Stylizacja_brwi]
GO

ALTER TABLE [dbo].[Pracownicy] ADD  CONSTRAINT [DF_Pracowicy_Masa¿e]  DEFAULT ((0)) FOR [Masa¿e]
GO


CREATE TABLE [dbo].[Zabieg](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[nazwa] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Zabieg] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO [dbo].[Zabieg]
          
     VALUES
           ('Pielêgnacja_D³oni');
		   INSERT INTO [dbo].[Zabieg]
          
     VALUES
           ('Makijarz');
		   INSERT INTO [dbo].[Zabieg]
          
     VALUES
           ('Stylizacja_brwi');
		   INSERT INTO [dbo].[Zabieg]
          
     VALUES
           ('Masa¿e');
GO




CREATE TABLE [dbo].[Wizyta](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[data] [nchar](50) NOT NULL,
	[Us³uga_id] [int]  NOT NULL,
	[Pracownik_id] [int] NOT NULL,
	[Klient_id] [int] NOT NULL,
 CONSTRAINT [PK_Klasa] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE Wizyta
ADD FOREIGN KEY (Klient_id)
REFERENCES Klienci(Id)


ALTER TABLE Wizyta
ADD FOREIGN KEY (Pracownik_id)
REFERENCES Pracownicy(Id)

ALTER TABLE Wizyta
ADD FOREIGN KEY (Us³uga_id)
REFERENCES Zabieg(Id)


GO