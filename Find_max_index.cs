using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_csharp
{
    public class Find_max_index
    {
        public List<int> data;

        public Find_max_index(List<int> data)
        {
            this.data = data;
        }
        public int FindMaxIndex()
        {
            int max_index = 0;
            foreach (int item in data)
            {
                if (item > max_index)
                {
                    max_index = item;
                }
            }
            return max_index;
        }
    }
}
