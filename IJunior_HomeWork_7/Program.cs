using System;

namespace IJunior_HomeWork_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountGold;
            int countCrystals;
            int priceCrystal = 50;
            Console.WriteLine("Добро пожаловать в магазин кристаллов!!!");
            Console.WriteLine("Сколько у вас золота ?");
            amountGold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сколько кристаллов вы хотите приобрести ?");
            countCrystals = Convert.ToInt32(Console.ReadLine());
            amountGold -= (countCrystals * priceCrystal);
            Console.WriteLine($"Количество кристаллов: {countCrystals} . Остаток золота: {amountGold}. ");
        }
    }
}
