**Данный код написан для решения итоговой проверочной работы, по завешению первой четверти на программе "Разработчик"**

**Задача:**
-------------
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте вьmолнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. 

**Примеры:**
-------------
["hello", "2", "world", ":-)"] -> ["2", ":-)"] 

["1234", "1567", "-2", "computer science"] -> ["-2"] 

["Russia", "Denrnark", "Кazan"] -> [ ] 

## Описание решения

1. Задаём размер(size) первоначального массива путём ввода через консоль.

2. Если вдруг пользователь ввёл 0 или отрицательное число, то выводим сообщение, что значение массива задано неверно, если размер массива был указан верно, то продолжаем решение.

3. Инициализируем наш строковый массив (InitialStringArray), и присваиваем ему длину size(введенную ранее).

4. С помощью цикла For в ручную заполняем данный массив данными строкового значения.

5. Далее создаём новый массив (ResultingStringArray), в который будут храниться отсортированные данные из первого массива, а именно строки длинной в три символа или меньше.
    1. Условие InitialStringArray.Where(s => s.Length <= 3) используется для фильтрации элементов массива на основе условия где каждый отдельный элемент массива (взятый в виде s) должен быть равен или меньше 3 
    2. Метод .ToArray используется для преобразования результата в массив.

6. После отсортировки проверяем длину нашего нового массива если она больше 0 то продолжаем, а если нет то значит что в начальном массиве нет значений удовлетворяющих условию задачи, и следовательно выводим сообщение об этом.

7. Если есть хотя бы один элемент, то выводим его в консоль.


В папке Flowchart представлена блок-схема к данной программе.