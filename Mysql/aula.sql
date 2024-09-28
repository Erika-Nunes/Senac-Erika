SELECT ID, Name, Population
from world.city
where Population > 1000000 and CountryCode = 'BRA';

SELECT * 
FROM world.city
WHERE ID = 217;

SELECT * 
FROM world.city
WHERE Name LIKE '%a%';

select*
from world.countrylanguage
where IsOfficial = 'F'
order by Percentage desc;

SELECT * FROM world.country;

SELECT Name, Continent, LifeExpectancy
FROM world.country
ORDER BY Name;

INSERT INTO sakila.alunos(matricula, nome, cpf, email, cursando)
VALUES
(4, "Aluno 04", "081229559595-88", "aluno04@gmail.com", 0),
(5, "Aluno 05", "088445455455-99", "aluno05@gmail.com", 1);

UPDATE sakila.alunos
SET cpf = "05156156511-33"
WHERE matricula = 3;

UPDATE sakila.alunos
SET cursando = 1
WHERE matricula >= 3;

DELETE FROM sakila.alunos
WHERE matricula = 3;

SELECT * FROM sakila.alunos;

