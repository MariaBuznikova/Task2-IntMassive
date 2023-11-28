using System;
using static ОдномерныйМассив.Class1;

namespace ОдномерныйМассив
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Massiv mass1 = new Massiv(11);
            mass1.InputData(5, 2, 4, 2, 1, 7, 7, 15, 3, 2, 9);
            Console.WriteLine("Massive1: ");
            for (int i = 0; i < mass1.size; i++)
            {
                Console.Write(mass1.mass[i] + "; ");
            }
            Console.WriteLine();
            mass1.Print();
            Console.WriteLine("Поиск числа\nКакое число ищем?");
            int a = int.Parse(Console.ReadLine());
            int[] indMass = mass1.FindValue(a);
            Console.Write($"\nИндексы {a} в массиве: ");
            for (int i = 0; i < indMass.Length; i++)
            {
                Console.Write(indMass[i] + "; ");
            }
            Console.WriteLine();
            mass1.Sort();
            Console.WriteLine("Сортировка \nОтсортированный массив 1");
            for (int i = 0; i < mass1.size; i++)
            {
                Console.Write(mass1.mass[i] + "; ");
            }
            Console.WriteLine();
            Console.WriteLine("Удаление числа из массива \nКакое число удалить?");
            int d = int.Parse(Console.ReadLine());
            
            int[] delMass = mass1.DelValue(d);
            Console.Write($"\nУдаляем число {d}: ");
            Console.WriteLine();
            mass1.Print();
            
            Massiv mass2 = new Massiv(mass1.size);
            Console.WriteLine("Massive2: ");
            mass2.InputDataRandom();
            for (int i = 0; i < mass2.size; i++)
            {
                
                Console.Write(mass2.mass[i] + "; ");
            }

            Console.Write("\nСкладываем первый и второй массив: ");
            Massiv rez1 = mass1.Add(mass2);
            for (int i = 0; i < rez1.size; i++)
            {

                Console.Write(rez1.mass[i] + "; ");
            }
            Massiv mass3 = new Massiv(5);
            Console.WriteLine("\nMassive3: ");
            mass3.InputDataRandom();
            for (int i = 0; i < mass3.size; i++)
            {

                Console.Write(mass3.mass[i] + "; ");
            }
            Console.Write("\nСкладываем первый и третий массив: ");
            Massiv rez2 = mass1.Add(mass3);
        }
    }
}
