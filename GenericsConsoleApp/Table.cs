using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsConsoleApp
{
     class Table<T>
    {
        private string Color;
        private T numOfLegs;

public Table(string Color, T numOfLegs)
        {
            this.Color = Color;
            this.numOfLegs = numOfLegs;
        }
        public T NumOfLegs
        {
            get { return this.NumOfLegs; }
            set { NumOfLegs = value; }
        }
    }
}
