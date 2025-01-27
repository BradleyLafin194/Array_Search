namespace Array_Search
//Problem 1: Write a C# program to count how many times the number 7 is repeated in the given array of integers. Input Array: {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9}. Use in-built methods from the Array class in C#.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int numb;
            int[] numbers = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 7, 8, 8, 9 };
            int index = (numbers.Length);
            index = 0;
           
            while (index < 16) 
            {
                
                numb = numbers[index];
                if (numb == 7)
                {
                    count = count + 1;  
                }

                index = (index + 1);
            }
            
            Console.WriteLine(count);
            
        }
    }
}
