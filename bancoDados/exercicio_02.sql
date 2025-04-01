CREATE TABLE IF NOT EXISTS cliente (
	id INT AUTO_INCREMENT,
	nome VARCHAR(30) NOT NULL,
    idade INT NOT NULL,
    cidade VARCHAR(50) NOT NULL,
    saldo DECIMAL(10, 2) NOT NULL,
    
    PRIMARY KEY(id)
);

INSERT INTO cliente (nome, idade, cidade, saldo) VALUES
('Carlos', 45, 'São Paulo', 2500.00), 
('Mariana', 32, 'Rio de Janeiro', 3200.50), 
('Pedro', 27, 'Belo Horizonte', 1500.75), 
('Fernanda', 38, 'Curitiba', 4200.00);

/*Tarefa 1.1*/ SELECT * FROM cliente WHERE cidade = 'Rio de Janeiro';

/*Tarefa 1.2*/ SELECT * FROM cliente WHERE saldo > 2000.00 ORDER BY saldo DESC;

/*Tarefa 1.3*/ SELECT nome, idade FROM cliente WHERE idade > 30;

/*Tarefa 2.1*/ SELECT * FROM cliente WHERE idade BETWEEN 25 AND 40;

/*Tarefa 2.2*/ SELECT * FROM cliente WHERE nome LIKE 'F%';

/*Tarefa 2.3*/ SELECT * FROM cliente WHERE cidade != 'São Paulo' AND cidade != 'Curitiba';

CREATE TABLE IF NOT EXISTS pedido (
	id INT AUTO_INCREMENT,
    cliente_id INT NOT NULL,
    valor DECIMAL(10, 2) NOT NULL,
	data_pedido DATE NOT NULL,
    
    PRIMARY KEY(id),
    FOREIGN KEY(cliente_id) REFERENCES cliente(id)
);

INSERT INTO pedido (cliente_id, valor, data_pedido) VALUES
(1, 500.00, '2024-03-10'),
(2, 1200.00, '2024-03-12'),
(3, 300.50, '2024-03-15'),
(1, 800.00, '2024-03-18');

/*Tarefa 3.1*/ SELECT COUNT(id) AS total_pedido FROM pedido;

/*Tarefa 3.2*/ SELECT AVG(valor) FROM pedido;

/*Tarefa 3.3*/ SELECT cli.id, cli.nome, COUNT(CASE WHEN cli.id = ped.cliente_id THEN nome END) AS pedidos_feitos,
			   SUM(ped.valor) AS total_pedido
			   FROM pedido ped
               INNER JOIN cliente cli ON cli.id = ped.cliente_id
               GROUP BY nome;

/*Tarefa 4.1*/ SELECT ped.id, ped.valor, cli.nome AS feito_por
			   FROM cliente cli
               INNER JOIN pedido ped ON ped.cliente_id = cli.id
               GROUP BY ped.id;

/*Tarefa 4.2*/ SELECT cli.id, cli.nome, SUM(ped.valor) AS total_pedido
			   FROM cliente cli
               LEFT JOIN pedido ped ON ped.cliente_id = cli.id
               GROUP BY nome
               ORDER BY cli.id;

/*Tarefa 5.1*/ SELECT cli.nome, ped.valor
			   FROM pedido ped
               INNER JOIN cliente cli ON ped.cliente_id = cli.id
			   WHERE ped.valor > (SELECT AVG(valor) FROM pedido);

/*Tarefa 5.2*/ SELECT cli.nome, ped.valor
			   FROM pedido ped
               INNER JOIN cliente cli ON ped.cliente_id = cli.id
			   WHERE ped.valor > 1000;

/*Tarefa 6.1*/ INSERT INTO cliente (nome, idade, cidade, saldo) VALUES
			   ('Rafael', 35, 'Porto Alegre', 5090.00, 3);

SET SQL_SAFE_UPDATES = 0;

/*Tarefa 6.2*/ UPDATE cliente SET saldo = saldo + (saldo * 0.10);

/*Tarefa 6.3*/ DELETE FROM pedido WHERE valor < 500;

SELECT * FROM pedido;