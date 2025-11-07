using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 2, 9, 1, 7 };
            MyArray myArray = new MyArray(numbers);

            Console.WriteLine("=== Вивід масиву ===");
            myArray.Show();
            myArray.Show("Масив елементів");

            Console.WriteLine("\n=== Математичні операції ===");
            Console.WriteLine($"Максимум: {myArray.Max()}");
            Console.WriteLine($"Мінімум: {myArray.Min()}");
            Console.WriteLine($"Середнє: {myArray.Avg()}");
            Console.WriteLine($"Пошук 9: {myArray.Search(9)}");
            Console.WriteLine($"Пошук 100: {myArray.Search(100)}");

            Console.WriteLine("\n=== Сортування ===");
            myArray.SortAsc();
            myArray.Show("Після сортування за зростанням");

            myArray.SortDesc();
            myArray.Show("Після сортування за спаданням");

            myArray.SortByParam(true);
            myArray.Show("Сортування з параметром true");

            myArray.SortByParam(false);
            myArray.Show("Сортування з параметром false");

            Console.ReadKey();
        }
    }
}
