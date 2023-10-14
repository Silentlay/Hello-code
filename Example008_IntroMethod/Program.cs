// Нахождение максимума из 9 чисел (функции в C# их принято называть методами)
// Классический стихийный подход
// int a1 = 15;
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 2311;
// int c2 = 33;
// int a3 = 13;
// int b3 = 23;
// int c3 = 313;

// int max = a1; // положим в max первую переменную a1
// if(b1 > max) max = b1;
// if(c1 > max) max = c1;

// if(a2 > max) max = a2;
// if(b2 > max) max = b2;
// if(c2 > max) max = c2;

// if(a3 > max) max = a3;
// if(b3 > max) max = b3;
// if(c3 > max) max = c3;

// Console.WriteLine(max);

// Далее воспользуемся функциями

int a1 = 152125;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 2311;
int c2 = 33;
int a3 = 13;
int b3 = 23111;
int c3 = 313;

int Max(int arg1, int arg2, int arg3) // наша функция возьмет 3 числа и найдет мах, потом еще 3 числа и найдет max, потом еще раз, в итоге из 3 вобедителей она выберет последний max
{
    int result = arg1; // мы определяем внутренний result, в котором будет храниться наше max значение
    if(arg2> result) result = arg2;
    if(arg3> result) result = arg3;
    return result; // return - вернуть наш result
 }
    // int max1 = Max(a1, b1, c1); // результатом работы функции max будет являться максимальное из 3х чисел a1,b1,c1
    // int max2 = Max(a2, b2, c2);
    // int max3 = Max(a3, b3, c3);
    // int max = Max(max1, max2, max3);
    // перепишем результирующий вариант
    int max = Max(
        Max(a1, b1, c1), 
        Max(a2, b2, c2),
        Max(a3, b3, c3)); // внутри аргумента мы можем использовать функцию, это небольшая отсылочка к функциональному программированию, можно сделать более компактно, но можно было оставить и так
    Console.WriteLine(max);



