--
-- ER/Studio 8.0 SQL Code Generation
-- Company :      HP Inc.
-- Project :      ClinicaGeneral.DM1
-- Author :       Windows User
--
-- Date Created : Sunday, May 19, 2019 17:08:09
-- Target DBMS : PostgreSQL 8.0
--

-- 
-- TABLE: "ExploracionGeneral" 
--

CREATE TABLE ExploracionGeneral(
    idExploracionGeneral  serial PRIMARY KEY NOT NULL,
    idExpediente          int4            NOT NULL,
    EdoConciencia        boolean,
    marcha                  varchar(10),
    hidratacion             boolean,
    coloracion              varchar(10),
    valoracion              varchar(10),
    observacion             varchar(200)
    
)
;



-- 
-- TABLE: "ExploracionRegional" 
--

CREATE TABLE ExploracionRegional(
    idExploracionRegional  serial PRIMARY KEY NOT NULL,
    idExpediente           int4            NOT NULL,
    region                   varchar(10),
    elemento                 varchar(10),
    estado                   boolean,
    valoracion               varchar(10),
    observacion              varchar(200)
   
)
;



-- 
-- TABLE: "PadecimientoActual" 
--

CREATE TABLE PadecimientoActual (
    idPadecimiento  serial PRIMARY KEY        NOT NULL,
    idExpediente    int4            NOT NULL,
    descripcion       varchar(20),
    valoracion        varchar(10),
    observacion       varchar(300)
   
)
;



-- 
-- TABLE: "SignoVital" 
--

CREATE TABLE SignoVital(
    idSignoVital serial PRIMARY KEY           NOT NULL,
    idExpediente  int4            NOT NULL,
    ta              varchar(10),
    fc              varchar(10),
    temperatura     varchar(10),
    peso            varchar(10),
    talla           varchar(10),
    resultado       varchar(20),    
    observacion     varchar(300)
    
)
;



-- 
-- TABLE: "SintomaGeneral" 
--

CREATE TABLE SintomaGeneral(
    idSintomaGeneral  serial    PRIMARY KEY         NOT NULL,
    idExpediente      int4            NOT NULL,
    sintoma             varchar(15),
    valoracion          varchar(10),
    observacion         varchar(300)
   
)
;



