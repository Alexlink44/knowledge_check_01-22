# Задача:
*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

# Описание решения:

* Начальный массив строк задаётся с клавиатуры.
* Создаётся новый пустой массив строк с длиной равной длине начального массива.
* Проверяется длина строк начального массива. Если длина строки меньше либо равна 3 символа, то элемент добавляется в ранее созданный массив.
* Изменяется размер второго массива. Размер массива приравнивается количеству добавленных в него элементов.
* Новый массив выводится в консоль.