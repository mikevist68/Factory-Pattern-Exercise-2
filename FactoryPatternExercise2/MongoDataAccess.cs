﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("Loading from a mongo database");
            return new List<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine("I'm saving to Mongo Database.");
        }
    }
}
