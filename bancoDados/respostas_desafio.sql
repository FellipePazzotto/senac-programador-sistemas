/*Tarefa 1*/
SELECT categorias.nome AS categoria, 
COUNT(emprestimos.id_emprestimo) AS quantidade_emprestada 
FROM livros_categorias
INNER JOIN livros ON livros.id_livro = livros_categorias.id_livro
INNER JOIN categorias ON categorias.id_categoria = livros_categorias.id_categoria
INNER JOIN emprestimos_livros ON emprestimos_livros.id_livro = livros.id_livro
INNER JOIN emprestimos ON emprestimos.id_emprestimo = emprestimos_livros.id_emprestimo
GROUP BY categorias.nome
ORDER BY quantidade_emprestada DESC;

/*Tarefa 2*/
SELECT autores.nome AS nome_autor, SUM(avaliacoes.nota) AS nota_total, COUNT(avaliacoes.nota) AS quantidade_nota
FROM avaliacoes
INNER JOIN livros ON livros.id_livro = avaliacoes.id_livro
INNER JOIN autores ON autores.id_autor = livros.id_autor
GROUP BY autores.nome
ORDER BY nota_total DESC LIMIT 3;

/*Tarefa 3*/
SELECT clientes.nome AS cliente, multas.valor AS valor_pago
FROM clientes
INNER JOIN emprestimos ON emprestimos.id_cliente = clientes.id_cliente
INNER JOIN multas ON multas.id_emprestimo = emprestimos.id_emprestimo
WHERE multas.paga = TRUE
GROUP BY clientes.nome
ORDER BY valor_pago DESC;

/*Tarefa 4*/
SELECT livros.titulo AS livro_emprestado, clientes.nome AS cliente, emprestimos.data_emprestimo 
AS emprestado_em, IF(emprestimos.data_devolucao IS NULL, 'não', 'sim') AS recebido 
FROM livros
INNER JOIN emprestimos_livros ON emprestimos_livros.id_livro = livros.id_livro
INNER JOIN emprestimos ON emprestimos.id_emprestimo = emprestimos_livros.id_emprestimo
INNER JOIN clientes ON clientes.id_cliente = emprestimos.id_cliente
WHERE emprestimos.data_devolucao IS NULL;

/*Tarefa 5*/
SELECT livros.titulo AS livro, ROUND(AVG(avaliacoes.nota), 2) AS media_notas, COUNT(avaliacoes.nota) 
AS quantidade_avaliacoes
FROM livros
INNER JOIN avaliacoes ON avaliacoes.id_livro = livros.id_livro
GROUP BY livros.titulo
HAVING media_notas > 4.5;

/*Tarefa 6*/
SELECT clientes.nome AS cliente, COUNT(emprestimos.id_cliente) AS quantidade_emprestimos
FROM clientes
INNER JOIN emprestimos ON emprestimos.id_cliente = clientes.id_cliente
GROUP BY clientes.nome
ORDER BY quantidade_emprestimos LIMIT 5;

/*Tarefa 7*/
SELECT categorias.nome AS categoria, SUM(multas.valor) AS valor_total
FROM categorias
INNER JOIN livros_categorias ON livros_categorias.id_categoria = categorias.id_categoria
INNER JOIN emprestimos_livros ON emprestimos_livros.id_livro = livros_categorias.id_livro
INNER JOIN emprestimos ON emprestimos.id_emprestimo = emprestimos_livros.id_emprestimo
INNER JOIN multas ON multas.id_emprestimo = emprestimos_livros.id_emprestimo
WHERE multas.paga IS FALSE
GROUP BY categorias.nome;

/*Tarefa 8*/
SELECT clientes.nome AS cliente, livros.titulo AS livro, emprestimos.data_emprestimo 
AS emprestado_em, IF(emprestimos.data_devolucao IS NULL, "Não", "Sim") AS devolvido, emprestimos.data_devolucao 
AS devolvido_em, multas.valor AS valor_multa, IF(multas.paga IS FALSE, "Não", "Sim") 
AS foi_paga, avaliacoes.nota AS nota_avaliacao, avaliacoes.comentario AS avaliacao 
FROM clientes
INNER JOIN emprestimos ON emprestimos.id_cliente = clientes.id_cliente
INNER JOIN emprestimos_livros ON emprestimos_livros.id_emprestimo = emprestimos.id_emprestimo
INNER JOIN multas ON multas.id_emprestimo = emprestimos_livros.id_emprestimo
INNER JOIN avaliacoes ON avaliacoes.id_livro = emprestimos_livros.id_livro
INNER JOIN livros ON livros.id_livro = emprestimos_livros.id_livro
WHERE clientes.id_cliente = (SELECT id_cliente FROM clientes WHERE nome = 'Helena Martins');

/*Tarefa 9*/
SELECT editoras.nome AS editora, COUNT(DISTINCT categorias.id_categoria) AS categorias_diferentes
FROM editoras 
INNER JOIN livros ON livros.id_editora = editoras.id_editora
INNER JOIN livros_categorias ON livros_categorias.id_livro = livros.id_livro
INNER JOIN categorias ON categorias.id_categoria = livros_categorias.id_categoria
GROUP BY editoras.nome
HAVING categorias_diferentes >= 4;

/*Tarefa 10*/
SELECT ROUND(AVG(emprestimos.data_devolucao - emprestimos.data_prevista_devolucao), 2) AS media_dias_atraso
FROM emprestimos
INNER JOIN multas ON multas.id_emprestimo = emprestimos.id_emprestimo
WHERE multas.paga IS TRUE AND data_devolucao IS NOT NULL;