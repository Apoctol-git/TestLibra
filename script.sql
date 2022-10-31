--В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.
--Product -Таблица продуктов
--Category -Таблица категорий
--По структуре предполагается, что в таблице продуктов, для каждого продукта с новой категорией создаётся новая запись. Тогда
Select p.Name, c.Name from Product p
Left Join Category c on p.CategoryId==c.Id
-- По описанным критериям данный скрипт будет работать, при условии наличия данных полей. Для других вариантов решения задачи, необходимо видеть структуру таблицы
