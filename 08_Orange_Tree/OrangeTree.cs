using System;

namespace _08_Orange_Tree
{
    public class OrangeTree
    {
        private int v1;
        private int v2;

        public OrangeTree(int v1, int v2)
        {
            this.Age = v1;
            this.Height = v2;
        }

        public int Age { get; internal set; }

        private string height;
        public int Height { get; internal set; }

        public int NumOranges { get; internal set; }

        public bool TreeAlive { get; internal set; }


        public int OrangesEaten { get; internal set; }


        internal void OneYearPasses()
        {
                         Age = Age + 1 ;
                         Height = Height + 2;
                         if (Age >= 2)
                             {
                                 NumOranges = NumOranges + 5;
                             }
            


             if (Age >= 80) TreeAlive = false;
                    }



        internal void EatOrange(int v)
        {
                         if (NumOranges - v <= 0) throw new IndexOutOfRangeException("You can't eat an orange that isn't there!  There are 0 oranges available to eat");
                         else 
             
                                 NumOranges = NumOranges - v;
                                 OrangesEaten = OrangesEaten + v;
                             }
                     }

    }
