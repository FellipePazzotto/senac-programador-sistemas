CREATE TABLE IF NOT EXISTS genero (
    id INT AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL UNIQUE,
    
    PRIMARY KEY(id)
);

INSERT INTO genero (nome) VALUES
('tecnologia'),
('documentário cinematográfico'),
('terror'),
('drama'),
('entrevista'),
('aventura'),
('fantasia'),
('ação'),
('ficção científica'),
('romance distópico');