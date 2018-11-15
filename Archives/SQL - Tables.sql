/*-------------------------------------------------------------------------------------------*/
DROP TABLE IF EXISTS medicos;
DROP SEQUENCE IF EXISTS id_med_seq;

CREATE sequence id_med_seq
    INCREMENT 1
    MINVALUE 1
    MAXVALUE 9223372036854775807
    START 1
    CACHE 1;
CREATE TABLE medicos
(
    id_med          BIGINT Default nextval('id_med_seq') NOT NULL,
    nome            CHARACTER VARYING(40) NOT NULL,
    sobrenome       CHARACTER VARYING(60) NOT NULL,
    cpf             BIGINT UNIQUE NOT NULL,
    sexo            CHAR NOT NULL,
    data_nascm      DATE NOT NULL,
    celular         BIGINT NOT NULL,
    senha           CHARACTER VARYING(100) NOT NULL,
	excluido		BOOLEAN NOT NULL,
    
    CONSTRAINT id_med_pk PRIMARY KEY (id_med)
);
/*-------------------------------------------------------------------------------------------*/
DROP SEQUENCE IF EXISTS id_pac_seq;
DROP TABLE IF EXISTS pacientes;

CREATE sequence id_pac_seq
    INCREMENT 1
    MINVALUE 1
    MAXVALUE 9223372036854775807
    START 1
    CACHE 1;
CREATE TABLE pacientes
(
    id_pac          BIGINT Default nextval('id_pac_seq') NOT NULL,
    nome            CHARACTER VARYING(40) NOT NULL,
    sobrenome       CHARACTER VARYING(60) NOT NULL,
    cpf             BIGINT UNIQUE NOT NULL,
    sexo            CHAR NOT NULL,
    data_nascm      DATE NOT NULL,
    celular         BIGINT NOT NULL,
    senha           CHARACTER VARYING(100) NOT NULL,
	excluido		BOOLEAN NOT NULL,
    
    CONSTRAINT id_pac_pk PRIMARY KEY (id_pac)
);
/*-------------------------------------------------------------------------------------------*/
DROP SEQUENCE IF EXISTS id_cons_seq;
DROP TABLE IF EXISTS consultas;

CREATE sequence id_cons_seq
    INCREMENT 1
    MINVALUE 1
    MAXVALUE 9223372036854775807
    START 1
    CACHE 1;
CREATE TABLE consultas
(
    id_cons     BIGINT Default nextval('id_cons_seq') NOT NULL,
    id_med      INT NOT NULL,
    id_pac      INT NOT NULL,
    data_cons   DATE NOT NULL,
    hora_cons   CHARACTER VARYING(6) NOT NULL,
    tipo        CHARACTER VARYING(20) NOT NULL,
    convenio    CHARACTER VARYING(20) NOT NULL,
    unicode     CHARACTER VARYING(13) NOT NULL UNIQUE,
	excluido	BOOLEAN NOT NULL,
    
    CONSTRAINT id_cons_pk PRIMARY KEY (id_cons),
    CONSTRAINT id_med_fk FOREIGN KEY (id_med) REFERENCES medicos(id_med),
    CONSTRAINT id_pac_fk FOREIGN KEY (id_pac) REFERENCES pacientes(id_pac)
);
/*-------------------------------------------------------------------------------------------*/