--CREATE DATABASE DB_Hotel_IDN

USE DB_Hotel_IDN

CREATE TABLE Agencia (
Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
Nome VARCHAR(50) NOT NULL
)

INSERT INTO Agencia values
('AbreuTur'),
('ADVtour'),
('Agaxtur'),
('CT Operadora'),
('CVC'),
('Designer Tours'),
('Flytour'),
('Fran�atur'),
('Freeway Viagens'),
('Insight Travel Experiences'),
('Intravel'),
('JVS'),
('Maktour'),
('Mercatur'),
('Princess Travel'),
('RCA Turismo'),
('Slavian Tours'),
('Soft Travel'),
('Time Brazil'),
('Tourlines'),
('Trade Tours'),
('Transmundi'),
('Uneworld'),
('Viagens Master'),
('Visual Turismo'),
('WT Tours')

CREATE TABLE Apartamento (
Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
Andar INT NOT NULL,
Numero INT NOT NULL,
Tipo VARCHAR(50) NOT NULL
)

INSERT INTO Apartamento values
(0,01, 'Single Room'),
(0,02, 'Single Room'),
(0,03, 'Single Room'),
(0,04, 'Single Room'),
(0,05, 'Single Room'),
(0,06, 'Single Room'),
(0,07, 'Single Room'),
(0,08, 'Single Room'),
(0,09, 'Single Room'),
(0,10, 'Single Room'),
(1,11, 'Twin Room'),
(1,12, 'Twin Room'),
(1,13, 'Twin Room'),
(1,14, 'Twin Room'),
(1,15, 'Twin Room'),
(1,16, 'Twin Room'),
(1,17, 'Twin Room'),
(1,18, 'Twin Room'),
(1,19, 'Twin Room'),
(1,20, 'Twin Room'),
(2,21, 'Double Room'),
(2,22, 'Double Room'),
(2,23, 'Double Room'),
(2,24, 'Double Room'),
(2,25, 'Double Room'),
(2,26, 'Double Room'),
(2,27, 'Double Room'),
(2,28, 'Double Room'),
(2,29, 'Double Room'),
(2,30, 'Double Room')

CREATE TABLE Cliente (
Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
Nome VARCHAR(50) NOT NULL,
Cpf VARCHAR(11) NOT NULL,
Profissao VARCHAR(100) NOT NULL,
MeioTransporte VARCHAR(50) NOT NULL,
Motivo VARCHAR(50) NOT NULL
)

INSERT INTO Cliente values
('Miguel',    '41844619486', 'Assistente Administrativo', 'Bicicleta', 'Neg�cios'),
('Arthur',    '58543435765', 'Assistente Administrativo', 'Motocicleta', 'Lazer'),
('Fl�vio',    '62674844671', 'Recepcionista', 'Carro', 'Neg�cios'),
('Davi',      '30727280899', 'Vendedor', 'Avi�o', 'Lazer'),
('Gabriel',   '36397581888', 'Operador de Telemarketing', '�nibus', 'Neg�cios'),
('Lucas',     '33197258827', 'Auxiliar de Produ��o', 'Navio', 'Lazer'),
('Eduardo',   '38344633885', 'Operador de Caixa', 'Carro', 'Neg�cios'),
('Vitor',     '29513624803', 'Assistente Financeiro', 'Motocicleta', 'Lazer'),
('Matheus',   '21918047804', 'Consultor de Vendas', 'Carro', 'Lazer'),
('Pedro',     '31449324851', 'Atendente', 'Carro', 'Neg�cios'),
('Elias',     '40196159857', 'T�cnico em Seguran�a do Trabalho', '�nibus', 'Lazer'),
('Guilherme', '36737468802', 'Assistente Comercial', 'Motocicleta', 'Neg�cios'),
('Enzo',      '39859064830', 'Porteiro', 'Carro', 'Neg�cios'),
('Rafael',    '34139601809', 'Analista de Suporte T�cnico', '�nibus', 'Lazer'),
('Bernardo',  '36530701800', 'Operador de M�quina', 'Carro', 'Lazer'),
('Sophia',    '41234493870', 'Analista de Recursos Humanos', 'Carro', 'Neg�cios'),
('Julia',     '40741077833', 'Vigilante', '�nibus', 'Neg�cios'),
('Isabella',  '39947067858', 'Promotora de Vendas', 'Motocicleta', 'Neg�cios'),
('Alice',     '40988786826', 'Consultor de Vendas', '�nibus', 'Neg�cios'),
('Manuela',   '38613219802', 'Consultor de Vendas', 'Avi�o', 'Lazer'),
('Aline',     '23347027817', 'Analista Financeiro', 'Carro', 'Neg�cios'),
('Giovanna',  '38332080827', 'T�cnico em Seguran�a do Trabalho', 'Carro', 'Neg�cios'),
('Laura',     '39212375804', 'Analista Cont�bil', 'Avi�o', 'Neg�cios'),
('Luiza',     '32084999812', 'Consultor de Vendas', 'Motocicleta', 'Neg�cios'),
('Beatriz',   '37756763840', 'Conferente', 'Carro', 'Neg�cios'),
('Mariana',   '07840562426', 'T�cnico em Seguran�a do Trabalho', 'Avi�o', 'Lazer'),
('Yasmin',    '40302259856', 'Vendedora Externo', 'Carro', 'Lazer'),
('Rafaela',   '34678898832', 'Auxiliar de Limpeza', 'Motocicleta', 'Lazer'),
('Gabriela',  '39425050880', 'Assistente de Departamento Pessoal', 'Carro', 'Neg�cios'),
('Isabelle',  '37023808841', 'Assistente de Departamento Pessoal', 'Bicicleta', 'Neg�cios')

CREATE TABLE Produto (
Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
Descricao VARCHAR(50) NOT NULL
)

INSERT INTO Produto values
('�gua'),
('�gua de coco'),
('�gua t�nica'),
('Cerveja'),
('Champanhe'),
('Licor'),
('Refrigerante'),
('Rum'),
('Suco'),
('Vinho'),
('Vodca'),
('U�sque'),
('Biscoito'),
('Cereal'),
('Chocolate'),
('Banana'),
('Ma�a'),
('Uva'),
('Absorvente'),
('Antiss�ptico'),
('Condicionador'),
('Cotonete'),
('Fio-dental'),
('Preservativo'),
('Sabonete'),
('Xampu')

CREATE TABLE Servico (
Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
Nome VARCHAR(50) NOT NULL
)

INSERT INTO Servico values 
('Despertador'),
('Lavanderia'),
('Limpeza de quarto'),
('Chamada de t�xi'),
('Armazenamento em cofre'),
('Frigobar'),
('Internet'),
('Piscina'),
('Sauna'),
('Gin�stica'),
('Muscula��o'),
('Spa'),
('Joalheira'),
('Cabeleireiro'),
('Guarda-volumes'),
('Salas de confer�ncias'),
('Guia tur�stico'),
('Estacionamento')

CREATE TABLE Tempo (
Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
Ano INT NOT NULL,
Trimestre INT NOT NULL,
Mes VARCHAR(9) NOT NULL
)

INSERT INTO Tempo values
(2013, 1, 'Janeiro'),
(2013, 1, 'Fevereiro'),
(2013, 1, 'Mar�o'),
(2013, 2, 'Abril'),
(2013, 2, 'Maio'),
(2013, 2, 'Junho'),
(2013, 3, 'Julho'),
(2013, 3, 'Agosto'),
(2013, 3, 'Setembro'),
(2013, 4, 'Outubro'),
(2013, 4, 'Novembro'),
(2013, 4, 'Dezembro'),
(2014, 1, 'Janeiro'),
(2014, 1, 'Fevereiro'),
(2014, 1, 'Mar�o'),
(2014, 2, 'Abril'),
(2014, 2, 'Maio'),
(2014, 2, 'Junho'),
(2014, 3, 'Julho'),
(2014, 3, 'Agosto'),
(2014, 3, 'Setembro'),
(2014, 4, 'Outubro'),
(2014, 4, 'Novembro'),
(2014, 4, 'Dezembro')

CREATE TABLE Consumo (
Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
IdApto INT FOREIGN KEY REFERENCES Apartamento(Id) NOT NULL,
IdCliente INT FOREIGN KEY REFERENCES Cliente(Id) NOT NULL,
IdTempo INT FOREIGN KEY REFERENCES Tempo(Id) NOT NULL,
IdServico INT FOREIGN KEY REFERENCES Servico(Id) NOT NULL,
IdProduto INT FOREIGN KEY REFERENCES Produto(Id) NOT NULL,
ValorConsumo INT NOT NULL,
Quantidade INT NOT NULL
)

INSERT INTO Consumo values
(21,9,12,1,17,10,3),
(24,21,9,2,18,24,5),
(28,28,5,3,19,12,1),
(16,24,2,4,20,26,2),
(2 ,5 ,6,5,21,111,10),
(13,20,7,6,22,52,4),
(8 ,25,2,7,23,61,2),
(11,22,1,8,24,32,1),
(7 ,27,8,9,25,39,3),
(4 ,19,6,10,26,16,3),
(15,4 ,2,11,22,13,5),
(29,12,21,12,11,125,2),
(27,6 ,9,13,16,21,3),
(23,3,10,14,15,66,9),
(5 ,23,11,15,14,23,8),
(22,13,20,16,1,53,3),
(18,2 ,14,17,2,59,8),
(30,14,17,18,3,99,7),
(6 ,17,24,5,4,64,7),
(3 ,10,23,1,5,84,1),
(10,1 ,13,7,6,74,2),
(25,15,19,2,7,35,4),
(9 ,11,3,4,8,23,5),
(12,8 ,5,3,9,36,1),
(1 ,7 ,22,6,10,40,5),
(26,26,15,8,11,73,8),
(20,16,17,9,12,33,7),
(17,30,5,11,16,61,4),
(19,29,7,13,1,76,6),
(14,18,19,17,4,22,3)

CREATE TABLE Hospedagem (
Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
IdApto INT FOREIGN KEY REFERENCES Apartamento(Id) NOT NULL,
IdAgencia INT FOREIGN KEY REFERENCES Agencia(Id) NOT NULL,
IdCliente INT FOREIGN KEY REFERENCES Cliente(Id) NOT NULL,
IdTempo INT FOREIGN KEY REFERENCES Tempo(Id) NOT NULL,
ValorFaturado INT NOT NULL
)

INSERT INTO Hospedagem values
(21, 26,9,12, 125),
(24, 22,21,9, 122),
(28, 24,28,5, 201),
(16, 25,24,2, 78),
(2 , 21,5 ,6, 95),
(13, 19,20,7, 112),
(8 , 18,25,2, 211),
(11, 20,22,1, 92),
(7 , 15,27,8, 117),
(4 , 11,19,6, 98),
(15, 16,4 ,2, 121),
(29, 14,12,21, 105),
(27, 12,6 ,9, 103),
(23, 1,3,10, 101),
(5 , 5,23,11, 120),
(22, 2,13,20, 211),
(18, 3,2 ,14, 195),
(30, 6,14,17, 185),
(6 , 4,17,24, 153),
(3 , 3,10,23, 188),
(10, 3,1 ,13, 162),
(25, 5,15,19, 200),
(9 , 5,11,3, 123),
(12, 12,8 ,5, 185),
(1 , 5,7 ,22, 118),
(26, 6,26,15, 142),
(20, 6,16,17, 184),
(17, 26,30,5, 162),
(19, 22,29,7, 118),
(14, 21,18,19, 205)