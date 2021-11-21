namespace CarTest.Properties
{
    // Класс который разгружает метод BuyCar из класса Client для разделения зависимостей
    // Клиент покупает авто и данный класс проверяет хватает ли на это денег
    public class MoneyChecker
    {
        public bool MoneyCheck(int clientMoney,int carCost)
        {
            if (clientMoney > carCost)
            {
                clientMoney -= carCost;
                return true;
                
            }
            else
            {
                return false;
            }
        }
    }
}