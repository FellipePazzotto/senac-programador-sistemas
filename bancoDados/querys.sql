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

SELECT livro.id, livro.titulo, livro.data_publicacao, livro.numero_paginas, livro.preco, livro.isbn, 
genero.nome AS genero, editora.nome AS editora, autor.nome AS autor, livro.apagado, livro.criado_em
FROM livro
INNER JOIN genero ON livro.id_genero = genero.id 
INNER JOIN editora ON livro.id_editora = editora.id 
INNER JOIN autor ON livro.id_autor = autor.id
ORDER BY livro.id ASC;

SELECT l.id, l.titulo, l.data_publicacao, l.numero_paginas, l.preco, l.isbn, 
g.nome AS genero, e.nome AS editora, a.nome AS autor, l.apagado, l.criado_em
FROM livro l
INNER JOIN genero g ON l.id_genero = g.id 
INNER JOIN editora e ON l.id_editora = e.id 
INNER JOIN autor a ON l.id_autor = a.id
WHERE l.apagado = 0
ORDER BY l.id ASC;

UPDATE livro SET apagado = 1 WHERE id_autor = 1;