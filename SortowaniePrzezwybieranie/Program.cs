using System;

class Program
{
    class Sorter
    {
        private int[] array;

        public Sorter(int size)
        {
            array = new int[size];
        }

        public void ReadArray()
        {
            Console.WriteLine("Wprowadź 10 liczb całkowitych:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void SelectionSortDescending()
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int maxIndex = FindMaxIndex(i);
                Swap(i, maxIndex);
            }
        }

        private int FindMaxIndex(int startIndex)
        {
            int maxIndex = startIndex;
            for (int i = startIndex + 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        private void Swap(int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        public void PrintArray()
        {
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        const int size = 10;

        Sorter sorter = new Sorter(size);
        sorter.ReadArray();

        Console.WriteLine("Tablica przed sortowaniem:");
        sorter.PrintArray();

        sorter.SelectionSortDescending();

        Console.WriteLine("Tablica po sortowaniu malejąco:");
        sorter.PrintArray();
        Console.WriteLine("Thank you for using this algorythm");
    }
}