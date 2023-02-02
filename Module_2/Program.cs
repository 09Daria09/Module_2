using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите задание, которое хотите проверить: ");
            string test = Console.ReadLine();

            #region
            if (test == "1")
            {
                int sumen = 0;
                int sizeAdd = 17;
                int indexAdd = 0;
                int[] add = new int[sizeAdd];

                int count = 5;

                Random r = new Random();
                int[] A = new int[count];
                for (int i = 0; i < A.Length; i++)
                {
                    Console.Write("Введите число: ");
                    A[i] = Convert.ToInt32(Console.ReadLine());
                    add[indexAdd] = A[i];
                    indexAdd++;
                    if (A[i] % 2 == 0)
                    {
                        sumen += A[i];
                    }
                }
                Console.WriteLine();
                for (int i = 0; i < A.Length; i++)
                {
                    Console.Write("{0}|", A[i]);
                }

                Console.WriteLine();
                Console.WriteLine();

                double sumoll = 0;
                double[,] B = new double[3, 4];
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        B[i, j] = r.Next(1, 10);
                        add[indexAdd] = (int)B[i, j];
                        indexAdd++;
                        if (j % 2 != 0)
                        {
                            sumoll += B[i, j];
                        }
                        Console.Write("{0}|", B[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                int size = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    for (int j = 0; j < B.GetLength(0); j++)
                    {
                        for (int k = 0; k < B.GetLength(1); k++)
                        {
                            size++;
                        }
                    }
                }

                int[] Third = new int[size];
                int index = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    for (int j = 0; j < B.GetLength(0); j++)
                    {
                        for (int k = 0; k < B.GetLength(1); k++)
                        {
                            Third[index] = A[i];
                            index++;
                        }
                    }
                }

                int max = Third[0];
                int min = Third[0];

                for (int i = 0; i < Third.Length; i++)
                {
                    if (min > Third[i])
                    {
                        min = Third[i];
                    }
                    if (max < Third[i])
                    {
                        max = Third[i];
                    }
                }

                int mult = 1;
                int sum = 0;
                for (int i = 0; i < add.Length; i++)
                {
                    sum += add[i];
                    mult *= add[i];
                }
                Console.WriteLine($"Общее минимальное значение -> {min} \nОбщее максимальное значение -> {max}" +
                    $"\nСумма чисел -> {sum}\nПроизведение чисел -> {mult}\nСумма четных чисал массива А -> {sumen}" +
                    $"\nСумма нечетных чисел массива В ->{sumoll}");
            }
            #endregion
            #region сумма элементов массива, расположенных между минимальным и максимальным
            if (test == "2")
            {
                Random random = new Random();
                int[,] Array = new int[5, 5];
                int min = Array[0, 0];
                int max = Array[0, 0];
                int x = 0;
                int y = 0;
                int x1 = 0;
                int y1 = 0;
                int sum = 0;
                for (int i = 0; i < Array.GetLength(0); i++)
                {
                    for (int j = 0; j < Array.GetLength(1); j++)
                    {
                        Array[i, j] = random.Next(-100, 100);
                        if (min > Array[i, j])
                        {
                            min = Array[i, j];
                            x = i;
                            y = j;
                        }
                        if (max < Array[i, j])
                        {
                            max = Array[i, j];
                            x1 = i;
                            y1 = j;
                        }
                        Console.Write("{0}|", Array[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine($"Min {min} max {max}");

                int x3 = 0;
                int y3 = 0;
                if (x > x1)
                {
                    x3 = x;
                    x = x1;
                    x1 = x3;
                    y3 = y;
                    y = y1;
                    y1 = y3;
                }
                if (x == x1 && y > y1)
                {
                    y3 = y;
                    y = y1;
                    y1 = y3;
                }


                for (int i = 0; i < Array.GetLength(0); i++)
                {
                    for (int j = 0; j < Array.GetLength(1); j++)
                    {
                        if (i == x && j == y)
                        {
                            for (; x <= x1; x++)
                            {
                                for (; y < Array.GetLength(1); y++)
                                {
                                    if (x == x1 && y > y1)
                                    {
                                        break;
                                    }
                                    sum += Array[x, y];
                                    Console.Write("{0}|", Array[x, y]);
                                }
                                Console.WriteLine();
                                y = 0;
                            }
                        }
                    }
                }
                Console.WriteLine($"Сумма элементов массива, расположенных между минимальным и максимальным значением -> {sum}");
                #endregion
                #region шифр Цезаря 
                if (test == "3")
                {
                    

                }
                #endregion
            }

        }
    }
}
