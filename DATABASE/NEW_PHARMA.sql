CREATE DATABASE NEW_PHARMA

USE NEW_PHARMA

CREATE TABLE tbUsuario (
    ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Nome VARCHAR(50) NOT NULL,
    Login VARCHAR(50) NOT NULL UNIQUE,
    SenhaHash NVARCHAR(MAX) NOT NULL,
    NivelAcesso INT NOT NULL,
    Ativo BIT NOT NULL DEFAULT 1
);

SELECT * FROM tbUsuario 

CREATE TABLE tbFornecedor(
ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
Nome VARCHAR(50) NOT NULL,
NIF VARCHAR(25) NOT NULL UNIQUE,
Endereco VARCHAR(50) NOT NULL,
Telefone VARCHAR(20) NOT NULL UNIQUE,
E_mail VARCHAR(50) NOT NULL,
);

SELECT * FROM tbFornecedor

CREATE TABLE tbCategoria(
ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
Nome VARCHAR(50) NOT NULL UNIQUE,
);

SELECT * FROM tbCategoria

CREATE TABLE tbProduto(
ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
Nome VARCHAR(100) NOT NULL,
Descricao nvarchar(max),
Quant_Estoque INT,
Preco DECIMAL NOT NULL,
DataValidade DATETIME NOT NULL,
CategoriaID INT,
FornecedorID INT,
FOREIGN KEY(FornecedorID) REFERENCES tbFornecedor(ID),
FOREIGN KEY(CategoriaID) REFERENCES tbCategoria(ID),
);

SELECT * FROM tbProduto

CREATE TABLE tbCliente(
ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
Nome VARCHAR(50) NOT NULL UNIQUE,
Endereco VARCHAR(50) NOT NULL,
Telefone VARCHAR(20) NOT NULL UNIQUE,
);

SELECT * FROM tbCliente

SELECT * FROM tbCategoria WHERE Nome LIKE '%An%';

CREATE TABLE tbVenda(
ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
DATA DATETIME,
ClienteID INT,
ProdutoID INT,
Quantidade INT NOT NULL,
Valor_Total DECIMAL NOT NULL,
FOREIGN KEY (ClienteID) REFERENCES tbCliente(ID),
FOREIGN KEY (ProdutoID) REFERENCES tbProduto(ID),
);

SELECT * FROM tbVenda

CREATE TABLE tbItem_Vendido(
ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
VendaID INT,
ProdutoID INT,
Quantidade INT NOT NULL,
Preco_Unitario DECIMAL NOT NULL,
FOREIGN KEY(VendaID) REFERENCES tbVenda(ID),
FOREIGN KEY(ProdutoID) REFERENCES tbProduto(ID),
);

EXEC sp_help 'tbCategoria';

SELECT * FROM tbCategoria

DELETE FROM tbCategoria
WHERE ID = 21;

UPDATE tbUsuario
SET NivelAcesso = 3
WHERE ID = 6;




SELECT * FROM tbCategoria
ORDER BY ID ASC;
 
 --Inserindo dados na tabela Usuarios
 INSERT INTO tbUsuario (Nome, Login, SenhaHash, NivelAcesso, Ativo)
VALUES
('Moisés TChipanga', 'mt@newpharma', HASHBYTES('SHA2_256', 'senha123'), 1, 1),
('João Silva', 'joaosilva@newpharma', HASHBYTES('SHA2_256', 'senha123'), 2, 1),
('Maria Oliveira', 'mariaoliveira@newpharma', HASHBYTES('SHA2_256', 'senha123'), 2, 1);
SELECT * FROM tbUsuario

SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Categoria';
SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Categoria';

INSERT INTO tbCategoria (Nome) VALUES (''); SELECT SCOPE_IDENTITY();

SELECT DB_NAME();


--SELECT 
  --  v.ID,
  --  v.DATA,
  --	v.ClienteID,
  --  c.Nome,
  --  v.Valor_Total,
  --  v.FuncionarioID,
  --  f.Nome
--FROM 
  --  tbVenda v
--JOIN 
  --  tbFuncionario f ON v.FuncionarioID = f.ID
--JOIN 
  --  tbCliente c ON v.ClienteID = c.ID
--WHERE 
  --  v.DATA BETWEEN '2025-01-01' AND '2025-01-31' -- Período para o relatório
--ORDER BY 
  --  v.DATA DESC;


