**Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Решение поставленной задачи:**
> Условие: первоначальный строчный массив array [] нам задан.

1. Заводим счетчик count.
2. Пишем цикл, в котором рассматриваем каждый элемент массива array и проверяем условие: длина текущего элемента меньше или равна трем символам?
3. Если условие выполняется, то счетчик увеличивается. 
4. Если условие не выполняется, переходим к следующему элементу массива array.
5. После проверки всех элементов массива array, заводим новый массив result с длиной count и переменную j равную 0.
6. Пишем цикл, в котором рассматриваем каждый элемент массива array и проверяем условие: длина текущего элемента меньше или равна трем символам?
7. Если условие из п.6 выполняется, то запоминаем текущий элемент массива array в j-тый элемент массива result, увеличиваем j на единицу.
8. Если условие не выполняется, переходим к следующему элементу массива array.
9. После рассмотрения всех элементов массива array, выводим на экран результат массива result.