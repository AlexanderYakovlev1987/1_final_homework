## Итоговая проверочная работа

Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе разработчик. Мы должны убедиться, что базовое знакомство с it прошло успешно.

### Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу

> *Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что все залито одним коммитом, как минимум этапы 2,3 и 4 должны быть расположены в разных коммитах)*

### Задача

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

### *Примеры:*

> ["hello", "2", "world", ":-)"]-> ["2", ":-)"]

> ["1234", "1567", "-2", "computer science"] -> ["-2"]

> ["Russia", "Denmark", "Kazan"] -> []


## Описание алгоритма решения

 ### Создаем метод FillingArray:
 - В методе создаем счетчик, переменную count, для  поочередного копирования элементов из изначального массива array1 в результирующий array2 без пробелов. 
 - Внутри цикла идет проверка условия ( <=3 ), если да, то элемент изначального массива заносится в count элемент результирующего массива.  После этого увеличивается переменная count на 1 и возвращается к циклу for в котором i увеличивается на 1. И так проверяется пока не проверми все элементы изначального масства счетчиком i. 

### Main
- Объявляем два массива: изначальный sourceArray и результирующий длиной равной изначальному resultingArray массиву.
- Обращаемся к созданому методу FillingArray с параметрами массивов (sourceArray, resultingArray).
- Убираем пустые индексы из результирующего массива.
- Выводим результат в консоль, согласно маске показаной в примерах к задаче.

> Графическое представление метода файл FillingArrayMetod.drawio

> Реализация алгоритма файл Program.cs
