class Program
{
    static void Main(string[] args)
    {
        int sayi1 = 10;
        int sayi2 = 20;
        sayi1 = sayi2;
        sayi2 = 35;
        Console.WriteLine(sayi1);

        int[] sayilar1 = new int[] { 10, 20, 30 };
        int[] sayilar2 = new int[] { 100, 200, 300 };
        sayilar2= sayilar1;
        sayilar2[0] = 35;
        Console.WriteLine(sayilar1[0]);
    }
}