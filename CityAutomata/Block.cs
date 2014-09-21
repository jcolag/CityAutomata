namespace CityAutomata
{
        using System;

        public class Block
        {
                private readonly int capacity;

                private int level = 1;

                private int population = 0;

                private float value = 0;

                private int cost = 0;

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

                public float Value
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
        }
}