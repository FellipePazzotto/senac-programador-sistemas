CREATE TABLE endereco (
	id INT AUTO_INCREMENT,
    logradouro VARCHAR(100) NOT NULL,
    numero VARCHAR(10) NOT NULL,
    complemento VARCHAR(50) NULL,
    bairro VARCHAR(50) NOT NULL,
    municipio VARCHAR(50) NOT NULL,
    estado VARCHAR(2) NOT NULL,
    cep VARCHAR(8) NOT NULL,
    
    PRIMARY KEY(id)
);

INSERT INTO endereco(logradouro, numero, complemento, bairro, municipio, estado, cep) VALUES 
("Avenida Paulista", "1578", "", "Bela Vista", "São Paulo", "SP", "01310200");

SELECT * FROM endereco;