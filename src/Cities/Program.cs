using System;
using System.Collections.Generic;
using Cities.Comparers;

namespace Cities
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<City> cities = CityDataImporter.LoadData();

            // TODO Swap out comparers as desired
            IComparer<City> comparer = new NameComparer();
            IComparer<City> statecomp = new StateComparer();
            IComparer<City> popcomp = new PopulationComparer();
            IComparer<City> areacomp = new AreaComparer();
            cities.Sort(areacomp);

            PrintCities(cities);

            Console.ReadLine();
        }

        private static void PrintCities(List<City> cities)
        {
            Console.WriteLine(City.GetTableHeader());

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

        }
    }
}
