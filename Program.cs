namespace Assignment_7._1
{
    class Program
    {
        static void Main()
        {
            // Exam scores 
            int[] examScores = { 85, 92, 78, 95, 88, 70, 91, 82 };

            SelectionSort(examScores);

            Console.WriteLine("Sorted exam scores:");
            PrintArray(examScores);
        }

        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                // Find the minimum element in the remaining unsorted part
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Swap the minimum element with the first element
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
