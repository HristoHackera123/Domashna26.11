namespace Zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> input = new LinkedList<int>();
            LinkedList<int> even = new LinkedList<int>();
            LinkedList<int> odd = new LinkedList<int>();

            Input(input);

            SplitList(input, even, odd);

            Console.WriteLine($"List of all numbers: ");
            PrintList(input);
            Console.WriteLine("List of even numbers: ");
            PrintList(even);
            Console.WriteLine("List of odd numbers: ");
            PrintList(odd);
        }
        static void Input(LinkedList<int> list)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Element for index {i}: ");
                list.AddLast(int.Parse(Console.ReadLine()));
            }
        }
        static void SplitList(LinkedList<int> list, LinkedList<int> even, LinkedList<int> odd)
        {
            foreach (int item in list)
            {
                if (item % 2 == 0)
                {
                    even.AddLast(item);
                }
                else
                {
                    odd.AddLast(item);
                }
            }
        }
        static void PrintList(LinkedList<int> list)
        {
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
