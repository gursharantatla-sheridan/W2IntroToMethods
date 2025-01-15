namespace W2IntroToMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            string s = "hello";
            int[] a = { 1, 2, 3 };

            Console.WriteLine("Before changes:");
            Console.WriteLine("n = " + n);
            Console.WriteLine("s = " + s);
            Console.WriteLine("a[0] = " + a[0]);

            ChangeValue(ref n, s, a);

            Console.WriteLine("\n\nAfter changes:");
            Console.WriteLine("n = " + n);
            Console.WriteLine("s = " + s);
            Console.WriteLine("a[0] = " + a[0]);



            int x = 10, y = 20;
            //int sum, mul;

            Calculate(x, y, out int sum, out int mul);

            Console.WriteLine("\n\nSum = " + sum);
            Console.WriteLine("Mul = " + mul);



            //Console.Write("\n\nEnter a number: ");
            //if (int.TryParse(Console.ReadLine(), out int num))
            //    Console.WriteLine("num = " + num);
            //else
            //    Console.WriteLine("Invalid input. Please try again.");

            Console.WriteLine("\n\n");


            int p = 3, q = 5, r = 8;

            Console.WriteLine("p = " + p + ", q = " + q + ", r = " + r);
            Console.WriteLine($"p = {p}, q = {q}, r = {r}");
            Console.WriteLine("p = {0}, q = {1}, r = {2}", p, q, r);


            int[] arr = { 1, 2, 3, 4, 5, 6 };

            PrintArray(arr);
            PrintArray(3, 45, 5, 6, 7, 8, 8, 8, 7, 6, 5, 45, 4);
        }


        static void PrintArray(params int[] a)
        {
            Console.WriteLine("\n\nNumber of items: " + a.Length);

            foreach (var i in a)
                Console.Write(i + " ");
            Console.WriteLine();
        }


        static void Calculate(int a, int b, out int sum, out int mul)
        {
            sum = a + b;
            mul = a * b;
        }




        static void ChangeValue(ref int num, string str, int[] arr)
        {
            num = 100;
            str = "bye";
            arr[0] = 100;
        }
    }
}
