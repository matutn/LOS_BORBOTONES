USE [GD2C2013]
GO

/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_Diagnostico]    Script Date: 12/04/2013 22:21:32 ******/
DROP PROCEDURE [LOS_BORBOTONES].[Llenar_Diagnostico]
GO
/****** Object:  View [LOS_BORBOTONES].[vw_BonoFarmacia_Especialidad]    Script Date: 12/04/2013 22:21:31 ******/
DROP VIEW [LOS_BORBOTONES].[vw_BonoFarmacia_Especialidad]
GO
/****** Object:  Table [LOS_BORBOTONES].[Diagnostico]    Script Date: 12/04/2013 22:21:28 ******/
ALTER TABLE [LOS_BORBOTONES].[Diagnostico] DROP CONSTRAINT [FK_Diagnostico_Consulta]
GO
ALTER TABLE [LOS_BORBOTONES].[Diagnostico] DROP CONSTRAINT [FK_Diagnostico_Receta]
GO
DROP TABLE [LOS_BORBOTONES].[Diagnostico]
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_Consulta]    Script Date: 12/04/2013 22:21:32 ******/
DROP PROCEDURE [LOS_BORBOTONES].[Llenar_Consulta]
GO
/****** Object:  View [LOS_BORBOTONES].[vw_Bonos_Afiliado]    Script Date: 12/04/2013 22:21:31 ******/
DROP VIEW [LOS_BORBOTONES].[vw_Bonos_Afiliado]
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_Especialidad]    Script Date: 12/04/2013 22:21:32 ******/
DROP PROCEDURE [LOS_BORBOTONES].[Llenar_Especialidad]
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_Dias]    Script Date: 12/04/2013 22:21:32 ******/
DROP PROCEDURE [LOS_BORBOTONES].[Llenar_Dias]
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_Medicamento]    Script Date: 12/04/2013 22:21:32 ******/
DROP PROCEDURE [LOS_BORBOTONES].[Llenar_Medicamento]
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_PlanMedico]    Script Date: 12/04/2013 22:21:32 ******/
DROP PROCEDURE [LOS_BORBOTONES].[Llenar_PlanMedico]
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_Clinica]    Script Date: 12/04/2013 22:21:32 ******/
DROP PROCEDURE [LOS_BORBOTONES].[Llenar_Clinica]
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Crear_Usuarios]    Script Date: 12/04/2013 22:21:32 ******/
DROP PROCEDURE [LOS_BORBOTONES].[Crear_Usuarios]
GO
/****** Object:  View [LOS_BORBOTONES].[vw_cancelaciones_especialidad]    Script Date: 12/04/2013 22:21:31 ******/
DROP VIEW [LOS_BORBOTONES].[vw_cancelaciones_especialidad]
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Cargar_BonoConsulta]    Script Date: 12/04/2013 22:21:32 ******/
DROP PROCEDURE [LOS_BORBOTONES].[Cargar_BonoConsulta]
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Cargar_BonoFarmacia]    Script Date: 12/04/2013 22:21:32 ******/
DROP PROCEDURE [LOS_BORBOTONES].[Cargar_BonoFarmacia]
GO
/****** Object:  View [LOS_BORBOTONES].[vw_BonosVencidos]    Script Date: 12/04/2013 22:21:31 ******/
DROP VIEW [LOS_BORBOTONES].[vw_BonosVencidos]
GO
/****** Object:  Table [LOS_BORBOTONES].[Bono_Farmacia]    Script Date: 12/04/2013 22:21:28 ******/
ALTER TABLE [LOS_BORBOTONES].[Bono_Farmacia] DROP CONSTRAINT [FK_Bono_Farmacia_Compra_Bono]
GO
ALTER TABLE [LOS_BORBOTONES].[Bono_Farmacia] DROP CONSTRAINT [FK_Bono_Farmacia_Receta]
GO
DROP TABLE [LOS_BORBOTONES].[Bono_Farmacia]
GO
/****** Object:  Table [LOS_BORBOTONES].[Cancelacion]    Script Date: 12/04/2013 22:21:28 ******/
ALTER TABLE [LOS_BORBOTONES].[Cancelacion] DROP CONSTRAINT [FK_Cancelacion_TipoCancelacion]
GO
DROP TABLE [LOS_BORBOTONES].[Cancelacion]
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_EstadoCivil]    Script Date: 12/04/2013 22:21:32 ******/
DROP PROCEDURE [LOS_BORBOTONES].[Llenar_EstadoCivil]
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_Funcionalidad]    Script Date: 12/04/2013 22:21:32 ******/
DROP PROCEDURE [LOS_BORBOTONES].[Llenar_Funcionalidad]
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_Tipo_Especialidad]    Script Date: 12/04/2013 22:21:32 ******/
DROP PROCEDURE [LOS_BORBOTONES].[Llenar_Tipo_Especialidad]
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_TipoCancelacion]    Script Date: 12/04/2013 22:21:32 ******/
DROP PROCEDURE [LOS_BORBOTONES].[Llenar_TipoCancelacion]
GO
/****** Object:  Table [LOS_BORBOTONES].[Medicamento_Receta]    Script Date: 12/04/2013 22:21:29 ******/
ALTER TABLE [LOS_BORBOTONES].[Medicamento_Receta] DROP CONSTRAINT [FK_Medicamento_Receta_Medicamento]
GO
ALTER TABLE [LOS_BORBOTONES].[Medicamento_Receta] DROP CONSTRAINT [FK_Medicamento_Receta_Receta]
GO
DROP TABLE [LOS_BORBOTONES].[Medicamento_Receta]
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_Compra_Bono]    Script Date: 12/04/2013 22:21:32 ******/
DROP PROCEDURE [LOS_BORBOTONES].[Llenar_Compra_Bono]
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_Agenda]    Script Date: 12/04/2013 22:21:32 ******/
DROP PROCEDURE [LOS_BORBOTONES].[Llenar_Agenda]
GO
/****** Object:  View [dbo].[proximos120dias]    Script Date: 12/04/2013 22:21:31 ******/
DROP VIEW [dbo].[proximos120dias]
GO
/****** Object:  Table [LOS_BORBOTONES].[Receta]    Script Date: 12/04/2013 22:21:29 ******/
DROP TABLE [LOS_BORBOTONES].[Receta]
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_Afiliado]    Script Date: 12/04/2013 22:21:32 ******/
DROP PROCEDURE [LOS_BORBOTONES].[Llenar_Afiliado]
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_Especialidad_Profesional]    Script Date: 12/04/2013 22:21:32 ******/
DROP PROCEDURE [LOS_BORBOTONES].[Llenar_Especialidad_Profesional]
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_Historial]    Script Date: 12/04/2013 22:21:32 ******/
DROP PROCEDURE [LOS_BORBOTONES].[Llenar_Historial]
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_Profesional]    Script Date: 12/04/2013 22:21:32 ******/
DROP PROCEDURE [LOS_BORBOTONES].[Llenar_Profesional]
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_Turno]    Script Date: 12/04/2013 22:21:32 ******/
DROP PROCEDURE [LOS_BORBOTONES].[Llenar_Turno]
GO
/****** Object:  View [dbo].[vw_agenda]    Script Date: 12/04/2013 22:21:31 ******/
DROP VIEW [dbo].[vw_agenda]
GO
/****** Object:  Table [LOS_BORBOTONES].[Medicamento]    Script Date: 12/04/2013 22:21:29 ******/
DROP TABLE [LOS_BORBOTONES].[Medicamento]
GO
/****** Object:  Table [LOS_BORBOTONES].[TipoCancelacion]    Script Date: 12/04/2013 22:21:30 ******/
DROP TABLE [LOS_BORBOTONES].[TipoCancelacion]
GO
/****** Object:  Table [LOS_BORBOTONES].[Cancelacion_Turno]    Script Date: 12/04/2013 22:21:28 ******/
DROP TABLE [LOS_BORBOTONES].[Cancelacion_Turno]
GO
/****** Object:  Table [LOS_BORBOTONES].[Clinica]    Script Date: 12/04/2013 22:21:28 ******/
DROP TABLE [LOS_BORBOTONES].[Clinica]
GO
/****** Object:  Table [LOS_BORBOTONES].[Especialidad_Profesional]    Script Date: 12/04/2013 22:21:29 ******/
DROP TABLE [LOS_BORBOTONES].[Especialidad_Profesional]
GO
/****** Object:  Table [LOS_BORBOTONES].[Dia]    Script Date: 12/04/2013 22:21:28 ******/
DROP TABLE [LOS_BORBOTONES].[Dia]
GO
/****** Object:  Table [LOS_BORBOTONES].[Historial]    Script Date: 12/04/2013 22:21:29 ******/
ALTER TABLE [LOS_BORBOTONES].[Historial] DROP CONSTRAINT [FK_Historial_Afiliado]
GO
DROP TABLE [LOS_BORBOTONES].[Historial]
GO
/****** Object:  Table [LOS_BORBOTONES].[Afiliado]    Script Date: 12/04/2013 22:21:28 ******/
ALTER TABLE [LOS_BORBOTONES].[Afiliado] DROP CONSTRAINT [FK_Afiliado_Usuario]
GO
ALTER TABLE [LOS_BORBOTONES].[Afiliado] DROP CONSTRAINT [FK_EstadoCivil]
GO
ALTER TABLE [LOS_BORBOTONES].[Afiliado] DROP CONSTRAINT [FK_IdPlan]
GO
ALTER TABLE [LOS_BORBOTONES].[Afiliado] DROP CONSTRAINT [DF__Afiliado__afi_Es__7F985988]
GO
DROP TABLE [LOS_BORBOTONES].[Afiliado]
GO
/****** Object:  Table [LOS_BORBOTONES].[Turno]    Script Date: 12/04/2013 22:21:30 ******/
ALTER TABLE [LOS_BORBOTONES].[Turno] DROP CONSTRAINT [FK_Turno_Afiliado]
GO
ALTER TABLE [LOS_BORBOTONES].[Turno] DROP CONSTRAINT [FK_Turno_Consulta]
GO
ALTER TABLE [LOS_BORBOTONES].[Turno] DROP CONSTRAINT [FK_Turno_Especialidad]
GO
ALTER TABLE [LOS_BORBOTONES].[Turno] DROP CONSTRAINT [FK_Turno_Profesional]
GO
DROP TABLE [LOS_BORBOTONES].[Turno]
GO
/****** Object:  Table [LOS_BORBOTONES].[Profesional]    Script Date: 12/04/2013 22:21:29 ******/
ALTER TABLE [LOS_BORBOTONES].[Profesional] DROP CONSTRAINT [FK_Profesional_Usuario]
GO
ALTER TABLE [LOS_BORBOTONES].[Profesional] DROP CONSTRAINT [DF_PROFESIONAL_prof_Matricula]
GO
ALTER TABLE [LOS_BORBOTONES].[Profesional] DROP CONSTRAINT [DF_PROFESIONAL_prof_Sexo]
GO
ALTER TABLE [LOS_BORBOTONES].[Profesional] DROP CONSTRAINT [DF__Profesion__prof___10C2E58A]
GO
DROP TABLE [LOS_BORBOTONES].[Profesional]
GO
/****** Object:  Table [LOS_BORBOTONES].[Especialidad]    Script Date: 12/04/2013 22:21:29 ******/
ALTER TABLE [LOS_BORBOTONES].[Especialidad] DROP CONSTRAINT [FK_Especialidad_TipoEspecialidad]
GO
DROP TABLE [LOS_BORBOTONES].[Especialidad]
GO
/****** Object:  Table [LOS_BORBOTONES].[Tipo_Especialidad]    Script Date: 12/04/2013 22:21:30 ******/
DROP TABLE [LOS_BORBOTONES].[Tipo_Especialidad]
GO
/****** Object:  Table [LOS_BORBOTONES].[Consulta]    Script Date: 12/04/2013 22:21:28 ******/
ALTER TABLE [LOS_BORBOTONES].[Consulta] DROP CONSTRAINT [FK_Consulta_Bono_Consulta]
GO
DROP TABLE [LOS_BORBOTONES].[Consulta]
GO
/****** Object:  Table [LOS_BORBOTONES].[Bono_Consulta]    Script Date: 12/04/2013 22:21:28 ******/
ALTER TABLE [LOS_BORBOTONES].[Bono_Consulta] DROP CONSTRAINT [FK_IdCompra]
GO
ALTER TABLE [LOS_BORBOTONES].[Bono_Consulta] DROP CONSTRAINT [DF__Bono_Cons__boco___07397B50]
GO
DROP TABLE [LOS_BORBOTONES].[Bono_Consulta]
GO
/****** Object:  Table [LOS_BORBOTONES].[Compra_Bono]    Script Date: 12/04/2013 22:21:28 ******/
DROP TABLE [LOS_BORBOTONES].[Compra_Bono]
GO
/****** Object:  Table [LOS_BORBOTONES].[EstadoCivil]    Script Date: 12/04/2013 22:21:29 ******/
DROP TABLE [LOS_BORBOTONES].[EstadoCivil]
GO
/****** Object:  Table [LOS_BORBOTONES].[Plan_Medico]    Script Date: 12/04/2013 22:21:29 ******/
DROP TABLE [LOS_BORBOTONES].[Plan_Medico]
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_Rol]    Script Date: 12/04/2013 22:21:32 ******/
DROP PROCEDURE [LOS_BORBOTONES].[Llenar_Rol]
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_Rol_Usuario]    Script Date: 12/04/2013 22:21:32 ******/
DROP PROCEDURE [LOS_BORBOTONES].[Llenar_Rol_Usuario]
GO
/****** Object:  Table [LOS_BORBOTONES].[Rol_Usuario]    Script Date: 12/04/2013 22:21:29 ******/
ALTER TABLE [LOS_BORBOTONES].[Rol_Usuario] DROP CONSTRAINT [FK_Rol_Usuario_Rol]
GO
ALTER TABLE [LOS_BORBOTONES].[Rol_Usuario] DROP CONSTRAINT [FK_Rol_Usuario_Rol_Usuario]
GO
DROP TABLE [LOS_BORBOTONES].[Rol_Usuario]
GO
/****** Object:  Table [LOS_BORBOTONES].[Usuario]    Script Date: 12/04/2013 22:21:30 ******/
DROP TABLE [LOS_BORBOTONES].[Usuario]
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Relacionar_FuncionalidadesRol]    Script Date: 12/04/2013 22:21:32 ******/
DROP PROCEDURE [LOS_BORBOTONES].[Relacionar_FuncionalidadesRol]
GO
/****** Object:  Table [LOS_BORBOTONES].[Func_Rol]    Script Date: 12/04/2013 22:21:29 ******/
ALTER TABLE [LOS_BORBOTONES].[Func_Rol] DROP CONSTRAINT [FK_Func_Rol_Funcionalidad]
GO
ALTER TABLE [LOS_BORBOTONES].[Func_Rol] DROP CONSTRAINT [FK_Func_Rol_Rol]
GO
DROP TABLE [LOS_BORBOTONES].[Func_Rol]
GO
/****** Object:  Table [LOS_BORBOTONES].[Funcionalidad]    Script Date: 12/04/2013 22:21:29 ******/
DROP TABLE [LOS_BORBOTONES].[Funcionalidad]
GO
/****** Object:  Table [LOS_BORBOTONES].[Agenda]    Script Date: 12/04/2013 22:21:28 ******/
ALTER TABLE [LOS_BORBOTONES].[Agenda] DROP CONSTRAINT [DF__Agenda__age_Esta__303B90E3]
GO
DROP TABLE [LOS_BORBOTONES].[Agenda]
GO
/****** Object:  Table [LOS_BORBOTONES].[Rol]    Script Date: 12/04/2013 22:21:29 ******/
ALTER TABLE [LOS_BORBOTONES].[Rol] DROP CONSTRAINT [DF__Rol__rol_Estado__6207F6A1]
GO
DROP TABLE [LOS_BORBOTONES].[Rol]
GO
/****** Object:  Schema [LOS_BORBOTONES]    Script Date: 12/04/2013 22:21:32 ******/
DROP SCHEMA [LOS_BORBOTONES]
GO
/****** Object:  Schema [LOS_BORBOTONES]    Script Date: 12/04/2013 22:21:32 ******/
CREATE SCHEMA [LOS_BORBOTONES] AUTHORIZATION [dbo]
GO
/****** Object:  Table [LOS_BORBOTONES].[Rol]    Script Date: 12/04/2013 22:21:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [LOS_BORBOTONES].[Rol](
	[rol_CodRol] [int] IDENTITY(1,1) NOT NULL,
	[rol_nombre] [varchar](15) NULL,
	[rol_Estado] [bit] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[rol_CodRol] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [LOS_BORBOTONES].[Agenda]    Script Date: 12/04/2013 22:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_BORBOTONES].[Agenda](
	[age_IdAgenda] [int] IDENTITY(1,1) NOT NULL,
	[age_IdProfesional] [int] NOT NULL,
	[age_Especialidad] [int] NOT NULL,
	[age_IdDia] [int] NOT NULL,
	[age_Fecha] [datetime] NOT NULL,
	[age_HoraComienzo] [int] NULL,
	[age_MinutoComienzo] [int] NULL,
	[age_HorarioFin] [int] NULL,
	[age_MinutoFin] [int] NULL,
	[age_Estado] [bit] NULL DEFAULT ((0)),
 CONSTRAINT [PK_Agenda] PRIMARY KEY CLUSTERED 
(
	[age_IdAgenda] ASC,
	[age_IdProfesional] ASC,
	[age_Especialidad] ASC,
	[age_Fecha] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_BORBOTONES].[Funcionalidad]    Script Date: 12/04/2013 22:21:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [LOS_BORBOTONES].[Funcionalidad](
	[fun_CodFuncionalidad] [int] IDENTITY(1,1) NOT NULL,
	[fun_Descripcion] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[fun_CodFuncionalidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [LOS_BORBOTONES].[Func_Rol]    Script Date: 12/04/2013 22:21:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_BORBOTONES].[Func_Rol](
	[furo_CodRol] [int] NOT NULL,
	[furo_CodFuncionalidad] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[furo_CodRol] ASC,
	[furo_CodFuncionalidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Relacionar_FuncionalidadesRol]    Script Date: 12/04/2013 22:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*Relacionar funcionalidades con sus respectivos roles*/
CREATE PROCEDURE [LOS_BORBOTONES].[Relacionar_FuncionalidadesRol] 
	
AS
BEGIN

	SET NOCOUNT ON;

INSERT [LOS_BORBOTONES].[Func_Rol] ( [furo_CodRol], [furo_CodFuncionalidad]) VALUES (8, 1)
INSERT [LOS_BORBOTONES].[Func_Rol] ( [furo_CodRol], [furo_CodFuncionalidad]) VALUES (8, 2)
INSERT [LOS_BORBOTONES].[Func_Rol] ( [furo_CodRol], [furo_CodFuncionalidad]) VALUES (8, 3)
INSERT [LOS_BORBOTONES].[Func_Rol] ( [furo_CodRol], [furo_CodFuncionalidad]) VALUES (8, 4)
INSERT [LOS_BORBOTONES].[Func_Rol] ( [furo_CodRol], [furo_CodFuncionalidad]) VALUES (8, 5)
INSERT [LOS_BORBOTONES].[Func_Rol] ( [furo_CodRol], [furo_CodFuncionalidad]) VALUES (8, 6)
INSERT [LOS_BORBOTONES].[Func_Rol] ( [furo_CodRol], [furo_CodFuncionalidad]) VALUES (8, 7)
INSERT [LOS_BORBOTONES].[Func_Rol] ( [furo_CodRol], [furo_CodFuncionalidad]) VALUES (8, 8)
INSERT [LOS_BORBOTONES].[Func_Rol] ( [furo_CodRol], [furo_CodFuncionalidad]) VALUES (8, 9)
INSERT [LOS_BORBOTONES].[Func_Rol] ( [furo_CodRol], [furo_CodFuncionalidad]) VALUES (8, 10)
INSERT [LOS_BORBOTONES].[Func_Rol] ( [furo_CodRol], [furo_CodFuncionalidad]) VALUES (8, 11)
INSERT [LOS_BORBOTONES].[Func_Rol] ( [furo_CodRol], [furo_CodFuncionalidad]) VALUES (8, 12)
INSERT [LOS_BORBOTONES].[Func_Rol] ( [furo_CodRol], [furo_CodFuncionalidad]) VALUES (8, 13)

END
GO
/****** Object:  Table [LOS_BORBOTONES].[Usuario]    Script Date: 12/04/2013 22:21:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [LOS_BORBOTONES].[Usuario](
	[usu_IdUsuario] [varchar](10) NOT NULL,
	[usu_Password] [varchar](max) NULL,
	[usu_IntentosFallidos] [int] NULL,
	[usu_FechaBaja] [datetime] NULL,
	[usu_Estado] [bit] NULL,
 CONSTRAINT [PK__Usuario__D09E98FF009FF5AC] PRIMARY KEY CLUSTERED 
(
	[usu_IdUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [LOS_BORBOTONES].[Rol_Usuario]    Script Date: 12/04/2013 22:21:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [LOS_BORBOTONES].[Rol_Usuario](
	[rous_IdUsuario] [varchar](10) NOT NULL,
	[rous_CodRol] [int] NULL,
	[rous_Estado] [bit] NULL,
 CONSTRAINT [PK__Rol_Usua__8428DA892859ACA2] PRIMARY KEY CLUSTERED 
(
	[rous_IdUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_Rol_Usuario]    Script Date: 12/04/2013 22:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [LOS_BORBOTONES].[Llenar_Rol_Usuario] 
	
AS
BEGIN

/*SET IDENTITY_INSERT LOS_BORBOTONES.Rol ON */
INSERT INTO LOS_BORBOTONES.Rol_Usuario  ([rous_IdUsuario], [rous_CodRol], [rous_Estado]) VALUES (N'admin', 8, 0) 

/*SET IDENTITY_INSERT LOS_BORBOTONES.Rol OFF */

END
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_Rol]    Script Date: 12/04/2013 22:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [LOS_BORBOTONES].[Llenar_Rol] 
	
AS
BEGIN

SET IDENTITY_INSERT LOS_BORBOTONES.Rol ON
INSERT [LOS_BORBOTONES].[Rol] ([rol_CodRol], [rol_nombre]) VALUES (15, N'Afiliado') /*VER SI HAY QUE PONERLE UN ESTADO AL ROL*/
INSERT [LOS_BORBOTONES].[Rol] ([rol_CodRol], [rol_nombre]) VALUES (8, N'Administrativo')
INSERT [LOS_BORBOTONES].[Rol] ([rol_CodRol], [rol_nombre]) VALUES (18, N'Profesional')
SET IDENTITY_INSERT LOS_BORBOTONES.Rol OFF

END
GO
/****** Object:  Table [LOS_BORBOTONES].[Plan_Medico]    Script Date: 12/04/2013 22:21:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [LOS_BORBOTONES].[Plan_Medico](
	[plan_IdPlan] [numeric](18, 0) NOT NULL,
	[plan_Descripcion] [varchar](255) NULL,
	[plan_PrecioBC] [numeric](18, 0) NULL,
	[plan_PrecioBF] [numeric](18, 0) NULL,
 CONSTRAINT [PK_PlanMedico] PRIMARY KEY CLUSTERED 
(
	[plan_IdPlan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [LOS_BORBOTONES].[EstadoCivil]    Script Date: 12/04/2013 22:21:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [LOS_BORBOTONES].[EstadoCivil](
	[esci_CodEcivil] [int] NOT NULL,
	[esci_Descripcion] [varchar](255) NULL,
 CONSTRAINT [PK_EstadoCivil] PRIMARY KEY CLUSTERED 
(
	[esci_CodEcivil] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [LOS_BORBOTONES].[Compra_Bono]    Script Date: 12/04/2013 22:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_BORBOTONES].[Compra_Bono](
	[cobo_IdCompra] [int] IDENTITY(1,1) NOT NULL,
	[cobo_IdAfi] [int] NULL,
	[cobo_CantBC] [numeric](18, 0) NULL,
	[cobo_CantBF] [numeric](18, 0) NULL,
	[cobo_MontoTotal] [numeric](18, 0) NULL,
	[cobo_FechaCompra] [datetime] NULL,
 CONSTRAINT [PK_CompraBono] PRIMARY KEY CLUSTERED 
(
	[cobo_IdCompra] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_BORBOTONES].[Bono_Consulta]    Script Date: 12/04/2013 22:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_BORBOTONES].[Bono_Consulta](
	[boco_IdBonoConsulta] [numeric](18, 0) NOT NULL,
	[boco_IdCompra] [int] NULL,
	[boco_FechaImpresion] [datetime] NULL,
	[boco_IdAfiliado] [int] NULL,
	[boco_ConsultasAfiliado] [int] IDENTITY(1,1) NOT NULL,
	[boco_IdPlan] [numeric](18, 0) NULL,
	[boco_Estado] [bit] NULL DEFAULT ((0)),
 CONSTRAINT [PK_BonoConsulta] PRIMARY KEY CLUSTERED 
(
	[boco_IdBonoConsulta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_BORBOTONES].[Consulta]    Script Date: 12/04/2013 22:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [LOS_BORBOTONES].[Consulta](
	[con_IdConsulta] [int] IDENTITY(1,1) NOT NULL,
	[con_IdBonoConsulta] [numeric](18, 0) NULL,
	[con_FechaLlegada] [datetime] NULL,
	[con_Sintomas] [varchar](255) NULL,
 CONSTRAINT [PK_Consulta] PRIMARY KEY CLUSTERED 
(
	[con_IdConsulta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [LOS_BORBOTONES].[Tipo_Especialidad]    Script Date: 12/04/2013 22:21:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [LOS_BORBOTONES].[Tipo_Especialidad](
	[ties_CodTipo] [numeric](18, 0) NOT NULL,
	[ties_Descripcion] [varchar](255) NOT NULL,
 CONSTRAINT [PK_TIPO_ESPECIALIDAD] PRIMARY KEY CLUSTERED 
(
	[ties_CodTipo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [LOS_BORBOTONES].[Especialidad]    Script Date: 12/04/2013 22:21:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [LOS_BORBOTONES].[Especialidad](
	[esp_CodEspecialidad] [int] NOT NULL,
	[esp_Descripcion] [varchar](255) NULL,
	[esp_TipoEspecialidad] [numeric](18, 0) NULL,
 CONSTRAINT [PK_ESPECIALIDAD] PRIMARY KEY CLUSTERED 
(
	[esp_CodEspecialidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [LOS_BORBOTONES].[Profesional]    Script Date: 12/04/2013 22:21:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [LOS_BORBOTONES].[Profesional](
	[prof_IdProfesional] [int] IDENTITY(1,1) NOT NULL,
	[prof_Nombre] [varchar](255) NULL,
	[prof_Matricula] [int] NULL CONSTRAINT [DF_PROFESIONAL_prof_Matricula]  DEFAULT (''),
	[prof_TipoDni] [char](3) NULL,
	[prof_Dni] [numeric](18, 0) NULL,
	[prof_Direccion] [varchar](255) NULL,
	[prof_Telefono] [numeric](18, 0) NULL,
	[prof_Mail] [varchar](50) NULL,
	[prof_FechaNacimiento] [datetime] NULL,
	[prof_Sexo] [char](1) NULL CONSTRAINT [DF_PROFESIONAL_prof_Sexo]  DEFAULT (''),
	[prof_NombreUsuario] [varchar](10) NULL,
	[prof_Apellido] [nchar](255) NULL,
	[prof_Estado] [bit] NULL DEFAULT ((0)),
 CONSTRAINT [PK_PROFESIONAL] PRIMARY KEY CLUSTERED 
(
	[prof_IdProfesional] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [LOS_BORBOTONES].[Turno]    Script Date: 12/04/2013 22:21:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_BORBOTONES].[Turno](
	[tur_IdTurno] [int] IDENTITY(1,1) NOT NULL,
	[tur_IdProf] [int] NULL,
	[tur_IdAfi] [int] NULL,
	[tur_IdConsulta] [int] NULL,
	[tur_Especialidad] [int] NULL,
	[tur_Fecha] [datetime] NULL,
	[tur_Estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[tur_IdTurno] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_BORBOTONES].[Afiliado]    Script Date: 12/04/2013 22:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [LOS_BORBOTONES].[Afiliado](
	[afi_IdAfiliado] [int] IDENTITY(1,1) NOT NULL,
	[afi_IdPlan] [numeric](18, 0) NULL,
	[afi_NombreUsuario] [varchar](10) NULL,
	[afi_EstadoCivil] [int] NULL,
	[afi_CantPersonas] [int] NULL,
	[afi_Estado] [bit] NULL DEFAULT ((0)),
	[afi_Nombre] [varchar](255) NULL,
	[afi_Apellido] [varchar](255) NULL,
	[afi_TipoDni] [char](3) NULL,
	[afi_Dni] [numeric](18, 0) NULL,
	[afi_Direccion] [varchar](255) NULL,
	[afi_Telefono] [numeric](18, 0) NULL,
	[afi_Mail] [varchar](255) NULL,
	[afi_FechaNacimiento] [datetime] NULL,
	[afi_Sexo] [char](1) NULL,
	[afi_CantidadConsultas] [int] NULL,
 CONSTRAINT [PK_Afiliado] PRIMARY KEY CLUSTERED 
(
	[afi_IdAfiliado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [LOS_BORBOTONES].[Historial]    Script Date: 12/04/2013 22:21:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [LOS_BORBOTONES].[Historial](
	[hist_IdAfiliado] [int] NOT NULL,
	[hist_PlanActual] [numeric](18, 0) NULL,
	[hist_PlanAnterior] [numeric](18, 0) NULL,
	[hist_Fecha] [datetime] NULL,
	[hist_Motivo] [varchar](255) NULL,
 CONSTRAINT [PK_Historial] PRIMARY KEY CLUSTERED 
(
	[hist_IdAfiliado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [LOS_BORBOTONES].[Dia]    Script Date: 12/04/2013 22:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [LOS_BORBOTONES].[Dia](
	[dia_IdDia255] [int] IDENTITY(1,1) NOT NULL,
	[dia_Descripcion] [varchar](255) NOT NULL,
 CONSTRAINT [PK_DIA] PRIMARY KEY CLUSTERED 
(
	[dia_IdDia255] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [LOS_BORBOTONES].[Especialidad_Profesional]    Script Date: 12/04/2013 22:21:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_BORBOTONES].[Especialidad_Profesional](
	[espr_CodEspecialidad] [int] NOT NULL,
	[espr_idProfesional] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[espr_CodEspecialidad] ASC,
	[espr_idProfesional] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [LOS_BORBOTONES].[Clinica]    Script Date: 12/04/2013 22:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_BORBOTONES].[Clinica](
	[cli_AperturaDiaHabil] [float] NULL,
	[cli_ClausuraDiaHabil] [float] NULL,
	[cli_AperturaDiaSabado] [float] NULL,
	[cli_ClausuraDiaSabado] [float] NULL
) ON [PRIMARY]
GO
/
/****** Object:  Table [LOS_BORBOTONES].[TipoCancelacion]    Script Date: 12/04/2013 22:21:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [LOS_BORBOTONES].[TipoCancelacion](
	[cati_IdTipoCancelacion] [int] IDENTITY(1,1) NOT NULL,
	[cati_Descripcion] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[cati_IdTipoCancelacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO

/****** Object:  Table [LOS_BORBOTONES].[Medicamento]    Script Date: 12/04/2013 22:21:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [LOS_BORBOTONES].[Medicamento](
	[med_IdMedicamento] [int] IDENTITY(1,1) NOT NULL,
	[med_Descripcion] [varchar](255) NULL,
 CONSTRAINT [PK_Medicamento] PRIMARY KEY CLUSTERED 
(
	[med_IdMedicamento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[vw_agenda]    Script Date: 12/04/2013 22:21:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_agenda]
AS   
 SELECT DISTINCT 
			   P.prof_IdProfesional Profesional, M.Especialidad_Codigo Especialidad
			  ,DATEPART ( WEEKDAY , M.Turno_Fecha )Dia
			  ,CONVERT( INT, DATENAME ( HH , M.Turno_Fecha ) )Hora
			  ,DATENAME ( MI , M.Turno_Fecha ) Minuto
		from gd_esquema.Maestra M
		
		JOIN LOS_BORBOTONES.Profesional P ON (M.Medico_Dni = P.prof_Dni)
		where (DATEPART ( WEEKDAY , M.Turno_Fecha ) <> 7
		   or (		DATEPART ( WEEKDAY , M.Turno_Fecha ) = 6 
			        and (DATENAME ( HH , M.Turno_Fecha ) > 10
					and	DATENAME ( HH , M.Turno_Fecha ) < 15))
			        and(DATENAME ( HH , M.Turno_Fecha ) > 7
					and	DATENAME ( HH , M.Turno_Fecha ) < 20))
		  and P.prof_Dni is not null
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_Turno]    Script Date: 12/04/2013 22:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [LOS_BORBOTONES].[Llenar_Turno]  
	
AS
BEGIN


	SET NOCOUNT ON;
	
	DECLARE @tur_numero int, @idProf int, @idAfi int, @especialidad int;
	DECLARE @tur_fecha datetime;
	DECLARE @tur_Estado bit;
	
	DECLARE turno_cursor CURSOR FOR
	SELECT DISTINCT M.Turno_Numero, P.prof_IdProfesional, A.afi_IdAfiliado, M.Especialidad_Codigo, M.Turno_Fecha,1
	FROM [GD2C2013].gd_esquema.Maestra M
	JOIN LOS_BORBOTONES.Profesional P  on  M.Medico_Dni = P.prof_Dni
	JOIN LOS_BORBOTONES.Afiliado A on  A.afi_Dni = M.Paciente_Dni 
	
	where M.Consulta_Sintomas IS NULL 
	GROUP BY M.Turno_Numero, P.prof_IdProfesional, A.afi_IdAfiliado, M.Especialidad_Codigo, M.Turno_Fecha
	ORDER BY M.Turno_Numero ASC
	
	
	OPEN turno_cursor
	
	FETCH NEXT FROM turno_cursor INTO
	@tur_numero, @idProf , @idAfi , @especialidad,  @tur_fecha , @tur_Estado 
	
	SET IDENTITY_INSERT LOS_BORBOTONES.Turno ON
	WHILE @@FETCH_STATUS = 0
	BEGIN
	
		INSERT INTO LOS_BORBOTONES.Turno(tur_IdTurno, tur_IdProf, tur_IdAfi, tur_Especialidad,  tur_Fecha, tur_Estado)
		VALUES 
		(@tur_numero, @idProf , @idAfi , @especialidad,  @tur_fecha , @tur_Estado );
		
		FETCH NEXT FROM turno_cursor INTO @tur_numero, @idProf , @idAfi, @especialidad,  @tur_fecha , @tur_Estado ; 	
	END
	
	SET IDENTITY_INSERT LOS_BORBOTONES.Turno OFF
	
    CLOSE turno_cursor;
    DEALLOCATE turno_cursor;
  
END


/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_Agenda]    Script Date: 12/02/2013 22:57:42 ******/
SET ANSI_NULLS ON
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_Profesional]    Script Date: 12/04/2013 22:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [LOS_BORBOTONES].[Llenar_Profesional]  
	
AS
BEGIN
	SET NOCOUNT ON;
	
	DECLARE @nombre varchar(255), @apellido varchar(255), @direccion varchar(255), @mail varchar(255);
	DECLARE @dni numeric(18,0), @telefono numeric(18,0);
	DECLARE @fecha_nac datetime;
	
	DECLARE prof_cursor CURSOR FOR
	SELECT DISTINCT Medico_Nombre, Medico_Apellido, Medico_Dni, Medico_Direccion, Medico_Telefono, Medico_Mail, Medico_Fecha_Nac
	FROM gd_esquema.Maestra
	where Medico_Dni IS NOT NULL
	
	OPEN prof_cursor
	
	FETCH NEXT FROM prof_cursor INTO
	@nombre, @apellido, @dni, @direccion, @telefono, @mail, @fecha_nac
	
	WHILE @@FETCH_STATUS = 0
	BEGIN
		INSERT INTO Profesional (prof_Nombre, prof_Apellido, prof_Dni, prof_Direccion, prof_Telefono, prof_Mail, prof_FechaNacimiento)
		VALUES 
		(@nombre , @apellido, @dni, @direccion, @telefono, @mail, @fecha_nac );
		
		FETCH NEXT FROM prof_cursor INTO @nombre, @apellido, @dni, @direccion, @telefono, @mail, @fecha_nac; 	
	END
	
    CLOSE prof_cursor;
    DEALLOCATE prof_cursor;
END
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_Historial]    Script Date: 12/04/2013 22:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [LOS_BORBOTONES].[Llenar_Historial] 
	
AS
BEGIN
    INSERT INTO LOS_BORBOTONES.Historial
    (hist_IdAfiliado,hist_PlanActual)
    SELECT DISTINCT
    a.afi_IdAfiliado,
    t.Plan_Med_Codigo
    FROM gd_esquema.Maestra t
    JOIN LOS_BORBOTONES.Afiliado a ON t.Paciente_Dni = a.afi_Dni
    
END
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_Especialidad_Profesional]    Script Date: 12/04/2013 22:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [LOS_BORBOTONES].[Llenar_Especialidad_Profesional]  
	
AS
BEGIN
	SET NOCOUNT ON;
	
	DECLARE @especialidad numeric(18,0); 
	DECLARE @idProfesional int;

	
	DECLARE profEsp_cursor CURSOR FOR
	SELECT DISTINCT  Tipo_Especialidad_Codigo, P.prof_IdProfesional
	FROM gd_esquema.Maestra
	JOIN Profesional P on Medico_Dni= P.prof_Dni
	where Medico_Dni IS NOT NULL
	
	OPEN profEsp_cursor
	
	FETCH NEXT FROM profEsp_cursor INTO
	@especialidad,@idProfesional
	
	WHILE @@FETCH_STATUS = 0
	BEGIN
		INSERT INTO Especialidad_Profesional (espr_idProfesional, espr_CodEspecialidad)
		VALUES 
		(@especialidad , @idProfesional );
		
		FETCH NEXT FROM profEsp_cursor INTO @especialidad,@idProfesional; 	
	END
	
    CLOSE profEsp_cursor;
    DEALLOCATE profEsp_cursor;
END
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_Afiliado]    Script Date: 12/04/2013 22:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [LOS_BORBOTONES].[Llenar_Afiliado] 
	
AS
BEGIN
INSERT	INTO LOS_BORBOTONES.Afiliado
(afi_Nombre,afi_Apellido ,afi_Dni,afi_Direccion,afi_Telefono,afi_Mail,afi_FechaNacimiento,afi_IdPlan)
SELECT DISTINCT
t.Paciente_Nombre,
t.Paciente_Apellido,
T.Paciente_Dni,
t.Paciente_Direccion,
t.Paciente_Telefono,
t.Paciente_Mail,
t.Paciente_Fecha_Nac,
t.Plan_Med_Codigo
FROM gd_esquema.Maestra t

END
GO
/****** Object:  Table [LOS_BORBOTONES].[Receta]    Script Date: 12/04/2013 22:21:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [LOS_BORBOTONES].[Receta](
	[rece_IdReceta] [int] IDENTITY(1,1) NOT NULL,
	[rece_Estado] [varchar](255) NOT NULL,
 CONSTRAINT [PK_Receta] PRIMARY KEY CLUSTERED 
(
	[rece_IdReceta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[proximos120dias]    Script Date: 12/04/2013 22:21:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[proximos120dias]
AS   
select  DATEPART ( WEEKDAY , dateadd(day,number,GETDATE()))Dia, dateadd(day,number,GETDATE()) Fecha
from master..spt_values
where type = 'p'
GROUP BY dateadd(day,number,GETDATE())
HAVING dateadd(day,number,GETDATE())< dateadd(day, 120,GETDATE())
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_Agenda]    Script Date: 12/04/2013 22:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [LOS_BORBOTONES].[Llenar_Agenda]
AS 
BEGIN		
	DECLARE 
		 @IdProfesional	as int
		,@Agenda_Especialidad as int
		,@Agenda_Dia		as int
		,@Agenda_Fecha		as datetime
		,@Agenda_Hora		as int
		,@Agenda_Minuto		as int
        	
	DECLARE cursorAgenda CURSOR
 FOR
 
SELECT AP.Profesional,AP.Especialidad,AP.Dia, PR.Fecha, (SELECT TOP 1 AGE.Hora FROM vw_agenda AGE WHERE AP.Profesional=AGE.Profesional AND AP.Dia=AGE.Dia ORDER BY AGE.Hora ASC)'Hora Comienzo', (SELECT TOP 1 AGE.Hora FROM vw_agenda AGE WHERE AP.Profesional=AGE.Profesional AND AP.Dia=AGE.Dia AND AP.Especialidad=AGE.Especialidad ORDER BY AGE.Hora DESC)'Hora fin'
FROM vw_agenda AP
LEFT JOIN proximos120dias PR on PR.Dia = AP.Dia
GROUP BY AP.Profesional, AP.Especialidad, AP.Dia, PR.Fecha
ORDER BY AP.Profesional

		OPEN cursorAgenda  	
	FETCH NEXT FROM cursorAgenda INTO   @IdProfesional,
										@Agenda_Especialidad,
										@Agenda_Dia,
										@Agenda_Fecha,
										@Agenda_Hora,
										@Agenda_Minuto
	
	WHILE (@@FETCH_STATUS = 0)
	BEGIN
		
		Insert into LOS_BORBOTONES.Agenda
		(
			 age_IdProfesional
			,age_Especialidad
			,age_IdDia
			,age_Fecha
			,age_HoraComienzo
			,age_HorarioFin
		)
		values
		(
			 @IdProfesional
			,@Agenda_Especialidad
			,@Agenda_Dia
			,@Agenda_Fecha
			,@Agenda_Hora
			,@Agenda_Minuto
		)
		
		
		FETCH NEXT FROM cursorAgenda INTO   @IdProfesional
											,@Agenda_Especialidad
											,@Agenda_Dia
											,@Agenda_Fecha
											,@Agenda_Hora
											,@Agenda_Minuto
		
	END
	CLOSE cursorAgenda
	DEALLOCATE cursorAgenda	
END;
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_Compra_Bono]    Script Date: 12/04/2013 22:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [LOS_BORBOTONES].[Llenar_Compra_Bono] 
AS
BEGIN
INSERT INTO LOS_BORBOTONES.Compra_Bono
(cobo_IdAfi,cobo_CantBC,cobo_CantBF,cobo_MontoTotal,cobo_FechaCompra)
select 
a.afi_IdAfiliado,
CASE WHEN(t.Bono_Consulta_Numero IS NOT NULL) THEN 1 ELSE 0 END,
CASE WHEN(t.Bono_Farmacia_Numero IS NOT NULL) THEN 1 ELSE 0 END,
CASE WHEN (t.Bono_Consulta_Numero IS NOT NULL AND t.Bono_Farmacia_Numero IS NOT NULL) THEN (p.plan_PrecioBC + p.plan_PrecioBF) 
          WHEN (t.Bono_Consulta_Numero IS NOT NULL AND t.Bono_Farmacia_Numero IS NULL) THEN (p.plan_PrecioBC)
          WHEN (t.Bono_Consulta_Numero IS NULL AND t.Bono_Farmacia_Numero IS NOT NULL) THEN (p.plan_PrecioBF)
     ELSE 0 END,
t.Compra_Bono_Fecha
from gd_esquema.Maestra t
join LOS_BORBOTONES.AFILIADO a on a.afi_Dni = t.Paciente_Dni
join LOS_BORBOTONES.PLAN_MEDICO p on p.plan_IdPlan = t.Plan_Med_Codigo
WHERE t.Compra_Bono_Fecha IS NOT NULL

END
GO
/****** Object:  Table [LOS_BORBOTONES].[Medicamento_Receta]    Script Date: 12/04/2013 22:21:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_BORBOTONES].[Medicamento_Receta](
	[mere_IdMedicamento] [int] NOT NULL,
	[mere_IdReceta] [int] NOT NULL,
	[mere_CantMed] [int] NULL,
 CONSTRAINT [PK_Medicamento_Receta] PRIMARY KEY CLUSTERED 
(
	[mere_IdReceta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_TipoCancelacion]    Script Date: 12/04/2013 22:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [LOS_BORBOTONES].[Llenar_TipoCancelacion] 
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	

	SET NOCOUNT ON;
    -- Insert statements for procedure here
	INSERT INTO LOS_BORBOTONES.TipoCancelacion(cati_Descripcion) VALUES('Usuario Cancelo');
	INSERT INTO LOS_BORBOTONES.TipoCancelacion(cati_Descripcion) VALUES('Indisponibilidad del Medio');
	INSERT INTO LOS_BORBOTONES.TipoCancelacion(cati_Descripcion) VALUES('Clinica cerrada');
	INSERT INTO LOS_BORBOTONES.TipoCancelacion(cati_Descripcion) VALUES('Otro');
	
END
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_Tipo_Especialidad]    Script Date: 12/04/2013 22:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [LOS_BORBOTONES].[Llenar_Tipo_Especialidad]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @descripcion varchar(255)
	DECLARE @codigo numeric(18,0);
	
	DECLARE tipo_esp_cursor CURSOR FOR
	SELECT DISTINCT [Tipo_Especialidad_Codigo],[Tipo_Especialidad_Descripcion]
    FROM [GD2C2013].[gd_esquema].[Maestra]
	WHERE [Tipo_Especialidad_Codigo] IS NOT NULL
	
	OPEN tipo_esp_cursor
	
	FETCH NEXT FROM tipo_esp_cursor INTO
	@codigo, @descripcion
	
	WHILE @@FETCH_STATUS = 0
	BEGIN
		INSERT INTO Tipo_Especialidad(ties_CodTipo, ties_Descripcion) VALUES
		(@codigo,@descripcion);
		
		FETCH NEXT FROM tipo_esp_cursor INTO @codigo, @descripcion;
	END
	
    CLOSE tipo_esp_cursor;
    DEALLOCATE tipo_esp_cursor;
END
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_Funcionalidad]    Script Date: 12/04/2013 22:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*Procedimiento llenar tabla funcionalidad*/
CREATE PROCEDURE [LOS_BORBOTONES].[Llenar_Funcionalidad] 
	
AS
BEGIN

SET IDENTITY_INSERT LOS_BORBOTONES.Funcionalidad ON
INSERT [LOS_BORBOTONES].[Funcionalidad] ([fun_CodFuncionalidad], [fun_Descripcion]) VALUES (1, N'ABM Afiliados')
INSERT [LOS_BORBOTONES].[Funcionalidad] ([fun_CodFuncionalidad], [fun_Descripcion]) VALUES (2, N'ABM de Especialidades Medicas')
INSERT [LOS_BORBOTONES].[Funcionalidad] ([fun_CodFuncionalidad], [fun_Descripcion]) VALUES (3, N'ABM de Planes')
INSERT [LOS_BORBOTONES].[Funcionalidad] ([fun_CodFuncionalidad], [fun_Descripcion]) VALUES (4, N'ABM de Profesional')
INSERT [LOS_BORBOTONES].[Funcionalidad] ([fun_CodFuncionalidad], [fun_Descripcion]) VALUES (5, N'Cancelar atencion')
INSERT [LOS_BORBOTONES].[Funcionalidad] ([fun_CodFuncionalidad], [fun_Descripcion]) VALUES (6, N'Compra de bono')
INSERT [LOS_BORBOTONES].[Funcionalidad] ([fun_CodFuncionalidad], [fun_Descripcion]) VALUES (7, N'Generar Receta') 
INSERT [LOS_BORBOTONES].[Funcionalidad] ([fun_CodFuncionalidad], [fun_Descripcion]) VALUES (8, N'Listado Estadistico')
INSERT [LOS_BORBOTONES].[Funcionalidad] ([fun_CodFuncionalidad], [fun_Descripcion]) VALUES (9, N'Pedir turno')
INSERT [LOS_BORBOTONES].[Funcionalidad] ([fun_CodFuncionalidad], [fun_Descripcion]) VALUES (10, N'Registrar Agenda')
INSERT [LOS_BORBOTONES].[Funcionalidad] ([fun_CodFuncionalidad], [fun_Descripcion]) VALUES (11, N'Registro de llegada')
INSERT [LOS_BORBOTONES].[Funcionalidad] ([fun_CodFuncionalidad], [fun_Descripcion]) VALUES (12, N'Registro de usuario')
INSERT [LOS_BORBOTONES].[Funcionalidad] ([fun_CodFuncionalidad], [fun_Descripcion]) VALUES (13, N'Registro Resultado Atencion')
SET IDENTITY_INSERT LOS_BORBOTONES.Funcionalidad OFF

END
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_EstadoCivil]    Script Date: 12/04/2013 22:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [LOS_BORBOTONES].[Llenar_EstadoCivil] 

AS
BEGIN
INSERT INTO LOS_BORBOTONES.EstadoCivil

VALUES
(1,'Soltero'),
(2,'Viudo'),
(3,'Casado'),
(4,'Divorciado'),
(5,'Separado')

END
GO
/****** Object:  Table [LOS_BORBOTONES].[Cancelacion]    Script Date: 12/04/2013 22:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [LOS_BORBOTONES].[Cancelacion](
	[can_IdCan] [int] IDENTITY(1,1) NOT NULL,
	[can_Motivo] [varchar](max) NULL,
	[can_Tipo] [int] NULL,
 CONSTRAINT [PK__Cancelac__B635DB911D3C345A] PRIMARY KEY CLUSTERED 
(
	[can_IdCan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [LOS_BORBOTONES].[Bono_Farmacia]    Script Date: 12/04/2013 22:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_BORBOTONES].[Bono_Farmacia](
	[bofa_IdBonoFarmacia] [int] IDENTITY(1,1) NOT NULL,
	[bofa_IdAfi] [int] NULL,
	[bofa_IdPlan] [int] NULL,
	[bofa_IdCompra] [int] NULL,
	[bofa_IdReceta] [int] NULL,
	[bofa_FechaVencBF] [datetime] NULL,
	[bofa_FechaPrescripcionMed] [datetime] NULL,
	[bofa_FechaImpresion] [datetime] NULL,
 CONSTRAINT [PK_BONO_FARMACIA] PRIMARY KEY CLUSTERED 
(
	[bofa_IdBonoFarmacia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [LOS_BORBOTONES].[vw_BonosVencidos]    Script Date: 12/04/2013 22:21:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [LOS_BORBOTONES].[vw_BonosVencidos]
(
	  Afiliado
	,Fecha_vencimiento
)
AS 
SELECT (CONVERT(VARCHAR(20),af.afi_IdAfiliado)) AFILIADO
	  ,fa.bofa_FechaVencBF
from LOS_BORBOTONES.Bono_Farmacia fa
join LOS_BORBOTONES.Compra_Bono co on (co.cobo_IdCompra = fa.bofa_IdCompra)
join LOS_BORBOTONES.Afiliado af on (af.afi_IdAfiliado= co.cobo_IdAfi)
where fa.bofa_FechaVencBF <= (GETDATE())
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Cargar_BonoFarmacia]    Script Date: 12/04/2013 22:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [LOS_BORBOTONES].[Cargar_BonoFarmacia] 
AS
BEGIN
SET IDENTITY_INSERT LOS_BORBOTONES.Bono_Farmacia ON
INSERT INTO LOS_BORBOTONES.Bono_Farmacia 
(bofa_IdBonoFarmacia,bofa_FechaImpresion, bofa_IdAfi,bofa_IdPlan)
SELECT distinct
t.Bono_Farmacia_Numero,
t.Bono_Farmacia_Fecha_Impresion,
a.afi_IdAfiliado,
a.afi_IdPlan
from gd_esquema.Maestra t
JOIN LOS_BORBOTONES.Afiliado a ON a.afi_Dni = t.Paciente_Dni
where t.Bono_Farmacia_Numero > 0
SET IDENTITY_INSERT LOS_BORBOTONES.Bono_Farmacia OFF
END
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Cargar_BonoConsulta]    Script Date: 12/04/2013 22:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [LOS_BORBOTONES].[Cargar_BonoConsulta] 
AS
BEGIN
 INSERT INTO LOS_BORBOTONES.BONO_CONSULTA
(boco_IdBonoConsulta,boco_FechaImpresion,boco_IdAfiliado,boco_IdPlan)
SELECT distinct
t.Bono_Consulta_Numero,
t.Bono_Consulta_Fecha_Impresion,
a.afi_IdAfiliado,
t.Plan_Med_Codigo
from gd_esquema.Maestra t
JOIN LOS_BORBOTONES.Afiliado a ON a.afi_Dni = t.Paciente_Dni
where t.Bono_Consulta_Numero > 0


END
GO

/****** Object:  View [LOS_BORBOTONES].[vw_cancelaciones_especialidad]    Script Date: 12/04/2013 22:21:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [LOS_BORBOTONES].[vw_cancelaciones_especialidad]
(
	 Especialidad
	,fechaCancelacion
	
)
AS 
select esp.esp_Descripcion, ca.catu_FechaCancelacion
from LOS_BORBOTONES.Cancelacion_Turno ca
join LOS_BORBOTONES.Turno tu on (tu.tur_IdTurno = ca.catu_IdTurno)
join LOS_BORBOTONES.Especialidad esp on (tu.tur_Especialidad = esp.esp_CodEspecialidad)
;
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Crear_Usuarios]    Script Date: 12/04/2013 22:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*Procedimiento Crear usuarios*/
CREATE PROCEDURE [LOS_BORBOTONES].[Crear_Usuarios] 
AS
BEGIN
	SET NOCOUNT ON;

INSERT [LOS_BORBOTONES].[Usuario] ([usu_IdUsuario], [usu_Password], [usu_IntentosFallidos]) VALUES (N'admin', N'acaVaLaPassword', 0)

END
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_Clinica]    Script Date: 12/04/2013 22:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [LOS_BORBOTONES].[Llenar_Clinica] 
	
AS
BEGIN

INSERT INTO LOS_BORBOTONES.Clinica

VALUES
(07.00,20.00,10.00,15.00)

END
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_PlanMedico]    Script Date: 12/04/2013 22:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [LOS_BORBOTONES].[Llenar_PlanMedico] 
AS
BEGIN
INSERT INTO LOS_BORBOTONES.Plan_Medico
(plan_IdPlan,plan_Descripcion,plan_PrecioBC,plan_PrecioBF)
select distinct 
t.Plan_Med_Codigo,
t.Plan_Med_Descripcion,
t.Plan_Med_Precio_Bono_Consulta,
t.Plan_Med_Precio_Bono_Farmacia
from gd_esquema.Maestra t 

END
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_Medicamento]    Script Date: 12/04/2013 22:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [LOS_BORBOTONES].[Llenar_Medicamento] 
AS
BEGIN
INSERT INTO LOS_BORBOTONES.Medicamento
(med_Descripcion)
select distinct 
t.Bono_Farmacia_Medicamento
from gd_esquema.Maestra t 

END
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_Dias]    Script Date: 12/04/2013 22:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [LOS_BORBOTONES].[Llenar_Dias] 
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Dia(dia_Descripcion) VALUES('Lunes');
	INSERT INTO Dia(dia_Descripcion) VALUES('Martes');
	INSERT INTO Dia (dia_Descripcion) VALUES('Miercoles');
	INSERT INTO Dia (dia_Descripcion) VALUES('Jueves');
	INSERT INTO Dia (dia_Descripcion) VALUES('Viernes');
	INSERT INTO Dia (dia_Descripcion) VALUES('Sabado');

END
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_Especialidad]    Script Date: 12/04/2013 22:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [LOS_BORBOTONES].[Llenar_Especialidad]
AS
BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @descripcion varchar(255)
	DECLARE @codigo numeric(18,0), @tipo_codigo numeric(18,0);
	
	DECLARE esp_cursor CURSOR FOR
	SELECT DISTINCT [Especialidad_Codigo],[Especialidad_Descripcion],[Tipo_Especialidad_Codigo]
    FROM [GD2C2013].[gd_esquema].[Maestra]
	WHERE [Especialidad_Codigo] IS NOT NULL
	
	OPEN esp_cursor
	
	FETCH NEXT FROM esp_cursor INTO
	@codigo, @descripcion, @tipo_codigo
	
	WHILE @@FETCH_STATUS = 0
	BEGIN
		INSERT INTO Especialidad(esp_CodEspecialidad, esp_Descripcion, esp_TipoEspecialidad) VALUES
		(@codigo,@descripcion,@tipo_codigo);
		
		FETCH NEXT FROM esp_cursor INTO @codigo, @descripcion,@tipo_codigo;
	END
	
    CLOSE esp_cursor;
    DEALLOCATE esp_cursor;
END
GO
/****** Object:  View [LOS_BORBOTONES].[vw_Bonos_Afiliado]    Script Date: 12/04/2013 22:21:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [LOS_BORBOTONES].[vw_Bonos_Afiliado]
(
	 Afiliado
	,Fecha_Utilizacion
	
)
AS 

select (CONVERT(VARCHAR(20),fa.bofa_IdAfi)) Afiliado
 ,fa.bofa_FechaVencBF Fecha_Impresion
from LOS_BORBOTONES.Compra_Bono com
join LOS_BORBOTONES.Bono_Farmacia fa on (com.cobo_IdCompra= fa.bofa_IdCompra
									and fa.bofa_IdAfi= com.cobo_IdAfi
									)
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_Consulta]    Script Date: 12/04/2013 22:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [LOS_BORBOTONES].[Llenar_Consulta]  
	
AS
BEGIN
	SET NOCOUNT ON;
	
	DECLARE @idBonoConsulta numeric(18,0); 
	DECLARE @fechaConsulta datetime;
	DECLARE @sintomas varchar(255);

	
	DECLARE consulta_cursor CURSOR FOR
	SELECT distinct
	t.Bono_Consulta_Numero,
	t.Turno_Fecha,
	t.Consulta_Sintomas
	from gd_esquema.Maestra t
	JOIN LOS_BORBOTONES.Bono_Consulta BC ON BC.boco_IdBonoConsulta = t.Bono_Consulta_Numero
	where t.Consulta_Sintomas IS NOT NULL
	
	OPEN consulta_cursor
	
	FETCH NEXT FROM consulta_cursor INTO
	@idBonoConsulta,@fechaConsulta,@sintomas
	
	WHILE @@FETCH_STATUS = 0
	BEGIN
		INSERT INTO Consulta(con_IdBonoConsulta, con_FechaLlegada,con_Sintomas)
		VALUES 
		(@idBonoConsulta, @fechaConsulta, @sintomas );
		
		FETCH NEXT FROM consulta_cursor INTO @idBonoConsulta, @fechaConsulta, @sintomas ; 	
	END
	
    CLOSE consulta_cursor;
    DEALLOCATE consulta_cursor;
END
GO
/****** Object:  Table [LOS_BORBOTONES].[Diagnostico]    Script Date: 12/04/2013 22:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [LOS_BORBOTONES].[Diagnostico](
	[diag_IdConsulta] [int] NOT NULL,
	[diag_IdReceta] [int] NULL,
	[diag_Diagnostico] [varchar](255) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [LOS_BORBOTONES].[vw_BonoFarmacia_Especialidad]    Script Date: 12/04/2013 22:21:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [LOS_BORBOTONES].[vw_BonoFarmacia_Especialidad]
(
	 Especialidad
	,FECHA
)
AS 
select es.esp_Descripcion
	  ,bf.bofa_FechaImpresion
from LOS_BORBOTONES.Turno tu
join LOS_BORBOTONES.Consulta co on (co.con_IdConsulta= tu.tur_IdConsulta)
join LOS_BORBOTONES.Bono_Farmacia bf on (bf.bofa_IdCompra =co.con_IdConsulta) /*Me falta como machear bono farmacia*/
join LOS_BORBOTONES.Diagnostico dg on (dg.diag_IdConsulta =co.con_IdConsulta)
join LOS_BORBOTONES.Receta re on (diag_IdReceta = re.rece_IdReceta)
join LOS_BORBOTONES.Especialidad es on (es.esp_CodEspecialidad= tu.tur_Especialidad)
where re.rece_Estado = 0
GO
/****** Object:  StoredProcedure [LOS_BORBOTONES].[Llenar_Diagnostico]    Script Date: 12/04/2013 22:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [LOS_BORBOTONES].[Llenar_Diagnostico] 
AS
BEGIN
 INSERT INTO LOS_BORBOTONES.Diagnostico
(diag_IdConsulta,diag_Diagnostico)
SELECT distinct
	C.con_IdConsulta,
	t.Consulta_Enfermedades
	from gd_esquema.Maestra t
	join LOS_BORBOTONES.Consulta C on C.con_IdBonoConsulta = t.Bono_Consulta_Numero
	where t.Consulta_Enfermedades IS NOT NULL
ORDER BY con_IdConsulta ASC

END
GO
/****** Object:  ForeignKey [FK_Afiliado_Usuario]    Script Date: 12/04/2013 22:21:28 ******/
ALTER TABLE [LOS_BORBOTONES].[Afiliado]  WITH CHECK ADD  CONSTRAINT [FK_Afiliado_Usuario] FOREIGN KEY([afi_NombreUsuario])
REFERENCES [LOS_BORBOTONES].[Usuario] ([usu_IdUsuario])
GO
ALTER TABLE [LOS_BORBOTONES].[Afiliado] CHECK CONSTRAINT [FK_Afiliado_Usuario]
GO
/****** Object:  ForeignKey [FK_EstadoCivil]    Script Date: 12/04/2013 22:21:28 ******/
ALTER TABLE [LOS_BORBOTONES].[Afiliado]  WITH CHECK ADD  CONSTRAINT [FK_EstadoCivil] FOREIGN KEY([afi_EstadoCivil])
REFERENCES [LOS_BORBOTONES].[EstadoCivil] ([esci_CodEcivil])
GO
ALTER TABLE [LOS_BORBOTONES].[Afiliado] CHECK CONSTRAINT [FK_EstadoCivil]
GO
/****** Object:  ForeignKey [FK_IdPlan]    Script Date: 12/04/2013 22:21:28 ******/
ALTER TABLE [LOS_BORBOTONES].[Afiliado]  WITH CHECK ADD  CONSTRAINT [FK_IdPlan] FOREIGN KEY([afi_IdPlan])
REFERENCES [LOS_BORBOTONES].[Plan_Medico] ([plan_IdPlan])
GO
ALTER TABLE [LOS_BORBOTONES].[Afiliado] CHECK CONSTRAINT [FK_IdPlan]
GO
/****** Object:  ForeignKey [FK_IdCompra]    Script Date: 12/04/2013 22:21:28 ******/
ALTER TABLE [LOS_BORBOTONES].[Bono_Consulta]  WITH CHECK ADD  CONSTRAINT [FK_IdCompra] FOREIGN KEY([boco_IdCompra])
REFERENCES [LOS_BORBOTONES].[Compra_Bono] ([cobo_IdCompra])
GO
ALTER TABLE [LOS_BORBOTONES].[Bono_Consulta] CHECK CONSTRAINT [FK_IdCompra]
GO
/****** Object:  ForeignKey [FK_Bono_Farmacia_Compra_Bono]    Script Date: 12/04/2013 22:21:28 ******/
ALTER TABLE [LOS_BORBOTONES].[Bono_Farmacia]  WITH CHECK ADD  CONSTRAINT [FK_Bono_Farmacia_Compra_Bono] FOREIGN KEY([bofa_IdCompra])
REFERENCES [LOS_BORBOTONES].[Compra_Bono] ([cobo_IdCompra])
GO
ALTER TABLE [LOS_BORBOTONES].[Bono_Farmacia] CHECK CONSTRAINT [FK_Bono_Farmacia_Compra_Bono]
GO
/****** Object:  ForeignKey [FK_Bono_Farmacia_Receta]    Script Date: 12/04/2013 22:21:28 ******/
ALTER TABLE [LOS_BORBOTONES].[Bono_Farmacia]  WITH CHECK ADD  CONSTRAINT [FK_Bono_Farmacia_Receta] FOREIGN KEY([bofa_IdReceta])
REFERENCES [LOS_BORBOTONES].[Receta] ([rece_IdReceta])
GO
ALTER TABLE [LOS_BORBOTONES].[Bono_Farmacia] CHECK CONSTRAINT [FK_Bono_Farmacia_Receta]
GO
/****** Object:  ForeignKey [FK_Cancelacion_TipoCancelacion]    Script Date: 12/04/2013 22:21:28 ******/
ALTER TABLE [LOS_BORBOTONES].[Cancelacion]  WITH CHECK ADD  CONSTRAINT [FK_Cancelacion_TipoCancelacion] FOREIGN KEY([can_Tipo])
REFERENCES [LOS_BORBOTONES].[TipoCancelacion] ([cati_IdTipoCancelacion])
GO
ALTER TABLE [LOS_BORBOTONES].[Cancelacion] CHECK CONSTRAINT [FK_Cancelacion_TipoCancelacion]
GO
/****** Object:  ForeignKey [FK_Consulta_Bono_Consulta]    Script Date: 12/04/2013 22:21:28 ******/
ALTER TABLE [LOS_BORBOTONES].[Consulta]  WITH CHECK ADD  CONSTRAINT [FK_Consulta_Bono_Consulta] FOREIGN KEY([con_IdBonoConsulta])
REFERENCES [LOS_BORBOTONES].[Bono_Consulta] ([boco_IdBonoConsulta])
GO
ALTER TABLE [LOS_BORBOTONES].[Consulta] CHECK CONSTRAINT [FK_Consulta_Bono_Consulta]
GO
/****** Object:  ForeignKey [FK_Diagnostico_Consulta]    Script Date: 12/04/2013 22:21:28 ******/
ALTER TABLE [LOS_BORBOTONES].[Diagnostico]  WITH CHECK ADD  CONSTRAINT [FK_Diagnostico_Consulta] FOREIGN KEY([diag_IdConsulta])
REFERENCES [LOS_BORBOTONES].[Consulta] ([con_IdConsulta])
GO
ALTER TABLE [LOS_BORBOTONES].[Diagnostico] CHECK CONSTRAINT [FK_Diagnostico_Consulta]
GO
/****** Object:  ForeignKey [FK_Diagnostico_Receta]    Script Date: 12/04/2013 22:21:28 ******/
ALTER TABLE [LOS_BORBOTONES].[Diagnostico]  WITH CHECK ADD  CONSTRAINT [FK_Diagnostico_Receta] FOREIGN KEY([diag_IdReceta])
REFERENCES [LOS_BORBOTONES].[Receta] ([rece_IdReceta])
GO
ALTER TABLE [LOS_BORBOTONES].[Diagnostico] CHECK CONSTRAINT [FK_Diagnostico_Receta]
GO
/****** Object:  ForeignKey [FK_Especialidad_TipoEspecialidad]    Script Date: 12/04/2013 22:21:29 ******/
ALTER TABLE [LOS_BORBOTONES].[Especialidad]  WITH CHECK ADD  CONSTRAINT [FK_Especialidad_TipoEspecialidad] FOREIGN KEY([esp_TipoEspecialidad])
REFERENCES [LOS_BORBOTONES].[Tipo_Especialidad] ([ties_CodTipo])
GO
ALTER TABLE [LOS_BORBOTONES].[Especialidad] CHECK CONSTRAINT [FK_Especialidad_TipoEspecialidad]
GO
/****** Object:  ForeignKey [FK_Func_Rol_Funcionalidad]    Script Date: 12/04/2013 22:21:29 ******/
ALTER TABLE [LOS_BORBOTONES].[Func_Rol]  WITH CHECK ADD  CONSTRAINT [FK_Func_Rol_Funcionalidad] FOREIGN KEY([furo_CodFuncionalidad])
REFERENCES [LOS_BORBOTONES].[Funcionalidad] ([fun_CodFuncionalidad])
GO
ALTER TABLE [LOS_BORBOTONES].[Func_Rol] CHECK CONSTRAINT [FK_Func_Rol_Funcionalidad]
GO
/****** Object:  ForeignKey [FK_Func_Rol_Rol]    Script Date: 12/04/2013 22:21:29 ******/
ALTER TABLE [LOS_BORBOTONES].[Func_Rol]  WITH CHECK ADD  CONSTRAINT [FK_Func_Rol_Rol] FOREIGN KEY([furo_CodRol])
REFERENCES [LOS_BORBOTONES].[Rol] ([rol_CodRol])
GO
ALTER TABLE [LOS_BORBOTONES].[Func_Rol] CHECK CONSTRAINT [FK_Func_Rol_Rol]
GO
/****** Object:  ForeignKey [FK_Historial_Afiliado]    Script Date: 12/04/2013 22:21:29 ******/
ALTER TABLE [LOS_BORBOTONES].[Historial]  WITH CHECK ADD  CONSTRAINT [FK_Historial_Afiliado] FOREIGN KEY([hist_IdAfiliado])
REFERENCES [LOS_BORBOTONES].[Afiliado] ([afi_IdAfiliado])
GO
ALTER TABLE [LOS_BORBOTONES].[Historial] CHECK CONSTRAINT [FK_Historial_Afiliado]
GO
/****** Object:  ForeignKey [FK_Medicamento_Receta_Medicamento]    Script Date: 12/04/2013 22:21:29 ******/
ALTER TABLE [LOS_BORBOTONES].[Medicamento_Receta]  WITH CHECK ADD  CONSTRAINT [FK_Medicamento_Receta_Medicamento] FOREIGN KEY([mere_IdMedicamento])
REFERENCES [LOS_BORBOTONES].[Medicamento] ([med_IdMedicamento])
GO
ALTER TABLE [LOS_BORBOTONES].[Medicamento_Receta] CHECK CONSTRAINT [FK_Medicamento_Receta_Medicamento]
GO
/****** Object:  ForeignKey [FK_Medicamento_Receta_Receta]    Script Date: 12/04/2013 22:21:29 ******/
ALTER TABLE [LOS_BORBOTONES].[Medicamento_Receta]  WITH CHECK ADD  CONSTRAINT [FK_Medicamento_Receta_Receta] FOREIGN KEY([mere_IdReceta])
REFERENCES [LOS_BORBOTONES].[Receta] ([rece_IdReceta])
GO
ALTER TABLE [LOS_BORBOTONES].[Medicamento_Receta] CHECK CONSTRAINT [FK_Medicamento_Receta_Receta]
GO
/****** Object:  ForeignKey [FK_Profesional_Usuario]    Script Date: 12/04/2013 22:21:29 ******/
ALTER TABLE [LOS_BORBOTONES].[Profesional]  WITH CHECK ADD  CONSTRAINT [FK_Profesional_Usuario] FOREIGN KEY([prof_NombreUsuario])
REFERENCES [LOS_BORBOTONES].[Usuario] ([usu_IdUsuario])
GO
ALTER TABLE [LOS_BORBOTONES].[Profesional] CHECK CONSTRAINT [FK_Profesional_Usuario]
GO
/****** Object:  ForeignKey [FK_Rol_Usuario_Rol]    Script Date: 12/04/2013 22:21:29 ******/
ALTER TABLE [LOS_BORBOTONES].[Rol_Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Rol_Usuario_Rol] FOREIGN KEY([rous_CodRol])
REFERENCES [LOS_BORBOTONES].[Rol] ([rol_CodRol])
GO
ALTER TABLE [LOS_BORBOTONES].[Rol_Usuario] CHECK CONSTRAINT [FK_Rol_Usuario_Rol]
GO
/****** Object:  ForeignKey [FK_Rol_Usuario_Rol_Usuario]    Script Date: 12/04/2013 22:21:29 ******/
ALTER TABLE [LOS_BORBOTONES].[Rol_Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Rol_Usuario_Rol_Usuario] FOREIGN KEY([rous_IdUsuario])
REFERENCES [LOS_BORBOTONES].[Usuario] ([usu_IdUsuario])
GO
ALTER TABLE [LOS_BORBOTONES].[Rol_Usuario] CHECK CONSTRAINT [FK_Rol_Usuario_Rol_Usuario]
GO
/****** Object:  ForeignKey [FK_Turno_Afiliado]    Script Date: 12/04/2013 22:21:30 ******/
ALTER TABLE [LOS_BORBOTONES].[Turno]  WITH CHECK ADD  CONSTRAINT [FK_Turno_Afiliado] FOREIGN KEY([tur_IdAfi])
REFERENCES [LOS_BORBOTONES].[Afiliado] ([afi_IdAfiliado])
GO
ALTER TABLE [LOS_BORBOTONES].[Turno] CHECK CONSTRAINT [FK_Turno_Afiliado]
GO
/****** Object:  ForeignKey [FK_Turno_Consulta]    Script Date: 12/04/2013 22:21:30 ******/
ALTER TABLE [LOS_BORBOTONES].[Turno]  WITH CHECK ADD  CONSTRAINT [FK_Turno_Consulta] FOREIGN KEY([tur_IdConsulta])
REFERENCES [LOS_BORBOTONES].[Consulta] ([con_IdConsulta])
GO
ALTER TABLE [LOS_BORBOTONES].[Turno] CHECK CONSTRAINT [FK_Turno_Consulta]
GO
/****** Object:  ForeignKey [FK_Turno_Especialidad]    Script Date: 12/04/2013 22:21:30 ******/
ALTER TABLE [LOS_BORBOTONES].[Turno]  WITH CHECK ADD  CONSTRAINT [FK_Turno_Especialidad] FOREIGN KEY([tur_Especialidad])
REFERENCES [LOS_BORBOTONES].[Especialidad] ([esp_CodEspecialidad])
GO
ALTER TABLE [LOS_BORBOTONES].[Turno] CHECK CONSTRAINT [FK_Turno_Especialidad]
GO
/****** Object:  ForeignKey [FK_Turno_Profesional]    Script Date: 12/04/2013 22:21:30 ******/
ALTER TABLE [LOS_BORBOTONES].[Turno]  WITH CHECK ADD  CONSTRAINT [FK_Turno_Profesional] FOREIGN KEY([tur_IdProf])
REFERENCES [LOS_BORBOTONES].[Profesional] ([prof_IdProfesional])
GO
ALTER TABLE [LOS_BORBOTONES].[Turno] CHECK CONSTRAINT [FK_Turno_Profesional]
GO

EXEC LOS_BORBOTONES.Crear_Usuarios  
GO
EXEC LOS_BORBOTONES.Llenar_Dias
GO
EXEC LOS_BORBOTONES.Llenar_Rol
GO
EXEC LOS_BORBOTONES.Llenar_EstadoCivil
GO
EXEC LOS_BORBOTONES.Llenar_Funcionalidad
GO
EXEC LOS_BORBOTONES.Llenar_TipoCancelacion
GO
EXEC LOS_BORBOTONES.Llenar_Tipo_Especialidad
GO
EXEC LOS_BORBOTONES.Llenar_Medicamento
GO
EXEC LOS_BORBOTONES.Llenar_PlanMedico
GO
EXEC LOS_BORBOTONES.Llenar_Afiliado
GO
EXEC LOS_BORBOTONES.Llenar_Profesional
GO
EXEC LOS_BORBOTONES.Cargar_BonoConsulta
GO
EXEC LOS_BORBOTONES.Cargar_BonoFarmacia
GO
EXEC LOS_BORBOTONES.Llenar_Compra_Bono
GO
EXEC LOS_BORBOTONES.Llenar_Especialidad
GO
EXEC LOS_BORBOTONES.Relacionar_FuncionalidadesRol
GO
EXEC LOS_BORBOTONES.Llenar_Turno
GO                    
EXEC LOS_BORBOTONES.Llenar_Clinica
GO
EXEC LOS_BORBOTONES.Llenar_Historial
GO
EXEC LOS_BORBOTONES.Llenar_Rol_Usuario
GO
EXEC LOS_BORBOTONES.Llenar_Medicamento
GO
EXEC LOS_BORBOTONES.Llenar_Especialidad_Profesional
GO
EXEC LOS_BORBOTONES.Llenar_Consulta
GO
EXEC LOS_BORBOTONES.Llenar_Diagnostico
GO
EXEC LOS_BORBOTONES.Llenar_Agenda
GO


****** Object:  Trigger [BAJA_PROFESIONAL]    Script Date: 12/04/2013 22:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [LOS_BORBOTONES].[BAJA_PROFESIONAL] ON [LOS_BORBOTONES].[Profesional] FOR DELETE
AS
BEGIN
	DELETE FROM Agenda WHERE age_IdProfesional in (SELECT prof_IdProfesional from deleted )
END
GO
/****** Object:  Table [LOS_BORBOTONES].[Cancelacion_Turno]    Script Date: 12/04/2013 22:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_BORBOTONES].[Cancelacion_Turno](
	[catu_IdCancelacion] [int] NOT NULL,
	[catu_IdTurno] [int] NOT NULL,
	[catu_FechaCancelacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[catu_IdCancelacion] ASC,
	[catu_IdTurno] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Trigger [CANCELAR_TURNOS_EN_BAJA_USUARIO]    Script Date: 12/04/2013 22:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [LOS_BORBOTONES].[CANCELAR_TURNOS_EN_BAJA_USUARIO] ON [LOS_BORBOTONES].[Afiliado] FOR UPDATE
AS
BEGIN
	DECLARE @usuario varchar(10)
	DECLARE @estado bit
	DECLARE @estado_cancelado bit
	DECLARE @estado_usuario_baja bit
	
	-- ESTE ES EL ESTADO QUE LE CORRESPONDE A UN USUARIO QUE FUE DADO DE BAJA
	SET @estado_usuario_baja = 1
	
	--CAMBIAR POR EL ESTADO QUE REALMENTE SEA CORRECTO
	SET @estado_cancelado = 1
	
	SELECT @usuario = afi_IdAfiliado, @estado = afi_Estado FROM inserted
	IF (@estado = @estado_usuario_baja)
		UPDATE Turno SET tur_Estado = @estado_cancelado where tur_IdAfi = @usuario and tur_Fecha > GETDATE()
END
GO
/****** Object:  Trigger [BAJA_AGENDA]    Script Date: 12/04/2013 22:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [LOS_BORBOTONES].[BAJA_AGENDA] ON [LOS_BORBOTONES].[Agenda] FOR DELETE
AS
BEGIN
	DELETE FROM Turno WHERE tur_IdProf in (SELECT age_IdProfesional from deleted )
END
GO

/****** Object:  Trigger [CAMBIO_PLAN_FAMILIAR]    Script Date: 12/04/2013 22:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [LOS_BORBOTONES].[CAMBIO_PLAN_FAMILIAR] ON [LOS_BORBOTONES].[Afiliado] AFTER UPDATE
AS
BEGIN
	DECLARE @plan_actual numeric(18,0)
	DECLARE @plan_anterior numeric(18,0)
	DECLARE @afiliado int
	DECLARE @cantidad_fam int
	

	SELECT @plan_actual = afi_IdPlan, @cantidad_fam = afi_CantPersonas, @afiliado = afi_IdAfiliado from inserted;
	SET @plan_anterior = (SELECT afi_IdPlan from deleted);
	IF (@plan_actual <> @plan_anterior AND @cantidad_fam > 0 )
	BEGIN
		UPDATE Afiliado SET afi_IdPlan = @plan_actual where afi_IdAfiliado > @afiliado AND afi_IdAfiliado <= afi_IdAfiliado + @cantidad_fam
	END
END
GO

/****** Object:  Trigger [DESHABILITAR_ROL]    Script Date: 12/04/2013 22:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [LOS_BORBOTONES].[DESHABILITAR_ROL] ON [LOS_BORBOTONES].[Rol] AFTER UPDATE
AS
BEGIN
	DECLARE @rol int
	DECLARE @estado_actual bit
	DECLARE @estado_anterior bit
	DECLARE @rol_estado_deshabilitado bit
	DECLARE @rol_usuario_estado_deshabilitado bit
	
	--REEMPLAZAR EL 1 por el valor real que signifique que este deshabilitado en tabla ROL
	SET @rol_estado_deshabilitado = 1
	
	--REEMPLAZAR EL 1 por el valor real que signifique que este deshabilitado en tabla ROL_USUARIO
	SET @rol_usuario_estado_deshabilitado = 1

	SELECT @estado_actual = rol_Estado, @rol = rol_CodRol  from inserted;
	SET @estado_anterior = (SELECT rol_Estado from deleted);
	IF (@estado_actual = @rol_estado_deshabilitado and @estado_actual <> @estado_anterior )
		UPDATE Rol_Usuario set rous_Estado = @rol_usuario_estado_deshabilitado where rous_CodRol = @rol
END
GO
/****** Object:  Trigger [BLOQUEAR_USUARIO]    Script Date: 12/04/2013 22:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [LOS_BORBOTONES].[BLOQUEAR_USUARIO] ON [LOS_BORBOTONES].[Usuario] AFTER UPDATE
AS
BEGIN
	DECLARE @intentos int
	DECLARE @usuario varchar(10)
	
	SELECT @intentos = usu_IntentosFallidos, @usuario = usu_IdUsuario  from inserted;
	IF (@intentos = 3)
		UPDATE Usuario set usu_Estado = 1 WHERE usu_IdUsuario = @usuario
END
GO
