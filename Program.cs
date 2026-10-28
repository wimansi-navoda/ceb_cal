
using System;

class Program
{
    static void Main(string[] args)
    {
        string[] UnitsArray = { "45", "30", "40", "35", "30", "15", "20" };

        int TotalUnits = 0;
        int Bill = 0;

        for (int i = 0; i < UnitsArray.Length; i++)
        {
            try
            {
                TotalUnits = TotalUnits + int.Parse(UnitsArray[i]);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid unit value found.");
            }
        }

        if (TotalUnits <= 90)
        {
            Bill = TotalUnits * 3;
        }
        else if (TotalUnits <= 150)
        {
            Bill = (90 * 3) + ((TotalUnits - 90) * 5);
        }
        else if (TotalUnits <= 200)
        {
            Bill = (90 * 3) + (60 * 5) + ((TotalUnits - 150) * 15);
        }
        else
        {
            Bill = (90 * 3) + (60 * 5) + (50 * 15)
                   + ((TotalUnits - 200) * 25);
        }

        if (TotalUnits > 101)
        {
            Bill = Bill + (Bill * 10 / 100);
        }

        Console.WriteLine("Total Units: " + TotalUnits);
        Console.WriteLine("Total Bill: " + Bill);

        Console.ReadLine();
    }
}
