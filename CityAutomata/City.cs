namespace CityAutomata
{
        using System;

        public class City
        {
                private readonly Block[][] grid;

                public City(int x, int y)
                {
                        grid = new Block[x][y];
                }

                public void ScanAll()
                {
                        for (int i = 0; i < grid.GetLength(0); i++)
                        {
                                for (int j = 0; j < grid.GetLength(1); j++)
                                {
                                        grid[i][j].Value = CalculateValue(i, j);
                                }
                        }
                }

                private float CalculateValue(int x, int y)
                {
                        float total = 0.0;

                        for (int i = 0; i < grid.GetLength(0); i++)
                        {
                                for (int j = 0; j < grid.GetLength(1); j++)
                                {
                                        if (i == x && j == y)
                                        {
                                                continue;
                                        }
                                        int xdist = x - i;
                                        int ydist = y - j;
                                        double dist = Math.Sqrt((double)(xdist * xdist + ydist * ydist));
                                        total += (float)grid[i][j].Population / dist;
                                }
                        }

                        return total;
                }
        }
}