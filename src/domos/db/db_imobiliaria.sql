-- BANCO DE DADOS - SISTEMA IMOBILIÁRIA

CREATE DATABASE imobiliaria;
USE imobiliaria;

CREATE TABLE Endereco (
    IdEndereco INT AUTO_INCREMENT PRIMARY KEY,
    Rua VARCHAR(100) NOT NULL,
    Numero INT NOT NULL,
    Bairro VARCHAR(100) NOT NULL,
    Cidade VARCHAR(100) NOT NULL,
    Cep VARCHAR(10) NOT NULL
);

CREATE TABLE Corretor (
    IdCorretor INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Cpf VARCHAR(14) NOT NULL UNIQUE,
    Telefone VARCHAR(20) NOT NULL,
    Email VARCHAR(100) NOT NULL UNIQUE,
    Senha VARCHAR(255) NOT NULL,
    Creci VARCHAR(20) NOT NULL UNIQUE,
    TaxaComissao DECIMAL(5,2) NOT NULL,
    QuantidadeVendas INT NOT NULL
);

CREATE TABLE RH (
    IdRH INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Cpf VARCHAR(14) NOT NULL UNIQUE,
    Telefone VARCHAR(20) NOT NULL,
    Email VARCHAR(100) NOT NULL UNIQUE,
    Senha VARCHAR(255) NOT NULL,
    NivelAcesso INT NOT NULL
);

CREATE TABLE Cliente (
    IdCliente INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Cpf VARCHAR(14) NOT NULL UNIQUE,
    Telefone VARCHAR(20) NOT NULL,
    Email VARCHAR(100) NOT NULL UNIQUE,
    DataNascimento DATE NOT NULL,
    RendaMensal DECIMAL(10,2) NOT NULL
);

CREATE TABLE Imovel (
    IdImovel INT AUTO_INCREMENT PRIMARY KEY,
    Tipo ENUM('Aluguel', 'Venda') NOT NULL,
    Valor DECIMAL(12,2) NOT NULL,
    Status ENUM('Disponivel', 'Alugado', 'Vendido') NOT NULL DEFAULT 'Disponivel',
    QtdQuartos INT NOT NULL,
    PossuiGaragem BOOLEAN NOT NULL DEFAULT FALSE,
    IdEndereco INT NOT NULL,
    FOREIGN KEY (IdEndereco) REFERENCES Endereco(IdEndereco) ON UPDATE CASCADE ON DELETE RESTRICT
);

CREATE TABLE ImovelAluguel (
    IdImovelAluguel INT PRIMARY KEY,
    TaxaCondominio DECIMAL(10,2) NOT NULL,
    IptuMensal DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (IdImovelAluguel) REFERENCES Imovel(IdImovel) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE ImovelVenda (
    IdImovelVenda INT PRIMARY KEY,
    AceitaFinanciamento BOOLEAN NOT NULL DEFAULT FALSE,
    ValorEscritura DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (IdImovelVenda) REFERENCES Imovel(IdImovel) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE CorretorImovel (
    IdCorretor INT NOT NULL,
    IdImovel INT NOT NULL,
    PRIMARY KEY (IdCorretor, IdImovel),
    FOREIGN KEY (IdCorretor) REFERENCES Corretor(IdCorretor) ON UPDATE CASCADE ON DELETE RESTRICT,
    FOREIGN KEY (IdImovel) REFERENCES Imovel(IdImovel) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE Visita (
    IdVisita INT AUTO_INCREMENT PRIMARY KEY,
    IdCliente INT NOT NULL,
    IdCorretor INT NOT NULL,
    IdImovel INT NOT NULL,
    DataHora DATETIME NOT NULL,
    Status ENUM('Agendada', 'Confirmada', 'Cancelada') NOT NULL DEFAULT 'Agendada',
    Observacao VARCHAR(300),
    FOREIGN KEY (IdCliente) REFERENCES Cliente(IdCliente) ON UPDATE CASCADE ON DELETE RESTRICT,
    FOREIGN KEY (IdCorretor) REFERENCES Corretor(IdCorretor) ON UPDATE CASCADE ON DELETE RESTRICT,
    FOREIGN KEY (IdImovel) REFERENCES Imovel(IdImovel) ON UPDATE CASCADE ON DELETE RESTRICT
);

CREATE TABLE Proposta (
    IdProposta INT AUTO_INCREMENT PRIMARY KEY,
    IdCliente INT NOT NULL,
    IdImovel INT NOT NULL,
    DataProposta DATETIME NOT NULL,
    Valor DECIMAL(12,2) NOT NULL,
    CondicoesPagamento VARCHAR(300),
    Status ENUM('Pendente', 'Aceita', 'Recusada') NOT NULL DEFAULT 'Pendente',
    UNIQUE (IdCliente, IdImovel, Status),
    FOREIGN KEY (IdCliente) REFERENCES Cliente(IdCliente) ON UPDATE CASCADE ON DELETE RESTRICT,
    FOREIGN KEY (IdImovel) REFERENCES Imovel(IdImovel) ON UPDATE CASCADE ON DELETE RESTRICT
);

-- DADOS PARA TESTES

-- Inserindo um RH de teste
INSERT INTO RH (Nome, Cpf, Telefone, Email, Senha, NivelAcesso)
VALUES ('Admin Teste', '000.000.000-00', '31999999999', 'admin@teste.com', '123456', 1);

-- Inserindo um Corretor de teste
INSERT INTO Corretor (Nome, Cpf, Telefone, Email, Senha, Creci, TaxaComissao, QuantidadeVendas)
VALUES ('Corretor Teste', '111.111.111-11', '31988888888', 'corretor@teste.com', '123456', 'CRECI-123', 5.00, 0);


-- ENDEREÇO
INSERT INTO Endereco (Rua, Numero, Bairro, Cidade, Cep) VALUES
('Rua das Acácias', 142, 'Centro', 'Betim', '32600-000'),
('Avenida Amazonas', 5830, 'Gameleira', 'Belo Horizonte', '30180-001'),
('Rua Coronel José Dias', 78, 'Citrolândia', 'Betim', '32640-120'),
('Rua São Paulo', 310, 'Imbiruçu', 'Betim', '32604-050'),
('Avenida Perimetral', 990, 'PTB', 'Betim', '32669-000');


-- CORRETOR
INSERT INTO Corretor (Nome, Cpf, Telefone, Email, Senha, Creci, TaxaComissao, QuantidadeVendas) VALUES
('Lucas Mendonça Tavares', '032.541.678-90', '31987654321', 'lucas.tavares@domus.com', '123456', 'CRECI-MG-45231', 5.00, 3),
('Fernanda Rocha Silveira', '098.321.456-12', '31976543210', 'fernanda.silveira@domus.com', '123456', 'CRECI-MG-38902', 4.50, 1),
('Marcos Aurélio Pinto', '154.789.230-44', '31965432109', 'marcos.pinto@domus.com', '123456', 'CRECI-MG-52110', 6.00, 5);


-- RH
INSERT INTO RH (Nome, Cpf, Telefone, Email, Senha, NivelAcesso) VALUES
('Carla Beatriz Nogueira', '211.654.987-33', '31954321098', 'carla.nogueira@domus.com', '123456', 1),
('Rafael Drummond Costa', '309.123.745-88', '31943210987', 'rafael.costa@domus.com', '123456', 2);


-- CLIENTE
INSERT INTO Cliente (Nome, Cpf, Telefone, Email, DataNascimento, RendaMensal) VALUES
('Ana Paula Ferreira', '421.987.654-01', '31932109876', 'ana.ferreira@gmail.com', '1990-03-15', 4500.00),
('Thiago Henrique Souza', '537.210.983-72', '31921098765', 'thiago.souza@gmail.com', '1985-07-22', 7800.00),
('Juliana Matos Andrade', '648.321.097-55', '31910987654', 'juliana.andrade@gmail.com', '1995-11-08', 3200.00),
('Roberto Alves Cunha', '759.432.108-16', '31909876543', 'roberto.cunha@gmail.com', '1978-01-30', 12000.00),
('Camila Duarte Lopes', '860.543.219-27', '31998765432', 'camila.lopes@gmail.com', '2000-06-19', 2800.00);


-- IMOVEL + SUBCLASSES
-- Imóvel 1: Aluguel
INSERT INTO Imovel (Tipo, Valor, Status, QtdQuartos, PossuiGaragem, IdEndereco) VALUES
('Aluguel', 1200.00, 'Disponivel', 2, TRUE, 1);
INSERT INTO ImovelAluguel (IdImovelAluguel, TaxaCondominio, IptuMensal) VALUES
(1, 280.00, 95.00);

-- Imóvel 2: Aluguel
INSERT INTO Imovel (Tipo, Valor, Status, QtdQuartos, PossuiGaragem, IdEndereco) VALUES
('Aluguel', 900.00, 'Alugado', 1, FALSE, 3);
INSERT INTO ImovelAluguel (IdImovelAluguel, TaxaCondominio, IptuMensal) VALUES
(2, 180.00, 60.00);

-- Imóvel 3: Venda
INSERT INTO Imovel (Tipo, Valor, Status, QtdQuartos, PossuiGaragem, IdEndereco) VALUES
('Venda', 320000.00, 'Disponivel', 3, TRUE, 2);
INSERT INTO ImovelVenda (IdImovelVenda, AceitaFinanciamento, ValorEscritura) VALUES
(3, TRUE, 9600.00);

-- Imóvel 4: Venda
INSERT INTO Imovel (Tipo, Valor, Status, QtdQuartos, PossuiGaragem, IdEndereco) VALUES
('Venda', 185000.00, 'Vendido', 2, FALSE, 4);
INSERT INTO ImovelVenda (IdImovelVenda, AceitaFinanciamento, ValorEscritura) VALUES
(4, FALSE, 5550.00);

-- Imóvel 5: Aluguel
INSERT INTO Imovel (Tipo, Valor, Status, QtdQuartos, PossuiGaragem, IdEndereco) VALUES
('Aluguel', 1800.00, 'Disponivel', 3, TRUE, 5);
INSERT INTO ImovelAluguel (IdImovelAluguel, TaxaCondominio, IptuMensal) VALUES
(5, 350.00, 130.00);


-- CORRETOR x IMOVEL
INSERT INTO CorretorImovel (IdCorretor, IdImovel) VALUES
(1, 1),
(1, 3),
(2, 2),
(2, 4),
(3, 5);


-- VISITA
INSERT INTO Visita (IdCliente, IdCorretor, IdImovel, DataHora, Status, Observacao) VALUES
(1, 1, 1, '2026-06-10 10:00:00', 'Confirmada', 'Cliente tem interesse em alugar. Prefere andar alto.'),
(2, 1, 3, '2026-06-12 14:30:00', 'Confirmada', 'Cliente quer saber sobre financiamento pelo banco.'),
(3, 2, 2, '2026-06-08 09:00:00', 'Cancelada', 'Cliente desmarcou por compromisso de trabalho.'),
(4, 2, 4, '2026-06-05 11:00:00', 'Confirmada', 'Visita realizada. Cliente aprovou o imóvel.'),
(5, 3, 5, '2026-06-18 16:00:00', 'Agendada', 'Primeira visita. Cliente procura imóvel espaçoso.');


-- PROPOSTA
INSERT INTO Proposta (IdCliente, IdImovel, DataProposta, Valor, CondicoesPagamento, Status) VALUES
(1, 1, '2026-06-11 11:00:00', 1150.00, 'Pagamento até o dia 5 de cada mês. Sem fiador, com seguro-fiança.', 'Pendente'),
(2, 3, '2026-06-13 15:00:00', 310000.00, 'Entrada de R$ 60.000,00 e financiamento pelo Bradesco em 360 meses.', 'Pendente'),
(4, 4, '2026-06-06 10:00:00', 183000.00, 'Pagamento à vista. Solicita desconto de R$ 2.000,00 no valor final.', 'Aceita'),
(3, 2, '2026-06-09 08:30:00', 880.00, 'Proposta com dois meses de carência no início do contrato.', 'Recusada'),
(5, 5, '2026-06-19 17:00:00', 1750.00, 'Pagamento via PIX mensal. Cliente tem comprovante de renda.', 'Pendente');