CREATE TABLE IF NOT EXISTS fornecedor (
	id INT AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    cidade VARCHAR(50) NOT NULL,
    
    PRIMARY KEY(id)
);

INSERT INTO fornecedor (nome, cidade) VALUES
('TechBrasil', 'São Paulo'),
('Computech', 'Rio de Janeiro'),
('Moveis&Co', 'Curitiba');

SELECT * FROM fornecedor;

CREATE TABLE IF NOT EXISTS cliente (
	id INT AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    cidade VARCHAR(50) NOT NULL,
    idade INT NOT NULL,
    
    PRIMARY KEY(id)
);

INSERT INTO cliente (nome, cidade, idade) VALUES
('João Silva', 'São Paulo', 35),
('Maria Santos', 'Belo Horizonte', 28),
('Carlos Lima', 'Rio de Janeiro', 42),
('Fernanda Rocha', 'Curitiba', 30);

SELECT * FROM cliente;

CREATE TABLE IF NOT EXISTS produto (
	id INT AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    categoria VARCHAR(50) NOT NULL,
    preco DECIMAL(10, 2) NOT NULL,
    estoque INT NOT NULL,
    fornecedor_id INT NOT NULL,
    
    PRIMARY KEY(id),
    FOREIGN KEY(fornecedor_id) REFERENCES fornecedor(id)
);

INSERT INTO produto (nome, categoria, preco, estoque, fornecedor_id) VALUES
('Celular X', 'Eletrônicos', 2500.00, 30, 1),
('Notebook Y', 'Eletrônicos', 4800.00, 15, 2),
('Mesa de madeira', 'Móveis', 750.00, 10, 3),
('Cadeira Z', 'Móveis', 300.00, 25, 3),
('TV 50"', 'Eletrônicos', 3500.00, 8, 1);

SELECT * FROM produto;

CREATE TABLE IF NOT EXISTS pedido (
	id INT AUTO_INCREMENT,
    produto_id INT NOT NULL,
    quantidade INT NOT NULL,
    data_pedido DATE NOT NULL,
    cliente_id INT NOT NULL,
    
    PRIMARY KEY(id),
    FOREIGN KEY(produto_id) REFERENCES produto(id),
    FOREIGN KEY(cliente_id) REFERENCES cliente(id)
);

INSERT INTO pedido (produto_id, quantidade, data_pedido, cliente_id) VALUES
(1, 2, '2024-03-10', 1),
(3, 1, '2024-03-11', 2),
(2, 1, '2024-03-15', 3),
(5, 3, '2024-03-18', 1),
(4, 4, '2024-03-20', 4);

SELECT * FROM pedido;

/*Tarefa 1.1*/ SELECT nome AS produto, preco 
			   FROM produto WHERE preco > 3000.00 
               ORDER BY preco ASC;

/*Tarefa 1.2*/ SELECT nome, cidade, idade 
			   FROM cliente WHERE cidade != 'São Paulo' AND idade > 30;

/*Tarefa 1.3*/ SELECT ped.data_pedido, pro.nome, ped.quantidade, cli.nome FROM pedido ped 
			   INNER JOIN produto pro ON pro.id = produto_id
               INNER JOIN cliente cli ON cli.id = cliente_id
               WHERE data_pedido BETWEEN '2024-03-10' AND '2024-03-15'
               ORDER BY data_pedido ASC;

/*Tarefa 1.4*/ SELECT pro.id, pro.nome, pro.estoque, forn.nome FROM produto pro
			   INNER JOIN fornecedor forn ON forn.id = fornecedor_id 
               WHERE estoque < 10
               ORDER BY estoque ASC;

/*Tarefa 1.5*/ SELECT * FROM fornecedor 
			   WHERE cidade != 'Rio de Janeiro' AND nome LIKE 'T%';

/*Tarefa 2.1*/ SELECT categoria, AVG(preco) AS preco_medio 
			   FROM produto 
               GROUP BY categoria;

/*Tarefa 2.2*/ SELECT cli.nome, COUNT(ped.id) AS numero_pedidos 
			   FROM pedido ped
			   INNER JOIN cliente cli ON cli.id = ped.cliente_id 
               GROUP BY cli.nome;

/*Tarefa 2.3*/ SELECT categoria, SUM(estoque) AS estoque_total 
			   FROM produto
               GROUP BY categoria;

/*Tarefa 2.4*/ SELECT ped.id, pro.nome, ped.quantidade 
			   FROM pedido ped
               INNER JOIN produto pro ON pro.id = ped.produto_id 
			   WHERE quantidade = (SELECT MAX(quantidade) FROM pedido);

/*Tarefa 2.5*/ SELECT cidade, COUNT(cidade) AS numero_clientes 
			   FROM cliente GROUP BY cidade;

/*Tarefa 3.1*/ SELECT pro.nome AS produto, forn.nome AS fornecedor 
			   FROM produto pro
               INNER JOIN fornecedor forn ON forn.id = pro.fornecedor_id
               ORDER BY forn.nome ASC;

/*Tarefa 3.2*/ SELECT ped.id, ped.data_pedido, cli.nome AS cliente, pro.nome AS produto, ped.quantidade
			   FROM pedido ped
               INNER JOIN cliente cli ON cli.id = ped.cliente_id
               INNER JOIN produto pro ON pro.id = ped.produto_id
               ORDER BY data_pedido ASC;

/*Tarefa 3.3*/ SELECT ped.id, cli.nome AS cliente, pro.nome AS produto, forn.nome AS fornecedor
			   FROM pedido ped
               INNER JOIN cliente cli ON cli.id = ped.cliente_id
               INNER JOIN produto pro ON pro.id = ped.produto_id
               INNER JOIN fornecedor forn ON forn.id = fornecedor_id
               ORDER BY ped.id;

/*Tarefa 3.4*/ SELECT cli.nome, SUM(quantidade) as produtos_comprados
			   FROM pedido ped
			   INNER JOIN cliente cli ON cli.id = ped.cliente_id
               GROUP BY cli.nome;

/*Tarefa 4.1*/ SELECT categoria, nome, preco
			   FROM produto
               WHERE preco > (SELECT AVG(preco) FROM produto WHERE categoria = 'Eletrônicos')
               AND categoria = 'Eletrônicos'
               UNION
			   SELECT categoria, nome, preco
			   FROM produto
               WHERE preco > (SELECT AVG(preco) FROM produto WHERE categoria = 'Móveis') 
               AND categoria = 'Móveis';

SET SQL_SAFE_UPDATES = 0;

/*Tarefa 4.2*/ UPDATE produto SET preco = preco * 1.10 WHERE categoria = 'Eletrônicos';

/*Tarefa 4.3*/ DELETE FROM pedido 
			   WHERE cliente_id = (SELECT id FROM cliente WHERE cidade = 'Curitiba');

/*Tarefa 4.4*/ INSERT INTO cliente (nome, cidade, idade) VALUES
			   ('Ricardo Lopes', 'Porto Alegre', 38);

/*Tarefa 4.5*/ INSERT INTO pedido (produto_id, quantidade, data_pedido, cliente_id) VALUES 
			   ((SELECT id FROM produto WHERE nome = 'Notebook Y'), 2 , 
               '2024-03-25', (SELECT id FROM cliente WHERE nome = 'João Silva'));

INSERT INTO pedido (produto_id, quantidade, data_pedido, cliente_id) VALUES 
(4, 2, '2025-04-03', (SELECT id FROM cliente WHERE nome = 'Ricardo Lopes'));

/*Tarefa 4.6*/ SELECT pro.categoria, ped.id AS id_pedido, cli.nome
			   FROM pedido ped
               INNER JOIN cliente cli ON cli.id = ped.cliente_id
               INNER JOIN produto pro ON pro.id = ped.produto_id
               WHERE categoria = 'Móveis';