using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public partial class Counter
    {
        private const int min = -99;
        private const int max = 99;

        private int count;
        public int Count
        {
            get { return count; }
            set
            {
                // ternary operator - fast solution
                // count = value >= min && value <= max ? value : 0;

                // better solution
                if (value < min || count < min) { count = min; }
                else if (value > max || count > max) { count = max; }
                else { count = value; }
            }
        }

        public Counter()
        {
            count = 0;
        }

        /// <summary>
        /// Increases the counter by a predetermined amount
        /// </summary>
        /// <param name="amount"></param>
        public void increaseAmount(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Only positive numbers!");
                return;
            }
            Count += amount;
        }

        /// <summary>
        /// Decreases the counter by a predetermined amount
        /// </summary>
        /// <param name="amount"></param>
        public void decreaseAmount(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Only positive numbers!");
                return;
            }
            Count -= amount;
        }

        /// <summary>
        /// Increases counter by 1 
        /// </summary>
        public void increase()
        {
            Count++;
        }

        /// <summary>
        /// Decreases counter by 1 
        /// </summary>
        public void decrease()
        {
            Count--;
        }
    }
}
