CREATE TABLE IF NOT EXISTS produto(
	id INT AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    marca VARCHAR(50) NOT NULL,
    preco DECIMAL(10, 2) NOT NULL,
    quantidade INT NULL,
    
    PRIMARY KEY(id)
);