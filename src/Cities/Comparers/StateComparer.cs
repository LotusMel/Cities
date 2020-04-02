using System;
using System.Collections.Generic;
using System.Text;

namespace Cities.Comparers
{
    public class StateComparer : IComparer<City>
    {
        public int Compare(City x, City y) => string.Compare(x.State, y.State);
            // Since we want to sort strings, we can use the
            // comparer for the built-in string class
            
    }
}
