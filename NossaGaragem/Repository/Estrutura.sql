﻿CREATE TABLE categorias(
id INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(100)
);

DROP TABLE veiculos;
CREATE TABLE veiculos(
id INT PRIMARY KEY IDENTITY(1,1),

id_categoria INT, FOREIGN KEY(id_categoria) REFERENCES categorias(id),

modelo VARCHAR(100),
valor DECIMAL(8,2)
);

SELECT 
veiculos.id AS 'VeiculoId',
veiculos.modelo AS 'VeiculoModelo',
veiculos.valor AS 'VeiculoValor',
veiculos.id_categoria AS 'VeiculoIdCategoria',
categorias.Nome AS 'CategoriaNome'
FROM veiculos
INNER JOIN categorias ON 
(veiculos.id_categoria = id_categoria)
;