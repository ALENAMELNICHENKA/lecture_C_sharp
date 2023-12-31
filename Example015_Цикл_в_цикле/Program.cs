﻿// Цикл в цикле
// Мы узнали новую синтаксическую конструкцию. Теперь пора узнать, что можно использовать
// цикл внутри цикла. Где это бывает нужно? Самый простой пример, вам захотелось закрасить
// какую-то прямоугольную область. В этой области есть строки и столбцы. Соответственно, мы
// будем пробегать по всем строкам и столбцам, и что-то делать. Может быть, одним цветом
// закрашивать, может быть разным это зависит от задачи. Но пока посмотрим, каким образом
// можно использовать эту возможность.
// Классической демонстрацией использования циклов в цикле я предлагаю рассмотреть задачу
// вывода таблицы умножения на экран. Итак, идея следующая:
for (int i = 2; i <= 10; i++)//указываем начальное значение.
                            //Таблица умножения начинается с 2. Затем говорим, что пока счётчик i меньше или равен 10,
                            //надо его увеличивать. 
{
    for (int j = 2; j <= 10; j++)//После возьмём второй цикл, обратите внимание, что в первом
                            //(внешнем) цикле использовался счётчик i, значит, внутренний будет j, который мы также
                             //будем менять. Например, от 2 до меньше или равен 10.
    {
Console.WriteLine($"{i} * {j} = {i * j}");//телом второго цикла мы укажем непосредственное произведение. Сделать это можно различными способами. 
                                         //Я использую интерполяцию строк.
    }
Console.WriteLine();//Но есть проблема, связанная с тем, что вся таблица идёт без разделений на части. Чтобы это
                    //исправить после того, как отработает второй цикл, в нашем случае
                    //Делаем переход на новую строку.//Console.WriteLine();
}


