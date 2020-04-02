using System.Collections.Generic;

namespace Cities.Comparers
{
    public class NameComparer : IComparer<City>
    {
        public int Compare(City x, City y) => string.Compare(x.Name, y.Name);
        // Since we want to sort strings, we can use the
        // comparer for the built-in string class
        
    }
}
