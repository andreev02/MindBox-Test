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
CREATE TABLE Products
(
  Id INT PRIMARY KEY IDENTITY, 
  Name VARCHAR(255) NOT NULL
);

CREATE TABLE Categories
(
  Id INT PRIMARY KEY IDENTITY,
  Name VARCHAR(255) NOT NULL
);
```

```
CREATE TABLE Product_Categories
(
  Product_Id INT(11) NOT NULL,
  Category_Id INT(11) NOT NULL
);
```

```
SELECT Products.Name, Categories.Name FROM Products
LEFT JOIN Product_Categories ON Products.Id = Product_Categories.Product_Id
INNER JOIN Categories ON Categories.Id = Product_Categories.Category_Id;
```
