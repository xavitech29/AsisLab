USE [LAB]
GO
/****** Object:  Table [dbo].[departamento_laboratorio]    Script Date: 31/1/2024 19:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[departamento_laboratorio](
	[id_departamento] [int] IDENTITY(1,1) NOT NULL,
	[nombre_departamento] [nvarchar](100) NULL,
	[descripcion] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_departamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[medico]    Script Date: 31/1/2024 19:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[medico](
	[id_medico] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](100) NULL,
	[apellido] [nvarchar](100) NULL,
	[especialidad] [nvarchar](100) NULL,
	[telefono] [nvarchar](15) NULL,
	[email] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_medico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[muestra]    Script Date: 31/1/2024 19:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[muestra](
	[id_muestra] [int] IDENTITY(1,1) NOT NULL,
	[id_paciente] [int] NULL,
	[id_medico] [int] NULL,
	[id_tipo_prueba] [int] NULL,
	[id_departamento] [int] NULL,
	[fecha_recepcion] [datetime] NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK__muestra__EB1A865ADF7E5B23] PRIMARY KEY CLUSTERED 
(
	[id_muestra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[paciente]    Script Date: 31/1/2024 19:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[paciente](
	[id_paciente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](100) NULL,
	[apellido] [nvarchar](100) NULL,
	[fecha_nacimiento] [date] NULL,
	[genero] [nvarchar](10) NULL,
	[direccion] [nvarchar](255) NULL,
	[telefono] [nvarchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_paciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipo_prueba]    Script Date: 31/1/2024 19:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_prueba](
	[id_tipo_prueba] [int] IDENTITY(1,1) NOT NULL,
	[nombre_tipo_prueba] [nvarchar](100) NULL,
	[descripcion] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipo_prueba] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[muestra]  WITH CHECK ADD  CONSTRAINT [FK__muestra__id_depa__4222D4EF] FOREIGN KEY([id_departamento])
REFERENCES [dbo].[departamento_laboratorio] ([id_departamento])
GO
ALTER TABLE [dbo].[muestra] CHECK CONSTRAINT [FK__muestra__id_depa__4222D4EF]
GO
ALTER TABLE [dbo].[muestra]  WITH CHECK ADD  CONSTRAINT [FK__muestra__id_medi__403A8C7D] FOREIGN KEY([id_medico])
REFERENCES [dbo].[medico] ([id_medico])
GO
ALTER TABLE [dbo].[muestra] CHECK CONSTRAINT [FK__muestra__id_medi__403A8C7D]
GO
ALTER TABLE [dbo].[muestra]  WITH CHECK ADD  CONSTRAINT [FK__muestra__id_paci__3F466844] FOREIGN KEY([id_paciente])
REFERENCES [dbo].[paciente] ([id_paciente])
GO
ALTER TABLE [dbo].[muestra] CHECK CONSTRAINT [FK__muestra__id_paci__3F466844]
GO
ALTER TABLE [dbo].[muestra]  WITH CHECK ADD  CONSTRAINT [FK__muestra__id_tipo__412EB0B6] FOREIGN KEY([id_tipo_prueba])
REFERENCES [dbo].[tipo_prueba] ([id_tipo_prueba])
GO
ALTER TABLE [dbo].[muestra] CHECK CONSTRAINT [FK__muestra__id_tipo__412EB0B6]
GO
