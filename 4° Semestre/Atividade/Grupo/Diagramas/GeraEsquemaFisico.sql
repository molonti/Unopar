-- Geração de Modelo físico
-- Sql ANSI 2003 - brModelo.



CREATE TABLE SolicitacaoReserva (
NumeroReserva Int PRIMARY KEY,
Destino varchar(30),
QtdePassageiros Int,
Data_Hora Date,
IdFuncionario Int,
CodVeiculo Int
);

CREATE TABLE Funcionario (
dataNascimento Date,
NomeFuncionario varchar(50),
cpf varchar(14),
cnh varchar(30),
RG varchar(12),
IdFuncionario Int PRIMARY KEY,
CEP varchar(10),
Complemento varchar(30),
UF varchar(2),
Cidade varchar(20),
Bairro varchar(20),
Numero Int,
Logradouro varchar(50),
autorizado int
);

CREATE TABLE Veiculo (
Modelo varchar(10),
TipoCombustivel varchar(10),
Placa varchar(8),
CodVeiculo Int PRIMARY KEY,
Opcionais varchar(100),
QtdePortas Int,
Cor varchar(10),
Fabricante varchar(10),
status varchar(1)
);

CREATE TABLE Devolucao (
NumeroDevolucao Int PRIMARY KEY,
QuilometragemFinal Int,
DataHoraDevolucao Date,
QuilometragemInicial Int,
NumeroReserva Int,
FOREIGN KEY(NumeroReserva) REFERENCES SolicitacaoReserva (NumeroReserva)
);

ALTER TABLE SolicitacaoReserva ADD FOREIGN KEY(IdFuncionario) REFERENCES Funcionario (IdFuncionario);
ALTER TABLE SolicitacaoReserva ADD FOREIGN KEY(CodVeiculo) REFERENCES Veiculo (CodVeiculo);
