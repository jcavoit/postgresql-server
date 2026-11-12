namespace PostgreSqlServer.Database
{
    public class MyDatabase
    {
        private List<Car> cars;

        public MyDatabase()
        {
            cars = new List<Car>();
        }

        public IEnumerable<Car> GetAll()
        {
            return cars;
        }

        public void Add(Car newcar)
        {
            cars.Add(newcar);
        }
    }
}
