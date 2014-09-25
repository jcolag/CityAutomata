namespace TestCity
{
        using System;
        using CityAutomata;

        class MainClass
        {
                public static void Main(string[] args)
                {
                        var city = new City(20, 10);

                        for (int i = 0; i < 10000; i++)
                        {
                                city.ScanAll();
                        }

                        city.Chart();
                }
        }
}