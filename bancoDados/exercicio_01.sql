CREATE TABLE IF NOT EXISTS empregado (
	id INT AUTO_INCREMENT,
	nome VARCHAR(30) NOT NULL,
    idade INT NOT NULL,
    departamento VARCHAR(50) NOT NULL,
    salario INT NOT NULL,
    
    PRIMARY KEY(id)
);

INSERT INTO empregado (nome, idade, departamento, salario) VALUES
('João', 30, 'RH', 50000), 
('Sarah', 28, 'TI', 60000), 
('Miguel', 35, 'Vendas', 55000), 
('Ana', 27, 'TI', 62000);

/*Tarefa 1.1*/ SELECT * FROM empregado WHERE departamento = 'TI';

/*Tarefa 1.2*/ SELECT nome, salario FROM empregado WHERE salario > 55000;

/*Tarefa 1.3*/ SELECT * FROM empregado ORDER BY idade ASC;

/*Tarefa 2.1*/ SELECT * FROM empregado WHERE idade BETWEEN 28 AND 35;

/*Tarefa 2.2*/ SELECT * FROM empregado WHERE nome LIKE 'M%';

/*Tarefa 2.3*/ SELECT * FROM empregado WHERE nome LIKE 'M%';

/*Tarefa 2.3*/ SELECT * FROM empregado WHERE departamento != 'RH';

/*Tarefa 3.1*/ SELECT COUNT(CASE WHEN departamento = 'TI' THEN nome END) AS empregados_ti,
					  COUNT(CASE WHEN departamento = 'RH' THEN nome END) AS empregados_rh,
                      COUNT(CASE WHEN departamento = 'Vendas' THEN nome END) AS empregados_vendas
			   FROM empregado;

/*Tarefa 3.2*/ SELECT AVG(salario) FROM empregado WHERE departamento = 'TI';

/*Tarefa 3.3*/ SELECT SUM(salario) FROM empregado WHERE departamento = 'Vendas';

CREATE TABLE IF NOT EXISTS departamento (
	id INT AUTO_INCREMENT,
	nome VARCHAR(30) NOT NULL,
    
    PRIMARY KEY(id)
);

INSERT INTO departamento (nome) VALUES
('RH'), 
('TI'), 
('Vendas'),
('Secretaria');

ALTER TABLE empregado ADD department_id INT;
ALTER TABLE empregado ADD CONSTRAINT FOREIGN KEY(department_id) REFERENCES departamento(id);

SET SQL_SAFE_UPDATES = 0;
UPDATE empregado SET department_id = 1 WHERE nome = 'João';
UPDATE empregado SET department_id = 2 WHERE nome = 'Sarah' OR nome = 'Ana';
UPDATE empregado SET department_id = 3 WHERE nome = 'Miguel';

SELECT * FROM empregado;

/*Tarefa 4.1*/ SELECT emp.id, emp.nome, dep.nome AS departamento
			   FROM empregado emp
               INNER JOIN departamento dep ON emp.department_id = dep.id;

/*Tarefa 4.2*/ SELECT dep.id, dep.nome AS departamento, emp.nome AS empregados
			   FROM departamento dep
               LEFT JOIN empregado emp ON emp.department_id = dep.id
               ORDER BY dep.id ASC;

/*Tarefa 5.1*/ SELECT nome, salario FROM empregado WHERE salario > (
			   SELECT AVG(salario) FROM empregado);

/*Tarefa 5.2*/ SELECT nome, departamento FROM empregado WHERE departamento LIKE (
			   SELECT departamento FROM empregado WHERE nome = 'Sarah');

/*Tarefa 6.1*/ INSERT INTO empregado (nome, idade, departamento, salario, department_id) VALUES
			   ('Tomás', 45, 'Vendas', 58000, 3);

/*Tarefa 6.2*/ UPDATE empregado SET salario = salario + (salario * 0.05) WHERE department_id = 2;

/*Tarefa 6.3*/ DELETE FROM empregado WHERE idade > 40;

SELECT * FROM empregado;