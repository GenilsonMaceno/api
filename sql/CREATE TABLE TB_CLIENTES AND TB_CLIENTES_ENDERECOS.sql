USE GTI_DATA_SERVER
GO

--DROP TABLE DBO.TB_CLIENTES
--DROP TABLE DBO.TB_CLIENTES_ENDERECOS

CREATE TABLE DBO.TB_CLIENTES
(
	CLIENTE_ID NUMERIC(15,0) IDENTITY (1,1),
	CPF VARCHAR(20) NOT NULL,
	NOME VARCHAR(50) NOT NULL,
	RG VARCHAR(20),
	DATA_EXPEDICAO DATETIME,
	ORGAO_EXPEDICAO VARCHAR(20),
	UF_EXPEDICAO CHAR(2),
	DATA_NASCIMENTO DATETIME NOT NULL,
	SEXO VARCHAR(20) NOT NULL,
	ESTADO_CIVIL VARCHAR(20) NOT NULL
)
GO

CREATE TABLE DBO.TB_CLIENTES_ENDERECOS
(
	ENDERECO_ID NUMERIC(15,0) IDENTITY (1,1),
	CEP VARCHAR(20) NOT NULL,
	LOGRADOURO VARCHAR(50) NOT NULL,
	NUMERO VARCHAR(20) NOT NULL,
	COMPLEMENTO VARCHAR(30) NOT NULL,
	BAIRRO VARCHAR(30) NOT NULL,
	CIDADE VARCHAR(20) NOT NULL,
	UF CHAR(2) NOT NULL,
	CLIENTE_ID NUMERIC(15,0) NOT NULL
)
GO


ALTER TABLE dbo.TB_CLIENTES
   ADD CONSTRAINT PK_TB_CLIENTES_CLIENTE_ID PRIMARY KEY NONCLUSTERED (CLIENTE_ID);
GO

CREATE CLUSTERED INDEX CIX_CLIENTE_ID ON DBO.TB_CLIENTES (CLIENTE_ID);
GO

ALTER TABLE dbo.TB_CLIENTES_ENDERECOS
   ADD CONSTRAINT PK_TB_CLIENTES_ENDERECOS_ENDERECO_ID PRIMARY KEY NONCLUSTERED (ENDERECO_ID);

CREATE CLUSTERED INDEX CIX_ENDERECO_ID ON DBO.TB_CLIENTES_ENDERECOS (ENDERECO_ID);
GO

ALTER TABLE TB_CLIENTES_ENDERECOS ADD CONSTRAINT FK_TB_CLIENTES_ENDERECOS_TB_CLIENTES
	FOREIGN KEY (CLIENTE_ID) REFERENCES TB_CLIENTES(CLIENTE_ID); 