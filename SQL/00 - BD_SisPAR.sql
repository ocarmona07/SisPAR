USE master
GO

CREATE DATABASE SisPAR
GO

USE SisPAR
GO

/*==============================================================*/
/* Table: DER_DERIVACION                                        */
/*==============================================================*/
CREATE TABLE dbo.DER_DERIVACION
    (
      DER_ID INT IDENTITY(1, 1) ,
      DER_FECHA DATE NOT NULL ,
      DER_REQ_ID INT NOT NULL ,
      DER_RESPONSABLE INT NOT NULL ,
      DER_OBSERVACION VARCHAR(MAX) COLLATE Modern_Spanish_CI_AS
                                   NOT NULL ,
      DER_ORIGEN_PRO INT NOT NULL ,
      DER_ORIGEN_SPO INT NOT NULL ,
      DER_ORIGEN_ANALISTA INT NULL ,
      DER_DESTINO_PRO INT NOT NULL ,
      DER_DESTINO_SPO INT NOT NULL ,
      DER_DESTINO_ANALISTA INT NULL ,
      CONSTRAINT PK_DER_DERIVACION PRIMARY KEY ( DER_ID ) ON "PRIMARY"
    )
ON  "PRIMARY"
go

/*==============================================================*/
/* Table: EPR_EMPRESA                                           */
/*==============================================================*/
CREATE TABLE dbo.EPR_EMPRESA
    (
      EPR_ID VARCHAR(9) COLLATE Modern_Spanish_CI_AS
                        NOT NULL ,
      EPR_RAZONSOCIAL VARCHAR(50) COLLATE Modern_Spanish_CI_AS
                                  NOT NULL ,
      EPR_FONO INT NOT NULL ,
      EPR_DIRECCION VARCHAR(50) COLLATE Modern_Spanish_CI_AS
                                NOT NULL ,
      EPR_SUCURSAL VARCHAR(50) COLLATE Modern_Spanish_CI_AS
                               NOT NULL ,
      CONSTRAINT PK_EPR_EMPRESA PRIMARY KEY ( EPR_ID ) ON "PRIMARY"
    )
ON  "PRIMARY"
go

/*==============================================================*/
/* Table: EST_ESTADOS                                           */
/*==============================================================*/
CREATE TABLE dbo.EST_ESTADOS
    (
      EST_ID INT IDENTITY(1, 1) ,
      EST_TIP VARCHAR(50) COLLATE Modern_Spanish_CI_AS
                          NOT NULL ,
      EST_OBS VARCHAR(MAX) COLLATE Modern_Spanish_CI_AS
                           NOT NULL ,
      CONSTRAINT PK_EST_ESTADOS PRIMARY KEY ( EST_ID ) ON "PRIMARY"
    )
ON  "PRIMARY"
go

/*==============================================================*/
/* Table: EVA_EVALUACION                                        */
/*==============================================================*/
CREATE TABLE dbo.EVA_EVALUACION
    (
      EVA_ID INT IDENTITY(1, 1) ,
      EVA_PRE_ID INT NOT NULL ,
      EVA_REQ_ID INT NOT NULL ,
      EVA_NOTA INT NOT NULL ,
      EVA_DESC VARCHAR(MAX) COLLATE Modern_Spanish_CI_AS
                            NULL ,
      CONSTRAINT PK_EVA_EVALUACION PRIMARY KEY ( EVA_ID ) ON "PRIMARY"
    )
ON  "PRIMARY"
go

/*==============================================================*/
/* Table: EVE_EVENTO                                            */
/*==============================================================*/
CREATE TABLE dbo.EVE_EVENTO
    (
      EVE_ID INT IDENTITY(1, 1) ,
      EVE_REQ_ID INT NOT NULL ,
      EVE_EST_ID INT NOT NULL ,
      EVE_NOT_ID INT NOT NULL ,
      EVE_RESPONSABLE VARCHAR(50) COLLATE Modern_Spanish_CI_AS
                                  NULL ,
      EVE_DESCRIPCION VARCHAR(MAX) COLLATE Modern_Spanish_CI_AS
                                   NOT NULL ,
      EVE_FECHA INT NULL ,
      CONSTRAINT PK_EVE_EVENTO PRIMARY KEY ( EVE_ID ) ON "PRIMARY"
    )
ON  "PRIMARY"
go

/*==============================================================*/
/* Table: HRE_HISTORIAL_REQUERIMIENTO                           */
/*==============================================================*/
CREATE TABLE dbo.HRE_HISTORIAL_REQUERIMIENTO
    (
      HRE_ID INT IDENTITY(1, 1) ,
      HRE_REQ_ID INT NOT NULL ,
      HRE_EST_ID INT NOT NULL ,
      HRE_FECHA VARCHAR(50) COLLATE Modern_Spanish_CI_AS
                            NOT NULL ,
      HRE_RESPONSABLE_REQ NCHAR(10) COLLATE Modern_Spanish_CI_AS
                                    NULL ,
      CONSTRAINT PK_HRE_HISTORIAL_REQUERIMIENTO PRIMARY KEY ( HRE_ID ) ON "PRIMARY"
    )
ON  "PRIMARY"
go

/*==============================================================*/
/* Table: NOT_NOTIFICACION                                      */
/*==============================================================*/
CREATE TABLE dbo.NOT_NOTIFICACION
    (
      NOT_ID INT IDENTITY(1, 1) ,
      NOT_NOMBRE VARCHAR(255) COLLATE Modern_Spanish_CI_AS
                              NOT NULL ,
      NOT_TITULO VARCHAR(255) COLLATE Modern_Spanish_CI_AS
                              NOT NULL ,
      NOT_ADJUNTO VARCHAR(255) COLLATE Modern_Spanish_CI_AS
                               NOT NULL ,
      NOT_ENCABEZADO VARCHAR(MAX) COLLATE Modern_Spanish_CI_AS
                                  NOT NULL ,
      NOT_DESCRIPCION_EVENTO VARCHAR(255) COLLATE Modern_Spanish_CI_AS
                                          NOT NULL ,
      NOT_ENVIAR_RDP INT NOT NULL ,
      NOT_ENVIAR_ADR INT NOT NULL ,
      NOT_ENVIAR_ANALISTA INT NOT NULL ,
      NOT_ENVIAR_SOLICITANTE INT NOT NULL ,
      CONSTRAINT PK_NOT_NOTIFICACION PRIMARY KEY ( NOT_ID ) ON "PRIMARY"
    )
ON  "PRIMARY"
go

/*==============================================================*/
/* Table: PRE_PREGUNTA                                          */
/*==============================================================*/
CREATE TABLE dbo.PRE_PREGUNTA
    (
      PRE_ID INT IDENTITY(1, 1) ,
      PRE_DESCRIPCION VARCHAR(MAX) COLLATE Modern_Spanish_CI_AS
                                   NOT NULL ,
      PRE_SECUENCIA INT NOT NULL ,
      PRE_ACTIVO INT NOT NULL ,
      CONSTRAINT PK_PRE_PREGUNTA PRIMARY KEY ( PRE_ID ) ON "PRIMARY"
    )
ON  "PRIMARY"
go

/*==============================================================*/
/* Table: PRO_PROCESO                                           */
/*==============================================================*/
CREATE TABLE dbo.PRO_PROCESO
    (
      PRO_ID INT IDENTITY(1, 1) ,
      PRO_NOMBRE VARCHAR(50) COLLATE Modern_Spanish_CI_AS
                             NOT NULL ,
      PRO_DESCRIPCION VARCHAR(MAX) COLLATE Modern_Spanish_CI_AS
                                   NOT NULL ,
      PRO_OBS VARCHAR(MAX) COLLATE Modern_Spanish_CI_AS
                           NOT NULL ,
      PRO_EPR_ID VARCHAR(9) COLLATE Modern_Spanish_CI_AS
                            NOT NULL ,
      PRO_RES_ID INT NOT NULL ,
      CONSTRAINT PK_PRO_PROCESO PRIMARY KEY ( PRO_ID ) ON "PRIMARY"
    )
ON  "PRIMARY"
go

/*==============================================================*/
/* Table: REQ_REQUERIMIENTO                                     */
/*==============================================================*/
CREATE TABLE dbo.REQ_REQUERIMIENTO
    (
      REQ_ID INT IDENTITY(1, 1) ,
      REQ_FECHA_ING DATE NOT NULL ,
      REQ_FECHA_ASIGN DATE NULL ,
      REQ_FECHA_DERIV DATE NULL ,
      REQ_FECHA_PROV DATE NULL ,
      REQ_FECHA_CIERRE_PRE DATE NULL ,
      REQ_FECHA_CIERRE_DEF DATE NULL ,
      REQ_TIPO_CIERRE VARCHAR(50) COLLATE Modern_Spanish_CI_AS
                                  NULL ,
      REQ_GLOSA_USU VARCHAR(MAX) COLLATE Modern_Spanish_CI_AS
                                 NOT NULL ,
      REQ_DESC_TEC VARCHAR(MAX) COLLATE Modern_Spanish_CI_AS
                                NULL ,
      REQ_PLAZO_ATENC INT NULL ,
      REQ_PRO_ID INT NULL ,
      REQ_SPO_ID INT NULL ,
      REQ_URG_ID INT NULL ,
      REQ_EST_ID INT NULL ,
      REQ_RES_ID INT NULL ,
      REQ_PRV_ID VARCHAR(9) COLLATE Modern_Spanish_CI_AS
                            NULL ,
      REQ_EPR_ID VARCHAR(9) COLLATE Modern_Spanish_CI_AS
                            NOT NULL ,
      REQ_USU_ID VARCHAR(9) COLLATE Modern_Spanish_CI_AS
                            NOT NULL ,
      REQ_ARC_ADJUNTO IMAGE NULL ,
      CONSTRAINT PK_REQ_REQUERIMIENTO PRIMARY KEY ( REQ_ID ) ON "PRIMARY"
    )
ON  "PRIMARY"
go

/*==============================================================*/
/* Table: RES_RESPONSABLE                                       */
/*==============================================================*/
CREATE TABLE dbo.RES_RESPONSABLE
    (
      RES_ID INT IDENTITY(1, 1) ,
      RES_TIPO_ID INT NOT NULL ,
      RES_USU_ID VARCHAR(9) COLLATE Modern_Spanish_CI_AS
                            NOT NULL ,
      CONSTRAINT PK_RES_RESPONSABLE PRIMARY KEY ( RES_ID ) ON "PRIMARY"
    )
ON  "PRIMARY"
go

/*==============================================================*/
/* Table: SPO_SUBPROCESO                                        */
/*==============================================================*/
CREATE TABLE dbo.SPO_SUBPROCESO
    (
      SPO_ID INT IDENTITY(1, 1) ,
      SPO_NOMBRE VARCHAR(50) COLLATE Modern_Spanish_CI_AS
                             NOT NULL ,
      SPO_OBSERVACION VARCHAR(MAX) COLLATE Modern_Spanish_CI_AS
                                   NOT NULL ,
      SPO_PRO_ID INT NOT NULL ,
      SPO_RES_ID INT NOT NULL ,
      CONSTRAINT PK_SPO_SUBPROCESO PRIMARY KEY ( SPO_ID ) ON "PRIMARY"
    )
ON  "PRIMARY"
go

/*==============================================================*/
/* Table: ROL_ROL                                               */
/*==============================================================*/
CREATE TABLE dbo.ROL_ROL
    (
      ROL_ID INT IDENTITY(1, 1) ,
      ROL_DESCRIPCION VARCHAR(50) COLLATE Modern_Spanish_CI_AS
                                  NOT NULL ,
      CONSTRAINT PK_ROL_ROL PRIMARY KEY ( ROL_ID ) ON "PRIMARY"
    )
ON  "PRIMARY"
go

/*==============================================================*/
/* Table: URG_URGENCIA                                          */
/*==============================================================*/
CREATE TABLE dbo.URG_URGENCIA
    (
      URG_ID INT IDENTITY(1, 1) ,
      URG_TIPO VARCHAR(50) COLLATE Modern_Spanish_CI_AS
                           NOT NULL ,
      URG_OBS VARCHAR(MAX) COLLATE Modern_Spanish_CI_AS
                           NOT NULL ,
      CONSTRAINT PK_URG_URGENCIA PRIMARY KEY ( URG_ID ) ON "PRIMARY"
    )
ON  "PRIMARY"
go

/*==============================================================*/
/* Table: USU_USUARIO                                           */
/*==============================================================*/
CREATE TABLE dbo.USU_USUARIO
    (
      USU_ID VARCHAR(9) COLLATE Modern_Spanish_CI_AS
                        NOT NULL ,
      USU_NOMBRE VARCHAR(50) COLLATE Modern_Spanish_CI_AS
                             NOT NULL ,
      USU_APELLIDO VARCHAR(50) COLLATE Modern_Spanish_CI_AS
                               NOT NULL ,
      USU_FONO INT NOT NULL ,
      USU_DIRECCION VARCHAR(100) COLLATE Modern_Spanish_CI_AS
                                 NOT NULL ,
      USU_CARGO VARCHAR(50) COLLATE Modern_Spanish_CI_AS
                            NOT NULL ,
      USU_CORREO VARCHAR(50) COLLATE Modern_Spanish_CI_AS
                             NULL ,
      USU_EPR_ID VARCHAR(9) COLLATE Modern_Spanish_CI_AS
                            NOT NULL ,
      USU_CLAVE VARCHAR(15) COLLATE Modern_Spanish_CI_AS
                            NULL ,
      CONSTRAINT PK_USU_USUARIO PRIMARY KEY ( USU_ID ) ON "PRIMARY"
    )
ON  "PRIMARY"
go

ALTER TABLE dbo.DER_DERIVACION
ADD CONSTRAINT FK_DER_DERIVACION_PRO_PROCESO FOREIGN KEY (DER_ORIGEN_PRO)
REFERENCES dbo.PRO_PROCESO (PRO_ID)
go

ALTER TABLE dbo.DER_DERIVACION
ADD CONSTRAINT FK_DER_DERIVACION_PRO_PROCESO1 FOREIGN KEY (DER_DESTINO_PRO)
REFERENCES dbo.PRO_PROCESO (PRO_ID)
go

ALTER TABLE dbo.DER_DERIVACION
ADD CONSTRAINT FK_DER_DERIVACION_REQ_REQUERIMIENTO FOREIGN KEY (DER_REQ_ID)
REFERENCES dbo.REQ_REQUERIMIENTO (REQ_ID)
go

ALTER TABLE dbo.DER_DERIVACION
ADD CONSTRAINT FK_DER_DERIVACION_SPO_SUBPROCESO FOREIGN KEY (DER_ORIGEN_SPO)
REFERENCES dbo.SPO_SUBPROCESO (SPO_ID)
go

ALTER TABLE dbo.DER_DERIVACION
ADD CONSTRAINT FK_DER_DERIVACION_SPO_SUBPROCESO1 FOREIGN KEY (DER_DESTINO_PRO)
REFERENCES dbo.SPO_SUBPROCESO (SPO_ID)
go

ALTER TABLE dbo.EVA_EVALUACION
ADD CONSTRAINT FK_EVA_EVALUACION_PRE_PREGUNTA FOREIGN KEY (EVA_PRE_ID)
REFERENCES dbo.PRE_PREGUNTA (PRE_ID)
go

ALTER TABLE dbo.EVA_EVALUACION
ADD CONSTRAINT FK_EVA_EVALUACION_REQ_REQUERIMIENTO FOREIGN KEY (EVA_REQ_ID)
REFERENCES dbo.REQ_REQUERIMIENTO (REQ_ID)
go

ALTER TABLE dbo.EVE_EVENTO
ADD CONSTRAINT FK_EVE_EVENTO_EST_ESTADOS FOREIGN KEY (EVE_EST_ID)
REFERENCES dbo.EST_ESTADOS (EST_ID)
go

ALTER TABLE dbo.EVE_EVENTO
ADD CONSTRAINT FK_EVE_EVENTO_NOT_NOTIFICACION FOREIGN KEY (EVE_NOT_ID)
REFERENCES dbo.NOT_NOTIFICACION (NOT_ID)
go

ALTER TABLE dbo.EVE_EVENTO
ADD CONSTRAINT FK_EVE_EVENTO_REQ_REQUERIMIENTO FOREIGN KEY (EVE_REQ_ID)
REFERENCES dbo.REQ_REQUERIMIENTO (REQ_ID)
go

ALTER TABLE dbo.HRE_HISTORIAL_REQUERIMIENTO
ADD CONSTRAINT FK_HRE_HISTORIAL_REQUERIMIENTO_EST_ESTADOS FOREIGN KEY (HRE_EST_ID)
REFERENCES dbo.EST_ESTADOS (EST_ID)
go

ALTER TABLE dbo.HRE_HISTORIAL_REQUERIMIENTO
ADD CONSTRAINT FK_HRE_HISTORIAL_REQUERIMIENTO_REQ_REQUERIMIENTO FOREIGN KEY (HRE_REQ_ID)
REFERENCES dbo.REQ_REQUERIMIENTO (REQ_ID)
go

ALTER TABLE dbo.PRO_PROCESO
ADD CONSTRAINT FK_PRO_PROCESO_EPR_EMPRESA FOREIGN KEY (PRO_EPR_ID)
REFERENCES dbo.EPR_EMPRESA (EPR_ID)
go

ALTER TABLE dbo.PRO_PROCESO
ADD CONSTRAINT FK_PRO_PROCESO_RES_RESPONSABLE FOREIGN KEY (PRO_RES_ID)
REFERENCES dbo.RES_RESPONSABLE (RES_ID)
go

ALTER TABLE dbo.REQ_REQUERIMIENTO
ADD CONSTRAINT FK_REQ_REQUERIMIENTO_EPR_EMPRESA FOREIGN KEY (REQ_EPR_ID)
REFERENCES dbo.EPR_EMPRESA (EPR_ID)
go

ALTER TABLE dbo.REQ_REQUERIMIENTO
ADD CONSTRAINT FK_REQ_REQUERIMIENTO_EST_ESTADOS FOREIGN KEY (REQ_EST_ID)
REFERENCES dbo.EST_ESTADOS (EST_ID)
go

ALTER TABLE dbo.REQ_REQUERIMIENTO
ADD CONSTRAINT FK_REQ_REQUERIMIENTO_PRO_PROCESO FOREIGN KEY (REQ_PRO_ID)
REFERENCES dbo.PRO_PROCESO (PRO_ID)
go

ALTER TABLE dbo.REQ_REQUERIMIENTO
ADD CONSTRAINT FK_REQ_REQUERIMIENTO_RES_RESPONSABLE FOREIGN KEY (REQ_RES_ID)
REFERENCES dbo.RES_RESPONSABLE (RES_ID)
go

ALTER TABLE dbo.REQ_REQUERIMIENTO
ADD CONSTRAINT FK_REQ_REQUERIMIENTO_SPO_SUBPROCESO FOREIGN KEY (REQ_SPO_ID)
REFERENCES dbo.SPO_SUBPROCESO (SPO_ID)
go

ALTER TABLE dbo.REQ_REQUERIMIENTO
ADD CONSTRAINT FK_REQ_REQUERIMIENTO_URG_URGENCIA FOREIGN KEY (REQ_URG_ID)
REFERENCES dbo.URG_URGENCIA (URG_ID)
go

ALTER TABLE dbo.REQ_REQUERIMIENTO
ADD CONSTRAINT FK_REQ_REQUERIMIENTO_USU_USUARIO FOREIGN KEY (REQ_USU_ID)
REFERENCES dbo.USU_USUARIO (USU_ID)
go

ALTER TABLE dbo.RES_RESPONSABLE
ADD CONSTRAINT FK_RES_RESPONSABLE_ROL_ROL FOREIGN KEY (RES_TIPO_ID)
REFERENCES dbo.ROL_ROL (ROL_ID)
go

ALTER TABLE dbo.RES_RESPONSABLE
ADD CONSTRAINT FK_RES_RESPONSABLE_USU_USUARIO FOREIGN KEY (RES_USU_ID)
REFERENCES dbo.USU_USUARIO (USU_ID)
go

ALTER TABLE dbo.SPO_SUBPROCESO
ADD CONSTRAINT FK_SPO_SUBPROCESO_PRO_PROCESO FOREIGN KEY (SPO_PRO_ID)
REFERENCES dbo.PRO_PROCESO (PRO_ID)
go

ALTER TABLE dbo.SPO_SUBPROCESO
ADD CONSTRAINT FK_SPO_SUBPROCESO_RES_RESPONSABLE FOREIGN KEY (SPO_RES_ID)
REFERENCES dbo.RES_RESPONSABLE (RES_ID)
go

ALTER TABLE dbo.USU_USUARIO
ADD CONSTRAINT FK_USU_USUARIO_EPR_EMPRESA FOREIGN KEY (USU_EPR_ID)
REFERENCES dbo.EPR_EMPRESA (EPR_ID)
go
