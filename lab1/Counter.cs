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
                if (value < min) { throw new Exception($"Value '{value}' is too low"); }
                else if (value > max) { throw new Exception($"Value '{value}' is too high"); }
                else { count = value; }
            }
        }

        public Counter()
        {
            count = 0;
        }

        /// <summary>
        /// Allows you to increase or decrease the counter by a certain amount
        /// </summary>
        /// <param name="amount"></param>
        public void countManagement(int amount)
        {
            Count += amount;
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
