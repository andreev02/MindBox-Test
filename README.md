# MindBox-Test
Тестовое задание для MindBox на позицию стажера .NET

## Задание №1
Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

- Юнит-тесты

- Легкость добавления других фигур

- Вычисление площади фигуры без знания типа фигуры в compile-time

- Проверку на то, является ли треугольник прямоугольным

## Задание №2
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. 
Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

#### Решение:

```
CREATE TABLE products
(
  id INT PRIMARY KEY IDENTITY, 
  name VARCHAR(255) NOT NULL
);

CREATE TABLE categories
(
  id INT PRIMARY KEY IDENTITY,
  name VARCHAR(255) NOT NULL
);
```

```
CREATE TABLE product_categories
(
  product_id INT(11) NOT NULL,
  category_id INT(11) NOT NULL
);
```

```
SELECT products.name, categories.name FROM products
LEFT JOIN product_categories ON Products.id = product_categories.product_id
INNER JOIN categories ON categories.id = product_categories.category_id;
```
