namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do you want to use? sql, mongo, or list. ");
            var databaseType = Console.ReadLine();

            var dataAccess = DataAccessFactory.GetDataAccessType(databaseType);

            List<Product> products = dataAccess.LoadData();
            dataAccess.SaveData();
        }
    }
}
