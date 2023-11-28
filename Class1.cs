using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОдномерныйМассив
{
    class Class1
    {
        public class Massiv
        {
            public int size = 0;
            public int[] mass;

            public Massiv(int s)
            {
                size = s;
                mass = new int[size];
            }

            public void InputData(params int[] m) //params
            {
                if (m.Length == 0)
                {
                    Console.WriteLine("Массив пуст!");
                }
                else
                {
                    for (int i = 0; i < m.Length; i++)
                    {
                        mass[i] = m[i];
                    }
                }
            }
            public void InputDataRandom()
            {
                int[] mass1 = new int[size];
                Random r = new Random();
                if (size == 0)
                {
                    Console.WriteLine("Массив не существует!!!");
                }
                else
                {
                    
                    for (int i = 0; i < size; i++)
                    {
                        mass1[i] = r.Next(0, 101);
                    }
                }
                mass = mass1;
            }
            public void Print()
            {
                Console.Write("Первый индекс: ");
                int s = int.Parse(Console.ReadLine());
                Console.Write("Конечный индекс: ");
                int f = int.Parse(Console.ReadLine());
                if(s>f)
                {
                    Console.WriteLine("Ошибка ввода!");
                }
                if (size == 0)
                {
                    Console.WriteLine("Массив пуст!!!");
                }
                if (f > size)
                {
                    Console.WriteLine("Конечный индекс вышел за пределы массива!!!");
                }
                else
                {
                    for (int i = s; i < f; i++)
                    {
                        Console.Write(mass[i] + "; ");
                    }
                    Console.WriteLine();
                }
            }        
            public int[] FindValue(int el)
            {
                int new_s = 0;
                //определяем размер нового массива индексов
                for (int i = 0; i < mass.Length; i++)
                {
                    if (mass[i] == el)
                    {
                        new_s++;
                    }
                }
                int[] FindValue = new int[new_s];
                int p = 0;
                for (int i = 0; i < mass.Length; i++)
                {
                    if (mass[i] == el)
                    {
                        FindValue[p] = i;
                        p++;
                    }
                }
                return FindValue;
            }
            public int[] DelValue(int value)
            {
                int count = 0;

                // кол-во элементов, которое надо удалить
                for (int i = 0; i < mass.Length; i++)
                {
                    if (mass[i] == value)
                    {
                        count++;
                    }
                }
                int[] NewMass = new int[mass.Length - count];
                int index = 0;

                // копирование элементов из исходного массива в новый массив
                for (int i = 0; i < mass.Length; i++)
                {
                    if (mass[i] != value)
                    {
                        NewMass[index] = mass[i];
                        index++;
                    }
                }
                size -= count;
                mass = NewMass;
                return NewMass;
            }
            public int FindMax()
            {
                int max = 0;
                for (int i = 1; i < mass.Length; i++)
                {
                    if (mass[i] > max)
                    {
                        max = mass[i];
                    }
                }
                Console.WriteLine("Максимальное значение: " + max);
                return max;
            }
            public Massiv Add(in Massiv mass2)
            {
                if (mass2.size != size)
                {
                    Console.WriteLine("Разные длины массивов");
                    return new Massiv(0);
                }
                else
                {
                    Massiv rez = new Massiv(size);
                    int[] vs = new int[size];
                    for (int i = 0; i < size; i++)
                    {
                        vs[i] = mass[i] + mass2.mass[i];
                    }
                    rez.InputData(vs);
                    return rez;
                }


            }
            public void Sort()
            {
                int n = mass.Length;

                // Алгоритм сортировки пузырьком (Bubble Sort)
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (mass[j] > mass[j + 1])
                        {
                            // Обмен значениями текущего элемента и следующего элемента
                            int buf = mass[j];
                            mass[j] = mass[j + 1];
                            mass[j + 1] = buf;
                        }
                    }
                }
            }
        }
    }
}
