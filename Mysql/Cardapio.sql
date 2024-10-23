INSERT INTO cardapiosenac.produtos
(nome, valor, categoria)
VALUE 		('teste', '5.6', 'teste');

DELETE FROM cardapiosenac.produtos
WHERE id = '4';

UPDATE cardapiosenac.produtos
SET  nome = 'testeupdate', valor = '3.5', categoria = 'testeupdate'
WHERE id = '6';

SELECT * FROM cardapiosenac.produtos;

SELECT *
FROM cardapiosenac.produtos
WHERE id = '6';