CREATE DATABASE db_senac;
USE db_senac;

CREATE TABLE IF NOT EXISTS usuario (
	id INT AUTO_INCREMENT,
    email VARCHAR(50) NOT NULL UNIQUE,
    senha VARCHAR(20) NOT NULL,
    
    PRIMARY KEY(id)
);

INSERT INTO usuario (email, senha) VALUES
('junior@email.com', 'Abruna@123A'),
('messi@email.com', 'Afifa@123A'),
('ronaldo@email.com', 'A777@Abcd');

SELECT * FROM usuario;