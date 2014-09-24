﻿namespace CityAutomata
{
        using System;

        public class Block: IComparable
        {
                private readonly int capacity;

                private int level = 1;

                private int population = 0;

                private double value = 0;

                private int cost = 100;

                private int collected = 0;

                public Block(int capacity)
                {
                        this.capacity = capacity;
                }

                public int Population
                {
                        get
                        {
                                return this.population;
                        }
                }

                public double Value
                {
                        get
                        {
                                return this.value;
                        }

                        set
                        {
                                this.value = value;
                        }
                }

                public int Cost
                {
                        get
                        {
                                return cost;
                        }
                }

                public int MoveIn(int number)
                {
                        int diff = 0;

                        this.population += number;
                        if (this.population > this.capacity * this.level)
                        {
                                diff = this.population - this.capacity * this.level;
                                this.population = this.capacity * this.level;
                        }

                        return diff;
                }

                public void TakeTurn()
                {
                        this.collected += this.Cost / this.capacity / 10 * this.population;
                        if (this.collected > this.cost)
                        {
                                this.level += 1;
                                this.collected -= this.cost;
                                this.cost *= 2;
                        }
                }

                #region IComparable implementation

                public int CompareTo(object obj)
                {
                        if (!(obj is Block))
                        {
                                throw new ArgumentException("Blocks can only be compared to Blocks");
                        }
                        var b = (Block)obj;
                        double thisval = this.value - this.cost;
                        double thatval = b.Value - b.Cost;
                        return thisval.CompareTo(thatval);
                }

                #endregion
        }
}