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
SELECT * FROM tbProduto WHERE Nome LIKE '%An%';

CREATE TABLE tbCliente(
ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
Nome VARCHAR(50) NOT NULL UNIQUE,
Endereco VARCHAR(50) NOT NULL,
Telefone VARCHAR(20) NOT NULL UNIQUE,
);

SELECT * FROM tbCliente

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

--EXEC sp_help 'tbCategoria';

SELECT * FROM tbCategoria
ORDER BY ID ASC;
 
 --Inserindo dados na tabela Usuarios
 INSERT INTO tbUsuario (Nome, Login, SenhaHash, NivelAcesso, Ativo)
VALUES
('Moisés TChipanga', 'mt@newpharma', HASHBYTES('SHA2_256', 'senha123'), 1, 1),
('João Silva', 'joaosilva@newpharma', HASHBYTES('SHA2_256', 'senha123'), 2, 1),
('Maria Oliveira', 'mariaoliveira@newpharma', HASHBYTES('SHA2_256', 'senha123'), 3, 1);
SELECT * FROM tbUsuario

--Inserindo dados na tabela Categoria
INSERT INTO Categoria (ID, Nome) VALUES
(1, 'Analgésicos'),
(2, 'Antibióticos'),
(3, 'Antifúngicos'),
(4, 'Antiácidos'),
(5, 'Ansiolíticos'),
(6, 'Vitaminas'),
(7, 'Antiinflamatórios'),
(8, 'Antidepressivos'),
(9, 'Antivirais'),
(10, 'Antihipertensivos'),
(11, 'Anticonvulsivantes'),
(12, 'Diuréticos'),
(13, 'Anticoagulantes'),
(14, 'Antialérgicos'),
(15, 'Laxantes');

--Inserindo dados na tabela Cliente
INSERT INTO tbCliente (Nome, Endereco, Telefone) VALUES
('João Silva', 'Rua A, 123', '987654321'),
('Maria Oliveira', 'Rua B, 456', '912345678'),
('Pedro Santos', 'Rua C, 789', '923456789'),
('Ana Costa', 'Rua D, 101', '934567890'),
('Carlos Pereira', 'Rua E, 202', '945678901'),
('Fernanda Lima', 'Rua F, 303', '956789012'),
('Luciana Souza', 'Rua G, 404', '967890123'),
('Rafael Alves', 'Rua H, 505', '978901234'),
('Juliana Ribeiro', 'Rua I, 606', '989012345'),
('Roberto Martins', 'Rua J, 707', '991123456'),
('Marta Rocha', 'Rua K, 808', '922234567'),
('Lucas Gomes', 'Rua L, 909', '933345678'),
('Tatiane Alves', 'Rua M, 1010', '944456789'),
('Gustavo Pinto', 'Rua N, 1111', '955567890'),
('Camila Castro', 'Rua O, 1212', '966678901');

--Inserindo dados na tabela Fornecedor
INSERT INTO tbFornecedor (Nome, NIF, Endereco, Telefone, E_mail) VALUES
('Fornecedor Alpha', '123456789', 'Rua A, 123', '987654321', 'alpha@fornecedor.com'),
('Fornecedor Beta', '234567890', 'Rua B, 456', '912345678', 'beta@fornecedor.com'),
('Fornecedor Gamma', '345678901', 'Rua C, 789', '923456789', 'gamma@fornecedor.com'),
('Fornecedor Delta', '456789012', 'Rua D, 101', '934567890', 'delta@fornecedor.com'),
('Fornecedor Epsilon', '567890123', 'Rua E, 202', '945678901', 'epsilon@fornecedor.com'),
('Fornecedor Zeta', '678901234', 'Rua F, 303', '956789012', 'zeta@fornecedor.com'),
('Fornecedor Eta', '789012345', 'Rua G, 404', '967890123', 'eta@fornecedor.com'),
('Fornecedor Theta', '890123456', 'Rua H, 505', '978901234', 'theta@fornecedor.com'),
('Fornecedor Iota', '901234567', 'Rua I, 606', '989012345', 'iota@fornecedor.com'),
('Fornecedor Kappa', '012345678', 'Rua J, 707', '991123456', 'kappa@fornecedor.com'),
('Fornecedor Lambda', '112345679', 'Rua K, 808', '922234567', 'lambda@fornecedor.com'),
('Fornecedor Mu', '212345670', 'Rua L, 909', '933345678', 'mu@fornecedor.com'),
('Fornecedor Nu', '312345671', 'Rua M, 1010', '944456789', 'nu@fornecedor.com'),
('Fornecedor Xi', '412345672', 'Rua N, 1111', '955567890', 'xi@fornecedor.com'),
('Fornecedor Omicron', '512345673', 'Rua O, 1212', '966678901', 'omicron@fornecedor.com');

--Inserindo dados na tabela Produto
INSERT INTO tbProduto (Nome, Descricao, Quant_Estoque, Preco, DataValidade, CategoriaID, FornecedorID) VALUES
('Paracetamol 500mg', 'Analgésico para dor e febre', 100, 500.00, '2026-01-01', 1, 1),
('Ibuprofeno 400mg', 'Antiinflamatório e analgésico', 120, 700.00, '2026-02-01', 7, 2),
('Amoxicilina 500mg', 'Antibiótico para infecções', 80, 1000.00, '2026-03-01', 2, 3),
('Dipirona 500mg', 'Analgésico e antitérmico', 150, 350.00, '2026-04-01', 1, 4),
('Cetoconazol 200mg', 'Antifúngico tópico', 60, 800.00, '2026-05-01', 3, 5),
('Omeprazol 20mg', 'Antiácido para refluxo', 200, 1200.00, '2026-06-01', 4, 6),
('Lorazepam 2mg', 'Ansiolítico para ansiedade', 50, 1500.00, '2026-07-01', 5, 7),
('Vitamin C 500mg', 'Suplemento vitamínico', 250, 400.00, '2026-08-01', 6, 8),
('Ranitidina 150mg', 'Antiácido para úlceras', 100, 600.00, '2026-09-01', 4, 9),
('Azitromicina 500mg', 'Antibiótico de amplo espectro', 900, 9.00, '2026-10-01', 2, 10),
('Prednisona 20mg', 'Corticosteroide anti-inflamatório', 750, 18.00, '2026-11-01', 7, 11),
('Clonazepam 1mg', 'Ansiolítico e anticonvulsivante', 60, 2000.00, '2026-12-01', 5, 12),
('Doxiciclina 100mg', 'Antibiótico para infecções específicas', 400, 250.00, '2026-01-15', 2, 13),
('Fluoxetina 20mg', 'Antidepressivo para ansiedade e depressão', 900, 220.00, '2026-02-15', 8, 14),
('Captopril 25mg', 'Anti-hipertensivo para pressão alta', 100, 400.00, '2026-03-15', 10, 15);




