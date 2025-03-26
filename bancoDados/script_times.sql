CREATE TABLE IF NOT EXISTS times(
	id INT AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL UNIQUE,
    nota INT,
    serie VARCHAR(1),
    
    PRIMARY KEY(id)
);

INSERT INTO times (nome, nota, serie) VALUES 
	('Real Madrid', '9', 'A'), ('Bayern de Munique', '8', 'A'), ('Liverpool', '8', 'A'),
    ('Santos', '5', 'A'), ('Inter de Milão', '8', 'A'), ('Manchester United', '3', 'A'),
    ('São Paulo', '4', 'A'), ('Juventus', '6', 'A'), ('Dínamo de Zagred', '3', 'A'),
    ('Barcelona', '10', 'A'), ('Grêmio Novorizontino', '4', 'A'), ('Corinthians', '6', 'A'),
    ('Arsenal', '9', 'A'), ('Atlético de Madri', '7', 'A'), ('Bayer Leverkusen', '6', 'A');

SELECT * FROM times;

UPDATE times SET serie = 'B' WHERE id = 11;

SELECT nome FROM times WHERE serie = 'A';