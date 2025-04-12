CREATE TABLE cliente (
	id INT AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    nome_social VARCHAR(100) NULL,
    data_nascimento DATE NULL,
    email VARCHAR(50) NOT NULL UNIQUE,
    telefone VARCHAR(11) NOT NULL UNIQUE,
    tipo INT NOT NULL,
    etnia INT NOT NULL,
    genero INT NOT NULL,
    estrangeiro BIT NOT NULL,
    id_endereco INT NOT NULL,
    
    PRIMARY KEY(id),
    FOREIGN KEY(id_endereco) REFERENCES endereco(id)
);

INSERT INTO cliente(nome, nome_social, data_nascimento, email, telefone, tipo, etnia, genero, estrangeiro, id_endereco) VALUES 
("Neymar Júnior", "", "1992-02-05", "neymar.junior@gmail.com", "11911223344", 0, 1, 1, 0, 1),
("Marcos Leonardo", "", "2003-05-02", "marcos.leonardo@gmail.com", "11955667788", 0, 2, 1, 0, 1),
("Tiquinho Soares", "", "1991-01-17", "tiquinho.soares@gmail.com", "11911335577", 0, 2, 1, 0, 1);

SELECT * FROM cliente;