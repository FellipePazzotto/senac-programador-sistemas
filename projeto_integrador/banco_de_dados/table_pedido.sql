CREATE TABLE IF NOT EXISTS pedido(
	id INT AUTO_INCREMENT,
    id_cliente INT NOT NULL,
    id_produto INT NOT NULL,
    
    PRIMARY KEY(id),
    FOREIGN KEY(id_cliente) REFERENCES cliente(id),
    FOREIGN KEY(id_produto) REFERENCES produto(id)
);