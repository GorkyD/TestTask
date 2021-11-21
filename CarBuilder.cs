namespace CarTest.Properties
{
    //Реализация конкретного строителя на примере сборки авто
    public class CarBuilder : IBuilder
    {
        private Car _car = new Car();

        public CarBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            this._car = new Car();
        }

        public void SetLeatherSeats()
        {
            _car.Add("Кожаные сиденья");
            _car.Cost += 10000;
        }


        public void SetSportEngine()
        {
            _car.Add("Спортивный двигатель");
            _car.Cost += 100000;
        }

        public void SetAlloyWheels()
        {
            _car.Add("Легкосплавные диски");
            _car.Cost += 20000;
        }

        public void SetTripComputer()
        {
            _car.Add("Бортовой компьютер");
            _car.Cost += 8000;
        }

        public void SetGps()
        {
            _car.Add("Gps");
            _car.Cost += 5000;
        }

        public Car GetResult()
        {
            Car result = this._car;

            this.Reset();

            return result;
        }
    }
}