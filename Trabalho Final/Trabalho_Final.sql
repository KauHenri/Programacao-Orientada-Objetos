CREATE TABLE aluno(
	id_aluno SERIAL PRIMARY KEY,
	nome_aluno VARCHAR(100) NOT NULL,
	matricula_aluno VARCHAR(100) UNIQUE NOT NULL,
	cpf_aluno VARCHAR(100) UNIQUE NOT NULL
);

CREATE TABLE livro(
	id_livro SERIAL PRIMARY KEY,
	titulo_livro VARCHAR(100) NOT NULL,
	autor_livro VARCHAR(100) NOT NULL
);

CREATE TABLE emprestimo(
	id_emprestimo SERIAL PRIMARY KEY,
	id_aluno INT REFERENCES aluno(id_aluno),
	id_livro INT REFERENCES livro(id_livro),
	data_retirada DATE NOT NULL
);

SELECT * FROM aluno;

DROP TABLE emprestimo;