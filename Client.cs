namespace CarTest.Properties
{
    // Класс клиента который может купить авто и после покупки получить к нему доступ
    public class Client
    {
        public int Money { get; set; } = 200000;

        private bool _carAcces = false;

        public Car car;

        private MoneyChecker _moneyChecker = new MoneyChecker();

        public bool BuyCar(int carCost)
        {
            if (_moneyChecker.MoneyCheck(Money,carCost))
            {
                _carAcces = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Access(Car _car)
        {
            if (_carAcces)
            {
                this.car = _car;
            }
        }
        

    }
}