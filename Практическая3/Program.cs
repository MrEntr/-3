internal class Program
{
    static void Main()
    {
        Console.WriteLine("Пианино октавы и переключение");
        ccc();
    }
    static void ccc()
    {
        int[] one = new int[12] { 3270,3460, 3670, 3880, 4120, 4360, 4620, 4900, 5190, 5500, 5820, 6170 };
        int[] two = new int[12] { 6540, 6930, 7340, 7770, 8240, 8730, 9250, 9800, 10300, 11000, 11600, 12300 };
        ConsoleKeyInfo x = Console.ReadKey();
        if (x.Key == ConsoleKey.F1)
        {
            oc1(one);
        }
        if (x.Key == ConsoleKey.F2)
        {
            oc1(two);
        }
    }
    static void oc1(int[] one)
    {
        while (true)
        {
            ConsoleKeyInfo i = Console.ReadKey();
            if (i.Key == ConsoleKey.A)
            {
                Console.Beep(one[0], 400);
            }
            if (i.Key == ConsoleKey.B)
            {
                Console.Beep(one[1], 400);
            }
            if (i.Key == ConsoleKey.C)
            {
                Console.Beep(one[2], 400);
            }
            if (i.Key == ConsoleKey.D)
            {
                Console.Beep(one[3], 400);
            }
            if (i.Key == ConsoleKey.E)
            {
                Console.Beep(one[4], 400);
            }
            if (i.Key == ConsoleKey.F)
            {
                Console.Beep(one[5], 400);
            }
            if (i.Key == ConsoleKey.G)
            {
                Console.Beep(one[6], 400);
            }
            if (i.Key == ConsoleKey.H)
            {
                Console.Beep(one[7], 400);
            }
            if (i.Key == ConsoleKey.I)
            {
                Console.Beep(one[8], 400);
            }
            if (i.Key == ConsoleKey.G)
            {
                Console.Beep(one[9], 400);
            }
            if (i.Key == ConsoleKey.K)
            {
                Console.Beep(one[10], 400);
            }
             if (i.Key == ConsoleKey.L)
            {
                Console.Beep(one[11], 400);
            }
        }
    }
}