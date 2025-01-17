-- Criação do Banco de Dados
CREATE DATABASE SistemaFarmaceutico;
GO

USE master ;  
GO  
DROP DATABASE SistemaFarmaceutico;  
GO

USE SistemaFarmaceutico;
GO

-- Tabela Categorias
CREATE TABLE Categorias (
    CategoriaID INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(100) NOT NULL UNIQUE,
    Descricao NVARCHAR(255)
);

-- Tabela Funcionários
CREATE TABLE Funcionarios (
    FuncionarioID INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(100) NOT NULL,
    BI NVARCHAR(14) UNIQUE NOT NULL,
    Telefone NVARCHAR(20),
    Email NVARCHAR(100),
    Endereco NVARCHAR(255),
    DataAdmissao DATE NOT NULL DEFAULT GETDATE(),
    Cargo NVARCHAR(50),
    Salario DECIMAL(10,2),
    Status NVARCHAR(20) DEFAULT 'Ativo' -- Ativo/Inativo
);

/*
-- Tabela Usuários
CREATE TABLE Usuarios (
    UsuarioID INT PRIMARY KEY IDENTITY(1,1),
    Login NVARCHAR(50) NOT NULL UNIQUE,
    Senha VARBINARY(256) NOT NULL,
    NivelPermissao NVARCHAR(50) NOT NULL, -- Exemplo: Admin, Farmacêutico, Atendente
    FuncionarioID INT, -- Relacionamento com Funcionários
    FOREIGN KEY (FuncionarioID) REFERENCES Funcionarios(FuncionarioID)
);
*/


-- Tabela Fornecedores
CREATE TABLE Fornecedores (
    FornecedorID INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(100) NOT NULL UNIQUE,
    Telefone NVARCHAR(20),
    Endereco NVARCHAR(255),
    NIF NVARCHAR(20) NOT NULL UNIQUE
);

-- Tabela Produtos
CREATE TABLE Produtos (
    ProdutoID INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(100) NOT NULL,
    Descricao NVARCHAR(150),
    CategoriaID INT NOT NULL, -- Relacionamento com Categorias
    Preco DECIMAL(10,2) NOT NULL,
    Estoque INT NOT NULL,
    DataValidade DATE,
    FornecedorID INT NOT NULL, -- Relacionamento com Fornecedores
	Status NVARCHAR(20) DEFAULT 'Ativo',
	CONSTRAINT CHK_Status CHECK (Status IN ('Ativo', 'Inativo', 'Esgotado')),
    CONSTRAINT CHK_Preco_Positive CHECK (Preco >= 0),
    CONSTRAINT CHK_Estoque_Positive CHECK (Estoque >= 0),
    FOREIGN KEY (CategoriaID) REFERENCES Categorias(CategoriaID),
    FOREIGN KEY (FornecedorID) REFERENCES Fornecedores(FornecedorID)
);

-- Tabela Clientes
CREATE TABLE Clientes (
    ClienteID INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(100) NOT NULL,
    Telefone NVARCHAR(20),
    Endereco NVARCHAR(255)
);

-- Tabela Vendas
CREATE TABLE Vendas (
    VendaID INT PRIMARY KEY IDENTITY(1,1),
    ClienteID INT NOT NULL,
    -- UsuarioID INT NOT NULL, -- Relacionamento com Usuários (quem realizou a venda)
	Status NVARCHAR(20) NOT NULL DEFAULT 'Pendente',
    DataVenda DATETIME NOT NULL DEFAULT GETDATE(),
    Total DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (ClienteID) REFERENCES Clientes(ClienteID),
    -- FOREIGN KEY (UsuarioID) REFERENCES Usuarios(UsuarioID)
);

-- Tabela DetalhesVendas
CREATE TABLE DetalhesVendas (
    DetalheID INT PRIMARY KEY IDENTITY(1,1),
    VendaID INT NOT NULL,
    ProdutoID INT NOT NULL,
    Quantidade INT NOT NULL,
    PrecoUnitario DECIMAL(10,2) NOT NULL,
	totalItem DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (VendaID) REFERENCES Vendas(VendaID),
    FOREIGN KEY (ProdutoID) REFERENCES Produtos(ProdutoID)
);

-- Inserção de Categorias
INSERT INTO Categorias (Nome, Descricao) VALUES 
    ('Analgésico', 'Medicamentos para dor'),
    ('Antibiótico', 'Medicamentos para infecções'),
    ('Vitaminas', 'Suplementos vitamínicos'),
    ('Antiácido', 'Medicamentos para problemas gástricos');

-- Inserção de Fornecedores
INSERT INTO Fornecedores (Nome, Telefone, Endereco, NIF) VALUES
    ('Farmácia Central', '923000001', 'Rua da Paz, Luanda', '123456789012'),
    ('Distribuidora Saúde', '924000002', 'Avenida da Liberdade, Luanda', '987654321098'),
    ('Medicamentos Angola', '925000003', 'Rua das Acácias, Luanda', '112233445566'),
    ('Importadora Farma', '926000004', 'Avenida Marginal, Luanda', '667788990011');

-- Inserção de Funcionários
INSERT INTO Funcionarios (Nome, BI, Telefone, Email, Endereco, DataAdmissao, Cargo, Salario, Status) VALUES
    ('Carlos Silva', '12345678901234', '923555555', 'carlos.silva@email.com', 'Rua das Acácias, Luanda', '2023-01-15', 'Farmacêutico', 250000.00, 'Ativo'),
    ('Joana Pereira', '98765432109876', '924555555', 'joana.pereira@email.com', 'Avenida 21 de Janeiro, Luanda', '2022-08-10', 'Atendente', 120000.00, 'Ativo'),
    ('António Carvalho', '11223344557788', '925555555', 'antonio.carvalho@email.com', 'Rua do Comércio, Luanda', '2021-11-05', 'Gestor de Estoque', 200000.00, 'Ativo'),
    ('Maria Fernandes', '66778899001122', '926555555', 'maria.fernandes@email.com', 'Avenida da Liberdade, Luanda', '2020-03-30', 'Vendedora', 100000.00, 'Inativo');

-- Inserção de Produtos com Status
INSERT INTO Produtos (Nome, Descricao, CategoriaID, Preco, Estoque, DataValidade, FornecedorID, Status) VALUES
    ('Paracetamol', 'Comprimido', 1, 500.00, 200, '2025-12-31', 1, 'Inativo'),
    ('Ibuprofeno', 'Comprimido', 1, 150.00, 300, '2025-06-30', 2, 'Ativo'),
    ('Dipirona', 'Comprimido', 1, 200.00, 150, '2025-10-15', 1, 'Ativo'),
    ('Aspirina', 'Comprimido', 1, 90.00, 500, '2025-05-20', 2, 'Ativo'),
    ('Amoxicilina', 'Cápsula', 2, 300.00, 250, '2025-08-20', 2, 'Ativo'),
    ('Ciprofloxacino', 'Comprimido', 2, 120.00, 400, '2026-02-10', 1, 'Ativo'),
    ('Azitromicina', 'Comprimido', 2, 180.00, 500, '2026-01-05', 2, 'Ativo'),
    ('Clindamicina', 'Cápsula', 2, 250.00, 350, '2025-07-15', 1, 'Ativo'),
    ('Vitamina C', 'Comprimido Efervescente', 3, 80.00, 1000, '2025-10-10', 1, 'Ativo'),
    ('Vitamina D', 'Comprimido', 3, 90.00, 800, '2025-12-20', 1, 'Ativo'),
    ('Vitamina B12', 'Comprimido', 3, 70.00, 600, '2025-11-10', 2, 'Ativo'),
    ('Ácido Fólico', 'Comprimido', 3, 65.00, 500, '2025-09-25', 2, 'Ativo'),
    ('Omeprazol', 'Cápsula', 4, 100.00, 500, '2026-03-20', 2, 'Ativo'),
    ('Pantoprazol', 'Comprimido', 4, 120.00, 600, '2026-05-10', 1, 'Ativo'),
    ('Ranitidina', 'Comprimido', 4, 90.00, 700, '2025-06-30', 1, 'Ativo'),
    ('Esomeprazol', 'Comprimido', 4, 110.00, 400, '2025-11-05', 2, 'Ativo'),
    ('Loratadina', 'Comprimido', 1, 40.00, 350, '2025-12-25', 1, 'Ativo'),
    ('Cetirizina', 'Comprimido', 1, 45.00, 500, '2025-08-15', 1, 'Ativo'),
    ('Fexofenadina', 'Comprimido', 1, 60.00, 250, '2025-10-20', 2, 'Ativo'),
    ('Levocetirizina', 'Comprimido', 1, 50.00, 450, '2025-09-05', 2, 'Ativo'),
    ('Xarope Antialérgico', 'Xarope', 1, 80.00, 300, '2025-07-10', 1, 'Ativo'),
    ('Simeticona', 'Gotas', 1, 50.00, 600, '2025-09-12', 2, 'Ativo'),
    ('Dipirona Sódica', 'Solução', 1, 100.00, 550, '2025-08-30', 1, 'Ativo'),
    ('Suplemento Multivitamínico', 'Comprimido', 3, 100.00, 900, '2025-10-05', 2, 'Ativo'),
    ('Óleo de Peixe', 'Cápsula', 3, 150.00, 700, '2025-11-25', 1, 'Ativo'),
    ('Magnésio', 'Comprimido', 3, 90.00, 800, '2025-12-15', 2, 'Ativo'),
    ('Melatonina', 'Comprimido', 3, 120.00, 650, '2025-09-10', 1, 'Ativo'),
    ('Doxiciclina', 'Comprimido', 2, 70.00, 500, '2025-11-10', 2, 'Ativo'),
    ('Tetraciclina', 'Comprimido', 2, 90.00, 400, '2025-12-20', 1, 'Ativo'),
    ('Metronidazol', 'Comprimido', 2, 120.00, 350, '2025-08-05', 2, 'Ativo'),
    ('Amoxicilina + Ácido Clavulânico', 'Comprimido', 2, 130.00, 300, '2025-07-10', 1, 'Ativo'),
    ('Sulfametoxazol', 'Comprimido', 2, 60.00, 500, '2025-06-25', 2, 'Ativo'),
    ('Cloroquina', 'Comprimido', 2, 250.00, 250, '2025-10-30', 1, 'Ativo'),
    ('Ibuprofeno + Paracetamol', 'Comprimido', 1, 140.00, 600, '2025-09-15', 2, 'Ativo'),
    ('Dipirona + Cafeína', 'Comprimido', 1, 90.00, 700, '2025-12-05', 1, 'Ativo'),
    ('Hidroxicloroquina', 'Comprimido', 2, 220.00, 300, '2025-10-25', 2, 'Ativo'),
    ('Furosemida', 'Comprimido', 4, 70.00, 800, '2025-11-05', 1, 'Ativo'),
    ('Lisinopril', 'Comprimido', 4, 120.00, 900, '2025-09-30', 2, 'Ativo'),
    ('Amlodipina', 'Comprimido', 4, 110.00, 1000, '2025-10-15', 1, 'Ativo'),
    ('Captopril', 'Comprimido', 4, 60.00, 600, '2025-12-10', 2, 'Ativo'),
    ('Atorvastatina', 'Comprimido', 4, 150.00, 500, '2025-07-15', 1, 'Ativo'),
    ('Sinvastatina', 'Comprimido', 4, 140.00, 400, '2025-08-01', 2, 'Ativo'),
    ('Bromazepam', 'Comprimido', 1, 50.00, 450, '2025-09-20', 1, 'Ativo'),
    ('Alprazolam', 'Comprimido', 1, 60.00, 500, '2025-10-05', 2, 'Ativo'),
    ('Diazepam', 'Comprimido', 1, 45.00, 600, '2025-11-10', 1, 'Ativo'),
    ('Clonazepam', 'Comprimido', 1, 80.00, 550, '2025-12-15', 2, 'Ativo'),
    ('Diazepam Xarope', 'Xarope', 1, 90.00, 200, '2025-10-20', 1, 'Ativo'),
    ('Fluoxetina', 'Comprimido', 1, 75.00, 700, '2025-12-10', 2, 'Ativo'),
    ('Sertralina', 'Comprimido', 1, 80.00, 500, '2025-09-15', 1, 'Ativo'),
    ('Paroxetina', 'Comprimido', 1, 70.00, 800, '2025-11-05', 2, 'Ativo'),
    ('Metformina', 'Comprimido', 4, 90.00, 1000, '2025-12-30', 1, 'Ativo'),
    ('Gliclazida', 'Comprimido', 4, 120.00, 400, '2025-07-20', 2, 'Ativo');

INSERT INTO Clientes (Nome, Telefone, Endereco) VALUES 
	('Manuel António', '+244 923 456 789', 'Rua 1º de Maio, Luanda'),
	('Ana Maria', '+244 924 567 890', 'Avenida Revolução de Outubro, Benguela'),
	('José Domingos', '+244 925 678 901', 'Rua do Comércio, Lobito'),
	('Maria do Carmo', '+244 926 789 012', 'Praça da Independência, Huambo'),
	('Fernando João', '+244 927 890 123', 'Bairro Miramar, Luanda'),
	('Sofia da Silva', '+244 928 901 234', 'Rua Direita, Lubango'),
	('Carlos Alberto', '+244 929 012 345', 'Avenida das Forças Armadas, Namibe'),
	('Luísa Figueiredo', '+244 930 123 456', 'Rua Ngola Kiluanje, Malanje'),
	('Pedro Sebastião', '+244 931 234 567', 'Bairro Popular, Soyo'),
	('Clara Fernandes', '+244 932 345 678', 'Rua da Paz, Cabinda');



-- Inserção de Usuários
INSERT INTO Usuarios (Login, Senha, NivelPermissao, FuncionarioID) VALUES 
    ('joao.farma', HASHBYTES('SHA2_256', 'joao123'), 'Farmaceutico', 1),
    ('maria.atendente', HASHBYTES('SHA2_256', 'maria123'), 'Atendente', 2),
    ('carlos.gerente', HASHBYTES('SHA2_256', 'carlos123'), 'Gerente', 3);

-- Selecionando os dados das tabelas principais
SELECT * FROM Categorias;
SELECT * FROM Fornecedores;
SELECT * FROM Produtos;
SELECT * FROM Funcionarios;
SELECT * FROM Usuarios;
SELECT * FROM Clientes;
SELECT * FROM Vendas;
SELECT * FROM DetalhesVendas;
