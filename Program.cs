//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.

/*
int CreateArray(int size)
{
    int[] array = new int[size];
    int s = 0;
    for(int i = 0; i < size; i++)
    {
        Console.Write("Input " + i + " element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        if(array[i] > 0)
        {
            s += 1;
        }
    }
    
    return s;
}

int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CreateArray(M));
*/

//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
/*
static String ToBin(int init)
        {
            return (init == 0) ? String.Empty : ToBin(init / 2) + ((init % 2 == 0) ? "0" : "1");
        }

int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ToBin(M));
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

