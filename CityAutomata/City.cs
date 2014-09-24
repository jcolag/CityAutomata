namespace CityAutomata
{
        using System;
        using System.Collections.Generic;

        public class City
        {
                private readonly Block[,] grid;

                private int population = 0;

                public City(int x, int y)
                {
                        grid = new Block[x, y];
                        for (int i = 0; i < grid.GetLength(0); i++)
                        {
                                for (int j = 0; j < grid.GetLength(1); j++)
                                {
                                        grid[i, j] = new Block(5);
                                }
                        }
                }

                public void ScanAll()
                {
                        var ordering = new List<Block>();
                        int immigrants = this.population == 0 ? 100 : this.population / 10;
                        int start = immigrants;

                        for (int i = 0; i < grid.GetLength(0); i++)
                        {
                                for (int j = 0; j < grid.GetLength(1); j++)
                                {
                                        grid[i, j].Value = this.CalculateValue(i, j);
                                        ordering.Add(grid[i, j]);
                                }
                        }

                        ordering.Sort();
                        foreach (Block b in ordering)
                        {
                                if (immigrants <= 0)
                                {
                                        break;
                                }

                                immigrants = b.MoveIn(immigrants);
                        }

                        this.population += start - immigrants;

                        for (int i = 0; i < grid.GetLength(0); i++)
                        {
                                for (int j = 0; j < grid.GetLength(1); j++)
                                {
                                        grid[i, j].TakeTurn();
                                }
                        }
                }

                public void Chart()
                {
                        for (int i = 0; i < grid.GetLength(0); i++)
                        {
                                for (int j = 0; j < grid.GetLength(1); j++)
                                {
                                        Console.Write(grid[i, j].Population + "\t");
                                }

                                Console.WriteLine();
                        }

                        Console.WriteLine();
                }

                private double CalculateValue(int x, int y)
                {
                        double total = 0.0;

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
                                        total += (float)grid[i, j].Population / dist;
                                }
                        }

                        return total;
                }
        }
}