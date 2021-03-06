/*    ==Parâmetros de Script==

    Versão do Servidor de Origem : SQL Server 2016 (13.0.4001)
    Edição do Mecanismo de Banco de Dados de Origem : Microsoft SQL Server Express Edition
    Tipo do Mecanismo de Banco de Dados de Origem : SQL Server Autônomo

    Versão do Servidor de Destino : SQL Server 2017
    Edição de Mecanismo de Banco de Dados de Destino : Microsoft SQL Server Standard Edition
    Tipo de Mecanismo de Banco de Dados de Destino : SQL Server Autônomo
*/
USE [master]
GO
/****** Object:  Database [PetShop]    Script Date: 13/09/2017 21:47:37 ******/
CREATE DATABASE [PetShop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PetShop', FILENAME = N'C:\PetShop\PetShop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PetShop_log', FILENAME = N'C:\PetShop\PetShop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [PetShop] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PetShop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PetShop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PetShop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PetShop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PetShop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PetShop] SET ARITHABORT OFF 
GO
ALTER DATABASE [PetShop] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [PetShop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PetShop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PetShop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PetShop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PetShop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PetShop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PetShop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PetShop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PetShop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PetShop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PetShop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PetShop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PetShop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PetShop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PetShop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PetShop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PetShop] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PetShop] SET  MULTI_USER 
GO
ALTER DATABASE [PetShop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PetShop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PetShop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PetShop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PetShop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PetShop] SET QUERY_STORE = OFF
GO
USE [PetShop]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [PetShop]
GO
/****** Object:  Table [dbo].[Agenda]    Script Date: 13/09/2017 21:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Agenda](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Servico] [int] NOT NULL,
	[Animal] [int] NOT NULL,
	[HorarioInicio] [datetime] NOT NULL,
	[HorarioFim] [datetime] NOT NULL,
	[Date] [date] NOT NULL,
	[Status] [tinyint] NOT NULL,
 CONSTRAINT [PK_Agenda] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Animal]    Script Date: 13/09/2017 21:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Animal](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](50) NOT NULL,
	[DtNascimento] [date] NOT NULL,
	[Obs] [text] NOT NULL,
	[Raca] [int] NOT NULL,
	[Cliente] [int] NOT NULL,
 CONSTRAINT [PK_Animal] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 13/09/2017 21:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](50) NOT NULL,
	[CPF] [nvarchar](11) NOT NULL,
	[Sexo] [nvarchar](15) NOT NULL,
	[DtNascimento] [date] NOT NULL,
	[DtCadastro] [datetime] NOT NULL,
	[Telefone] [nvarchar](11) NOT NULL,
	[Telefone2] [nvarchar](11) NOT NULL,
	[Telefone3] [nvarchar](11) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[CEP] [nvarchar](10) NOT NULL,
	[Endereco] [nvarchar](80) NOT NULL,
	[Bairro] [nvarchar](50) NOT NULL,
	[Cidade] [nvarchar](50) NOT NULL,
	[UF] [nvarchar](2) NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Especie]    Script Date: 13/09/2017 21:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especie](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](40) NOT NULL,
	[Obs] [text] NOT NULL,
 CONSTRAINT [PK_Especie] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemPacote]    Script Date: 13/09/2017 21:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemPacote](
	[Codigo] [int] NOT NULL,
	[Pacote] [int] NOT NULL,
	[Servico] [int] NOT NULL,
	[Quantidade] [int] NOT NULL,
	[Preco] [money] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemProduto]    Script Date: 13/09/2017 21:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemProduto](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Venda] [int] NOT NULL,
	[Produto] [int] NOT NULL,
	[Desconto] [money] NOT NULL,
	[Quantidade] [float] NOT NULL,
 CONSTRAINT [PK_ItemProduto] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemServico]    Script Date: 13/09/2017 21:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemServico](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Venda] [int] NOT NULL,
	[Profissional] [int] NOT NULL,
	[Preco] [money] NOT NULL,
	[Desconto] [money] NOT NULL,
	[Servico] [int] NOT NULL,
 CONSTRAINT [PK_ItemServico] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pacote]    Script Date: 13/09/2017 21:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pacote](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [nvarchar](50) NOT NULL,
	[Preco] [money] NOT NULL,
 CONSTRAINT [PK_Pacote] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pagamento]    Script Date: 13/09/2017 21:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pagamento](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [nvarchar](50) NOT NULL,
	[MaxParcela] [tinyint] NOT NULL,
 CONSTRAINT [PK_Pagamento] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PagamentoVenda]    Script Date: 13/09/2017 21:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PagamentoVenda](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Venda] [int] NOT NULL,
	[Pagamento] [int] NOT NULL,
	[Valor] [money] NOT NULL,
 CONSTRAINT [PK_PagamentoVenda] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produto]    Script Date: 13/09/2017 21:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produto](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [nvarchar](50) NOT NULL,
	[PrecoCusto] [money] NOT NULL,
	[PrecoVenda] [money] NOT NULL,
	[CodigoBarras] [nvarchar](16) NOT NULL,
	[Estoque] [float] NOT NULL,
	[Tipo] [tinyint] NOT NULL,
 CONSTRAINT [PK_Produto] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profissional]    Script Date: 13/09/2017 21:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profissional](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](50) NOT NULL,
	[Comissao] [float] NOT NULL,
 CONSTRAINT [PK_Profissional] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Raca]    Script Date: 13/09/2017 21:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Raca](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](50) NOT NULL,
	[Obs] [text] NOT NULL,
	[Especie] [int] NOT NULL,
 CONSTRAINT [PK_Raca] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servico]    Script Date: 13/09/2017 21:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servico](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [nvarchar](50) NOT NULL,
	[Preco] [money] NOT NULL,
 CONSTRAINT [PK_Servico] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 13/09/2017 21:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](50) NOT NULL,
	[Senha] [nvarchar](50) NOT NULL,
	[Nivel] [tinyint] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venda]    Script Date: 13/09/2017 21:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venda](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [int] NOT NULL,
	[Cliente] [int] NOT NULL,
	[Data] [datetime] NOT NULL,
	[Valor] [money] NOT NULL,
	[Status] [tinyint] NOT NULL,
 CONSTRAINT [PK_Venda] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Agenda]  WITH CHECK ADD  CONSTRAINT [FK_Agenda_Animal] FOREIGN KEY([Animal])
REFERENCES [dbo].[Animal] ([Codigo])
GO
ALTER TABLE [dbo].[Agenda] CHECK CONSTRAINT [FK_Agenda_Animal]
GO
ALTER TABLE [dbo].[Agenda]  WITH CHECK ADD  CONSTRAINT [FK_Agenda_Servico] FOREIGN KEY([Servico])
REFERENCES [dbo].[Servico] ([Codigo])
GO
ALTER TABLE [dbo].[Agenda] CHECK CONSTRAINT [FK_Agenda_Servico]
GO
ALTER TABLE [dbo].[Animal]  WITH CHECK ADD  CONSTRAINT [FK_Animal_Cliente] FOREIGN KEY([Cliente])
REFERENCES [dbo].[Cliente] ([Codigo])
GO
ALTER TABLE [dbo].[Animal] CHECK CONSTRAINT [FK_Animal_Cliente]
GO
ALTER TABLE [dbo].[Animal]  WITH CHECK ADD  CONSTRAINT [FK_Animal_Raca] FOREIGN KEY([Raca])
REFERENCES [dbo].[Raca] ([Codigo])
GO
ALTER TABLE [dbo].[Animal] CHECK CONSTRAINT [FK_Animal_Raca]
GO
ALTER TABLE [dbo].[ItemPacote]  WITH CHECK ADD  CONSTRAINT [FK_ItemPacote_Pacote] FOREIGN KEY([Pacote])
REFERENCES [dbo].[Pacote] ([Codigo])
GO
ALTER TABLE [dbo].[ItemPacote] CHECK CONSTRAINT [FK_ItemPacote_Pacote]
GO
ALTER TABLE [dbo].[ItemPacote]  WITH CHECK ADD  CONSTRAINT [FK_ItemPacote_Servico] FOREIGN KEY([Servico])
REFERENCES [dbo].[Servico] ([Codigo])
GO
ALTER TABLE [dbo].[ItemPacote] CHECK CONSTRAINT [FK_ItemPacote_Servico]
GO
ALTER TABLE [dbo].[ItemProduto]  WITH CHECK ADD  CONSTRAINT [FK_ItemProduto_Produto] FOREIGN KEY([Produto])
REFERENCES [dbo].[Produto] ([Codigo])
GO
ALTER TABLE [dbo].[ItemProduto] CHECK CONSTRAINT [FK_ItemProduto_Produto]
GO
ALTER TABLE [dbo].[ItemProduto]  WITH CHECK ADD  CONSTRAINT [FK_ItemProduto_Venda] FOREIGN KEY([Venda])
REFERENCES [dbo].[Venda] ([Codigo])
GO
ALTER TABLE [dbo].[ItemProduto] CHECK CONSTRAINT [FK_ItemProduto_Venda]
GO
ALTER TABLE [dbo].[ItemServico]  WITH CHECK ADD  CONSTRAINT [FK_ItemServico_Profissional] FOREIGN KEY([Profissional])
REFERENCES [dbo].[Profissional] ([Codigo])
GO
ALTER TABLE [dbo].[ItemServico] CHECK CONSTRAINT [FK_ItemServico_Profissional]
GO
ALTER TABLE [dbo].[ItemServico]  WITH CHECK ADD  CONSTRAINT [FK_ItemServico_Servico] FOREIGN KEY([Servico])
REFERENCES [dbo].[Servico] ([Codigo])
GO
ALTER TABLE [dbo].[ItemServico] CHECK CONSTRAINT [FK_ItemServico_Servico]
GO
ALTER TABLE [dbo].[ItemServico]  WITH CHECK ADD  CONSTRAINT [FK_ItemServico_Venda] FOREIGN KEY([Venda])
REFERENCES [dbo].[Venda] ([Codigo])
GO
ALTER TABLE [dbo].[ItemServico] CHECK CONSTRAINT [FK_ItemServico_Venda]
GO
ALTER TABLE [dbo].[PagamentoVenda]  WITH CHECK ADD  CONSTRAINT [FK_PagamentoVenda_Pagamento] FOREIGN KEY([Pagamento])
REFERENCES [dbo].[Pagamento] ([Codigo])
GO
ALTER TABLE [dbo].[PagamentoVenda] CHECK CONSTRAINT [FK_PagamentoVenda_Pagamento]
GO
ALTER TABLE [dbo].[PagamentoVenda]  WITH CHECK ADD  CONSTRAINT [FK_PagamentoVenda_Venda] FOREIGN KEY([Venda])
REFERENCES [dbo].[Venda] ([Codigo])
GO
ALTER TABLE [dbo].[PagamentoVenda] CHECK CONSTRAINT [FK_PagamentoVenda_Venda]
GO
ALTER TABLE [dbo].[Raca]  WITH CHECK ADD  CONSTRAINT [FK_Raca_Especie] FOREIGN KEY([Especie])
REFERENCES [dbo].[Especie] ([Codigo])
GO
ALTER TABLE [dbo].[Raca] CHECK CONSTRAINT [FK_Raca_Especie]
GO
ALTER TABLE [dbo].[Venda]  WITH CHECK ADD  CONSTRAINT [FK_Venda_Cliente] FOREIGN KEY([Cliente])
REFERENCES [dbo].[Cliente] ([Codigo])
GO
ALTER TABLE [dbo].[Venda] CHECK CONSTRAINT [FK_Venda_Cliente]
GO
ALTER TABLE [dbo].[Venda]  WITH CHECK ADD  CONSTRAINT [FK_Venda_Usuario] FOREIGN KEY([Usuario])
REFERENCES [dbo].[Usuario] ([Codigo])
GO
ALTER TABLE [dbo].[Venda] CHECK CONSTRAINT [FK_Venda_Usuario]
GO
USE [master]
GO
ALTER DATABASE [PetShop] SET  READ_WRITE 
GO
