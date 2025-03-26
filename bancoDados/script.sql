CREATE DATABASE db_main;
USE db_main;

CREATE TABLE IF NOT EXISTS usuario (
	id INT AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
	email VARCHAR(50) NOT NULL UNIQUE,
	senha VARCHAR(16) NOT NULL,
    
    PRIMARY KEY (id)
);
    
INSERT INTO usuario (nome, email, senha) VALUES 
	('Fellipe Pazzotto', 'fepazzotto@gmail.com', '1234567890');

INSERT INTO usuario (nome, email, senha) VALUES 
	('Lionel Messi', 'messi@gmail.com', '123456789Aa!'), 
	('Cristiano Ronaldo', 'ronaldo@gmail.com', '123456789Bb!'), 
	('Neymar Júnior', 'junior@gmail.com', '123456789Cc!');