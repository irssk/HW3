using System;
using System.Linq;

namespace InterfacesDemo
{
    public class MyArray : IOutput, IMath, ISort
    {
        private int[] array;

        public MyArray(int[] array)
        {
            this.array = array;
        }

        // --- IOutput ---
        public void Show()
        {
            Console.WriteLine(string.Join(" ", array));
        }

        public void Show(string info)
        {
            Console.WriteLine($"{info}: {string.Join(" ", array)}");
        }

        // --- IMath ---
        public int Max() => array.Max();

        public int Min() => array.Min();

        public float Avg() => (float)array.Average();

        public bool Search(int valueToSearch) => array.Contains(valueToSearch);

        // --- ISort ---
        public void SortAsc()
        {
            Array.Sort(array);
        }

        public void SortDesc()
        {
            Array.Sort(array);
            Array.Reverse(array);
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc) SortAsc();
            else SortDesc();
        }
    }
}
