using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GenericsConsoleApp
{
    class Furniture<T>
    {
        public T TablesNums;
        public T ChairsNums;
        public T closets;
        public List<T> size;
    
    public Furniture(T TablesNums, T ChairsNums, T closets)
    {
        this.TablesNums = TablesNums;
        this.ChairsNums = ChairsNums;
        this.closets = closets;
     

    }
}
}
