using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I'm loading from a sql database.");
            return new List<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine("I'm saving to a sql database.");
        }
    }
}
