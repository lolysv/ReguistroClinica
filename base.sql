USE [BD_CLINICA]
GO
/****** Object:  Table [dbo].[DIAGNOSTICO]    Script Date: 02/12/2017 19:40:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DIAGNOSTICO](
	[ID_PACIENTE1] [int] NULL,
	[DESCRIPCION_DIAGNOSTICO] [varchar](500) NULL,
	[ID_DIAGNOSTICO] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ORGANIZAR_HORARIO_DOCTOR]    Script Date: 02/12/2017 19:40:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ORGANIZAR_HORARIO_DOCTOR](
	[ID_USUARIO2] [int] NULL,
	[DIAS] [varchar](100) NULL,
	[HORARIO] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PACIENTE]    Script Date: 02/12/2017 19:40:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PACIENTE](
	[ID_PACIENTE] [int] IDENTITY(1,1) NOT NULL,
	[DUI_PAC] [varchar](10) NULL,
	[NOMBRE_PAC] [varchar](100) NULL,
	[APELLIDO_PAC] [varchar](100) NULL,
	[DIRECCION] [varchar](150) NULL,
	[FECHA_NAC_PAC] [date] NULL,
	[EDAD] [int] NULL,
	[SEXO] [varchar](1) NULL,
	[TELEFONO] [varchar](15) NULL,
	[CARNET] [varchar](10) NULL,
	[USUARIO_PAC] [varchar](75) NULL,
	[CONTRA_PAC] [varchar](75) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_PACIENTE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[REGISTRO_CITA]    Script Date: 02/12/2017 19:40:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[REGISTRO_CITA](
	[ID_REGISTRO] [int] IDENTITY(1,1) NOT NULL,
	[DUI] [varchar](10) NULL,
	[DOCTOR] [varchar](250) NULL,
	[FECHA_CITA] [date] NULL,
	[HORA_CITA] [time](7) NULL,
	[ID_USUARIO1] [int] NULL,
	[ID_PACIENTE2] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_REGISTRO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[USUARIO]    Script Date: 02/12/2017 19:40:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[USUARIO](
	[ID_USUARIO] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE_USUARIO] [varchar](100) NULL,
	[APELLIDO_USUARIO] [varchar](150) NULL,
	[TIPO_USUARIO] [varchar](50) NULL,
	[NUMERO_DE_JUNTA] [varchar](15) NULL,
	[USUARIO_ADMIN] [varchar](75) NULL,
	[CONTRA_ADMIN] [varchar](75) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_USUARIO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[DIAGNOSTICO]  WITH CHECK ADD  CONSTRAINT [FK_DIAG_PAC] FOREIGN KEY([ID_PACIENTE1])
REFERENCES [dbo].[PACIENTE] ([ID_PACIENTE])
GO
ALTER TABLE [dbo].[DIAGNOSTICO] CHECK CONSTRAINT [FK_DIAG_PAC]
GO
ALTER TABLE [dbo].[ORGANIZAR_HORARIO_DOCTOR]  WITH CHECK ADD  CONSTRAINT [FK_OGH_USU] FOREIGN KEY([ID_USUARIO2])
REFERENCES [dbo].[USUARIO] ([ID_USUARIO])
GO
ALTER TABLE [dbo].[ORGANIZAR_HORARIO_DOCTOR] CHECK CONSTRAINT [FK_OGH_USU]
GO
ALTER TABLE [dbo].[REGISTRO_CITA]  WITH CHECK ADD  CONSTRAINT [FK_REGC_PAC] FOREIGN KEY([ID_PACIENTE2])
REFERENCES [dbo].[PACIENTE] ([ID_PACIENTE])
GO
ALTER TABLE [dbo].[REGISTRO_CITA] CHECK CONSTRAINT [FK_REGC_PAC]
GO
ALTER TABLE [dbo].[REGISTRO_CITA]  WITH CHECK ADD  CONSTRAINT [FK_REGC_USU] FOREIGN KEY([ID_USUARIO1])
REFERENCES [dbo].[USUARIO] ([ID_USUARIO])
GO
ALTER TABLE [dbo].[REGISTRO_CITA] CHECK CONSTRAINT [FK_REGC_USU]
GO
