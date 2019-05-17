--
-- ER/Studio 8.0 SQL Code Generation
-- Company :      HP Inc.
-- Project :      ClinicaGeneral.DM1
-- Author :       Windows User
--
-- Date Created : Tuesday, May 14, 2019 17:50:22
-- Target DBMS : PostgreSQL 8.0
--

-- 
-- TABLE: "ElementoEvaluacionSigno" 
--

CREATE TABLE ElementoEvaluacionSigno(
    idSignoEvaluar  serial           NOT NULL PRIMARY KEY,
    nombreSigno      varchar(50)    NOT NULL
    
)
;



-- 
-- TABLE: "ElementoGeneral" 
--

CREATE TABLE ElementoGeneral(
    idElementoEvaluar  serial          NOT NULL PRIMARY KEY,
    nombreElto         varchar(50)    NOT NULL
    
)
;



-- 
-- TABLE: "ElementoRegionEvaluar" 
--

CREATE TABLE ElementoRegionEvaluar (
    idElementoRegion     serial            NOT NULL PRIMARY KEY,
    idEstadoElto         int4            NOT NULL,
    idRegion             int4            NOT NULL,
    nombreEltoExplorado  varchar(100)    NOT NULL
  )
;



-- 
-- TABLE: "EstadoElementoRegion" 
--

CREATE TABLE EstadoElementoRegion(
    idEstadoElto      serial            NOT NULL PRIMARY KEY,
    idRegion          int4            NOT NULL,
    nombreEstadoElto  varchar(100)    NOT NULL
   
)
;



-- 
-- TABLE: "ExploracionGeneral" 
--

CREATE TABLE ExploracionGeneral (
    idExploracionGeneral  serial           NOT NULL PRIMARY KEY,
    idElementoEvaluar     int4            NOT NULL,
    idExpediente          int4            NOT NULL,
    valoracion              varchar(10),
    observacion             varchar(200)
   )
;



-- 
-- TABLE: "ExploracionRegional" 
--

CREATE TABLE ExploracionRegional(
    idExploracionRegional  serial            NOT NULL PRIMARY KEY,
    idElementoRegion       int4            NOT NULL,
    idEstadoElto          int4            NOT NULL,
    idRegion               int4            NOT NULL,
    idExpediente           int4            NOT NULL,
    valoracion               varchar(10),
    observacion              varchar(200)
   )
;



-- 
-- TABLE: "PadecimientoActual" 
--

CREATE TABLE PadecimientoActual (
    idPadecimiento  serial            NOT NULL PRIMARY KEY,
    idExpediente    int4            NOT NULL,
    valoracion        varchar(10),
    observacion       varchar(300)    NOT NULL
   
)
;



-- 
-- TABLE: "Region" 
--

CREATE TABLE Region(
    idRegion         serial            NOT NULL PRIMARY KEY,
    regionExplorada  varchar(100)    NOT NULL
   
)
;



-- 
-- TABLE: "SignoVital" 
--

CREATE TABLE SignoVital(
    idSignoVital    serial NOT NULL PRIMARY KEY,
    idSignoEvaluar  int4            NOT NULL,
    idExpediente    int4            NOT NULL,
    resultado         varchar(20)     NOT NULL,
    observacion       varchar(300)
    
)
;



-- 
-- TABLE: "Sintoma" 
--

CREATE TABLE Sintoma(
    codigoSintoma  serial NOT NULL PRIMARY KEY,
    descripcion       varchar(100)    NOT NULL,
    observacion       varchar(300)
);



-- 
-- TABLE: "SintomaGeneral" 
--

CREATE TABLE SintomaGeneral(
    idSintomaGeneral  serial            NOT NULL PRIMARY KEY,
    codigoSintoma    int4            NOT NULL,
    idExpediente      int4            NOT NULL,
    valoracion          varchar(10),
    observacion         varchar(300)
   )
;



