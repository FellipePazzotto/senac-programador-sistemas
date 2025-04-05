-- TABELAS PRINCIPAIS

CREATE TABLE autores (
    id_autor INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    nacionalidade VARCHAR(50)
);

CREATE TABLE editoras (
    id_editora INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    pais VARCHAR(50)
);

CREATE TABLE categorias (
    id_categoria INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(50) NOT NULL
);

CREATE TABLE livros (
    id_livro INT AUTO_INCREMENT PRIMARY KEY,
    titulo VARCHAR(150) NOT NULL,
    ano_publicacao INT CHECK (ano_publicacao > 1500),
    id_autor INT,
    id_editora INT,
    FOREIGN KEY (id_autor) REFERENCES autores(id_autor),
    FOREIGN KEY (id_editora) REFERENCES editoras(id_editora)
);

CREATE TABLE livros_categorias (
    id_livro INT,
    id_categoria INT,
    PRIMARY KEY (id_livro, id_categoria),
    FOREIGN KEY (id_livro) REFERENCES livros(id_livro),
    FOREIGN KEY (id_categoria) REFERENCES categorias(id_categoria)
);

CREATE TABLE clientes (
    id_cliente INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(100) UNIQUE NOT NULL,
    telefone VARCHAR(20),
    data_cadastro DATE
);

CREATE TABLE emprestimos (
    id_emprestimo INT AUTO_INCREMENT PRIMARY KEY,
    id_cliente INT,
    data_emprestimo DATE NOT NULL,
    data_prevista_devolucao DATE NOT NULL,
    data_devolucao DATE,
    FOREIGN KEY (id_cliente) REFERENCES clientes(id_cliente)
);

CREATE TABLE emprestimos_livros (
    id_emprestimo INT,
    id_livro INT,
    PRIMARY KEY (id_emprestimo, id_livro),
    FOREIGN KEY (id_emprestimo) REFERENCES emprestimos(id_emprestimo),
    FOREIGN KEY (id_livro) REFERENCES livros(id_livro)
);

CREATE TABLE avaliacoes (
    id_avaliacao INT AUTO_INCREMENT PRIMARY KEY,
    id_cliente INT,
    id_livro INT,
    nota INT CHECK (nota BETWEEN 1 AND 5),
    comentario TEXT,
    data_avaliacao DATE,
    FOREIGN KEY (id_cliente) REFERENCES clientes(id_cliente),
    FOREIGN KEY (id_livro) REFERENCES livros(id_livro)
);

CREATE TABLE multas (
    id_multa INT AUTO_INCREMENT PRIMARY KEY,
    id_emprestimo INT,
    valor DECIMAL(6,2) NOT NULL,
    descricao TEXT,
    paga BOOLEAN DEFAULT FALSE,
    FOREIGN KEY (id_emprestimo) REFERENCES emprestimos(id_emprestimo)
);

-- SCRIPT DE INSERÇÃO DE DADOS FICTÍCIOS

-- AUTORES
INSERT INTO autores (nome, nacionalidade) VALUES
('J.K. Rowling', 'Reino Unido'),
('George R.R. Martin', 'EUA'),
('Machado de Assis', 'Brasil'),
('Haruki Murakami', 'Japão'),
('Clarice Lispector', 'Brasil'),
('Stephen King', 'EUA'),
('Isaac Asimov', 'Rússia'),
('Yuval Noah Harari', 'Israel'),
('Jane Austen', 'Reino Unido'),
('Neil Gaiman', 'Reino Unido');

-- EDITORAS
INSERT INTO editoras (nome, pais) VALUES
('Companhia das Letras', 'Brasil'),
('HarperCollins', 'EUA'),
('Penguin Books', 'Reino Unido'),
('Editora Rocco', 'Brasil'),
('Kodansha', 'Japão');

-- CATEGORIAS
INSERT INTO categorias (nome) VALUES
('Romance'),
('Ficção Científica'),
('Fantasia'),
('História'),
('Filosofia'),
('Terror'),
('Tecnologia'),
('Biografia');

-- CLIENTES
INSERT INTO clientes (nome, email, telefone, data_cadastro) VALUES
('Ana Silva', 'ana@email.com', '1111-1111', '2023-01-15'),
('Bruno Costa', 'bruno@email.com', '2222-2222', '2023-02-20'),
('Carlos Dias', 'carlos@email.com', '3333-3333', '2023-03-10'),
('Daniela Souza', 'daniela@email.com', '4444-4444', '2023-04-05'),
('Eduardo Lima', 'eduardo@email.com', '5555-5555', '2023-05-12'),
('Fernanda Rocha', 'fernanda@email.com', '6666-6666', '2023-06-01'),
('Guilherme Torres', 'guilherme@email.com', '7777-7777', '2023-06-15'),
('Helena Martins', 'helena@email.com', '8888-8888', '2023-07-08'),
('Igor Fernandes', 'igor@email.com', '9999-9999', '2023-08-20'),
('Juliana Ribeiro', 'juliana@email.com', '1010-1010', '2023-09-30');

-- LIVROS
INSERT INTO livros (titulo, ano_publicacao, id_autor, id_editora) VALUES
('Harry Potter e a Pedra Filosofal', 1997, 1, 4),
('As Crônicas de Gelo e Fogo', 1996, 2, 2),
('Dom Casmurro', 1899, 3, 1),
('Norwegian Wood', 1987, 4, 5),
('A Hora da Estrela', 1977, 5, 1),
('O Iluminado', 1977, 6, 2),
('Eu, Robô', 1950, 7, 3),
('Sapiens', 2011, 8, 3),
('Orgulho e Preconceito', 1813, 9, 3),
('Deuses Americanos', 2001, 10, 3),
('Harry Potter e a Câmara Secreta', 1998, 1, 4),
('A Dança dos Dragões', 2011, 2, 2),
('Quincas Borba', 1891, 3, 1),
('Kafka à Beira-Mar', 2002, 4, 5),
('Perto do Coração Selvagem', 1943, 5, 1),
('It: A Coisa', 1986, 6, 2),
('Fundacão', 1951, 7, 3),
('Homo Deus', 2015, 8, 3),
('Razão e Sensibilidade', 1811, 9, 3),
('O Livro do Cemitério', 2008, 10, 3);

-- LIVROS_CATEGORIAS
INSERT INTO livros_categorias (id_livro, id_categoria) VALUES
(1, 1), (1, 3), (2, 3), (2, 1), (3, 1), (4, 1), (4, 5), (5, 1),
(6, 6), (7, 2), (7, 7), (8, 4), (8, 8), (9, 1), (10, 3), (10, 1),
(11, 3), (12, 3), (13, 1), (14, 1), (14, 5), (15, 1), (16, 6),
(17, 2), (18, 4), (19, 1), (20, 3), (20, 6);

-- EMPRESTIMOS
INSERT INTO emprestimos (id_cliente, data_emprestimo, data_prevista_devolucao, data_devolucao) VALUES
(1, '2024-01-05', '2024-01-20', '2024-01-18'),
(2, '2024-01-10', '2024-01-25', NULL),
(3, '2024-02-01', '2024-02-15', '2024-02-20'),
(4, '2024-02-05', '2024-02-20', '2024-02-22'),
(5, '2024-02-10', '2024-02-25', NULL),
(6, '2024-03-01', '2024-03-16', '2024-03-15'),
(7, '2024-03-05', '2024-03-20', '2024-03-25'),
(8, '2024-03-10', '2024-03-25', '2024-03-27'),
(9, '2024-04-01', '2024-04-16', NULL),
(10, '2024-04-05', '2024-04-20', NULL);

-- EMPRESTIMOS_LIVROS
INSERT INTO emprestimos_livros (id_emprestimo, id_livro) VALUES
(1, 1), (1, 3),
(2, 2),
(3, 4),
(4, 5),
(5, 6), (5, 7),
(6, 8),
(7, 9), (7, 10),
(8, 11),
(9, 12),
(10, 13), (10, 14);

-- AVALIACOES
INSERT INTO avaliacoes (id_cliente, id_livro, nota, comentario, data_avaliacao) VALUES
(1, 1, 5, 'Excelente leitura!', '2024-01-20'),
(2, 2, 4, 'Muito envolvente.', '2024-01-25'),
(3, 4, 5, 'Obra-prima!', '2024-02-21'),
(4, 5, 3, 'Esperava mais.', '2024-02-23'),
(6, 8, 5, 'Livro essencial.', '2024-03-16'),
(7, 9, 4, 'Bastante interessante.', '2024-03-26'),
(8, 11, 5, 'Fantástico!', '2024-03-28'),
(9, 12, 4, 'Muito bom!', '2024-04-02');

-- MULTAS
INSERT INTO multas (id_emprestimo, valor, descricao, paga) VALUES
(3, 15.00, 'Devolução com 5 dias de atraso', TRUE),
(4, 10.00, 'Devolução com 2 dias de atraso', FALSE),
(7, 20.00, 'Devolução com 5 dias de atraso', TRUE),
(8, 10.00, 'Devolução com 2 dias de atraso', FALSE);