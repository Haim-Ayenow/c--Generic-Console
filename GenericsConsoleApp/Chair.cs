using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsConsoleApp
{
   class Chair<T>
    {
        public T height;
        public T legsNums;

        public  Chair(T height, T legsNums)
        {
            this.height = height;
            this.legsNums = legsNums;
        }
       
        

    }
}
