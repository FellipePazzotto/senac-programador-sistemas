SELECT *
FROM livro;

SELECT *
FROM livro
WHERE data_publicacao >= '1990-01-01'
AND data_publicacao < '2000-01-01';
        
SELECT DISTINCT (editora)
FROM livro;
    
SELECT SUM(preco), MAX(preco), MIN(preco), AVG(preco)
FROM livro
WHERE editora = 'editora';
    
SELECT *
FROM livro
ORDER BY editora ASC, titulo ASC;

SELECT *
FROM livro
WHERE genero = 'terror';
    
UPDATE livro
SET genero = 'terror'
WHERE id = 5;

SELECT *
FROM autor;

SELECT *
FROM genero;

SELECT *
FROM editora;