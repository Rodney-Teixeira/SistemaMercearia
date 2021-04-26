USE Restaurante;
GO

DROP table Funcionario;
GO

CREATE DATABASE Restaurante;
GO
CREATE TABLE Endereco
(
  Id int NOT NULL IDENTITY(1,1),
  Logradouro varchar(100),
  Numero int,
  Complemento varchar(15),
  Bairro varchar(50),
  Cep varchar(10),
  Cidade varchar(70),
  Estado varchar(30),
  Pais varchar(70),
  CONSTRAINT PkIdEndereco PRIMARY KEY NONCLUSTERED (Id)
)

CREATE TABLE Funcionario  
(  
 Id int NOT NULL PRIMARY KEY IDENTITY(1,1),  
 Nome varchar (80),  
 Cpf varchar(15),
 Rg varchar(15),
 Celular varchar(15),  
 Genero varchar(15),
 Email varchar(70),
 FkIdEndereco int,
 FOREIGN KEY(FkIdEndereco) REFERENCES Endereco(Id)  
);  


INSERT INTO Endereco VALUES ('Rua Francisco Candido Ribeiro', 96, 'AP-2', 'Vila Inglesa', '12460-000', 'Campos do Jord�o', 'S�o Paulo', 'Brasil');  
INSERT INTO Funcionario VALUES ('Marques Moreira de Sousa',	'091.234.234-32', '1233445', '(12)99119-1991', 'Masculino', 'marques.sousa@ifsp.edu.br', 1);
SELECT * FROM Endereco;
SELECT * FROM Funcionario;

SELECT MAX(Id) from Endereco;

select * from Funcionario where Id = 1;
