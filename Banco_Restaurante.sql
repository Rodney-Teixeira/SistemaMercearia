CREATE TABLE Produto (
    Id_Produto INT PRIMARY KEY IDENTITY (1, 1),
	Cod_Produto VARCHAR (20) UNIQUE,
    Descricao VARCHAR (40),
    Valor FLOAT,
    Tipo VARCHAR (20),
    Ingredientes VARCHAR (120),
)
GO


CREATE TABLE Venda (
	Cod_Venda INT PRIMARY KEY IDENTITY(1, 1),
	Desconto DECIMAL(10,2),
	Valor_Total DECIMAL(10,2),
	Valor_Pago DECIMAL(10,2),
	Data_Venda DATETIME,
	fkId INT
	FOREIGN KEY(fkId) REFERENCES Funcionario(Id)
)
GO

CREATE TABLE Item_Pedido(
	Cod_Item INT PRIMARY KEY IDENTITY(1, 1),
	Quantidade INT,
	Adicional DECIMAL(10,2),
	fkId_Produto INT,
	fkCod_Venda INT
	FOREIGN KEY(fkId_Produto) REFERENCES Produto(Id_Produto),
	FOREIGN KEY(fkCod_Venda) REFERENCES Venda(Cod_Venda)
)

update Funcionario VALUES
()