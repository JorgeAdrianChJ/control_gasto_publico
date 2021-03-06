USE [control_gasto_publico]
GO
/****** Object:  Table [dbo].[Servicio]    Script Date: 11/07/2022 11:34:21 a. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Servicio]') AND type in (N'U'))
DROP TABLE [dbo].[Servicio]
GO
/****** Object:  Table [dbo].[Edificio]    Script Date: 11/07/2022 11:34:21 a. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Edificio]') AND type in (N'U'))
DROP TABLE [dbo].[Edificio]
GO
/****** Object:  Table [dbo].[Agregar_Servicio]    Script Date: 11/07/2022 11:34:21 a. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Agregar_Servicio]') AND type in (N'U'))
DROP TABLE [dbo].[Agregar_Servicio]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 11/07/2022 11:34:21 a. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[__EFMigrationsHistory]') AND type in (N'U'))
DROP TABLE [dbo].[__EFMigrationsHistory]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 11/07/2022 11:34:21 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Agregar_Servicio]    Script Date: 11/07/2022 11:34:21 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Agregar_Servicio](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_edificio] [int] NOT NULL,
	[id_servicio] [int] NOT NULL,
	[fecha_servicio] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Agregar_Servicio] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Edificio]    Script Date: 11/07/2022 11:34:21 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Edificio](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](max) NOT NULL,
	[cantidad_personas] [int] NOT NULL,
	[fecha_alquiler] [datetime2](7) NOT NULL,
	[id_provincia] [int] NOT NULL,
	[id_canton] [int] NOT NULL,
	[id_destrito] [int] NOT NULL,
	[tipo_edificio] [int] NOT NULL,
	[fecha_final_alquiler] [datetime2](7) NULL,
 CONSTRAINT [PK_Edificio] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servicio]    Script Date: 11/07/2022 11:34:21 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicio](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[nombre_empresa] [nvarchar](50) NOT NULL,
	[tipo_servicio_id] [int] NOT NULL,
	[unidad_medida_id] [int] NOT NULL,
 CONSTRAINT [PK_Servicio] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220704060528_init', N'6.0.6')
GO
SET IDENTITY_INSERT [dbo].[Agregar_Servicio] ON 

INSERT [dbo].[Agregar_Servicio] ([id], [id_edificio], [id_servicio], [fecha_servicio]) VALUES (1, 1, 1, CAST(N'2002-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Agregar_Servicio] ([id], [id_edificio], [id_servicio], [fecha_servicio]) VALUES (2, 4, 1, CAST(N'0001-01-03T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Agregar_Servicio] ([id], [id_edificio], [id_servicio], [fecha_servicio]) VALUES (4, 4, 3, CAST(N'0001-01-10T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Agregar_Servicio] ([id], [id_edificio], [id_servicio], [fecha_servicio]) VALUES (5, 4, 0, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Agregar_Servicio] ([id], [id_edificio], [id_servicio], [fecha_servicio]) VALUES (6, 4, 0, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Agregar_Servicio] ([id], [id_edificio], [id_servicio], [fecha_servicio]) VALUES (7, 4, 4, CAST(N'0001-01-11T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Agregar_Servicio] OFF
GO
SET IDENTITY_INSERT [dbo].[Edificio] ON 

INSERT [dbo].[Edificio] ([id], [nombre], [cantidad_personas], [fecha_alquiler], [id_provincia], [id_canton], [id_destrito], [tipo_edificio], [fecha_final_alquiler]) VALUES (1, N'AA2', 32, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 2, 1, 1, 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Edificio] ([id], [nombre], [cantidad_personas], [fecha_alquiler], [id_provincia], [id_canton], [id_destrito], [tipo_edificio], [fecha_final_alquiler]) VALUES (2, N'BB3', 21, CAST(N'2022-07-06T00:00:00.0000000' AS DateTime2), 1, 1, 1, 1, NULL)
INSERT [dbo].[Edificio] ([id], [nombre], [cantidad_personas], [fecha_alquiler], [id_provincia], [id_canton], [id_destrito], [tipo_edificio], [fecha_final_alquiler]) VALUES (3, N'w12', 12, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1, 1, 1, 1, NULL)
INSERT [dbo].[Edificio] ([id], [nombre], [cantidad_personas], [fecha_alquiler], [id_provincia], [id_canton], [id_destrito], [tipo_edificio], [fecha_final_alquiler]) VALUES (4, N'SD123', 12, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1, 1, 1, 2, CAST(N'2022-07-12T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Edificio] OFF
GO
SET IDENTITY_INSERT [dbo].[Servicio] ON 

INSERT [dbo].[Servicio] ([id], [nombre], [nombre_empresa], [tipo_servicio_id], [unidad_medida_id]) VALUES (1, N'ICE', N'ICE', 2, 2)
INSERT [dbo].[Servicio] ([id], [nombre], [nombre_empresa], [tipo_servicio_id], [unidad_medida_id]) VALUES (3, N'AYA', N'AYA', 1, 3)
INSERT [dbo].[Servicio] ([id], [nombre], [nombre_empresa], [tipo_servicio_id], [unidad_medida_id]) VALUES (4, N'Kolbi', N'Kolbi', 3, 4)
SET IDENTITY_INSERT [dbo].[Servicio] OFF
GO
