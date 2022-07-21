CREATE TABLE livros(
	id int IDENTITY(1,1) PRIMARY KEY,
	titulo VARCHAR(15),
	quantidadepaginas INT,
	disponivel BIT
);

