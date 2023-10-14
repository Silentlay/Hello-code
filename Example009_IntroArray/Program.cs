int Max(int arg1, int arg2, int arg3) // наша функция возьмет 3 числа и найдет мах, потом еще 3 числа и найдет max, потом еще раз, в итоге из 3 вобедителей она выберет последний max
{
    int result = arg1; // мы определяем внутренний result, в котором будет храниться наше max значение
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result; // return - вернуть наш result
 }
  //             0    1   2   3   4   5   6   7   8
int[] array = { 11, 211, 31, 41, 15, 61, 17, 18, 19 };

int max = Max( // или можно написать - int result = Max
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(max); // или можно написать - Console.WriteLine(result);

// для нашей задачи мы решили, но если в массиве будет 7, или тем паче 109 элементов, то будет проблема