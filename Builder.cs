namespace CarTest.Properties
{
    
    // Интерфейс строителя объявляет все возможные этапы и шаги конфигурации продукта
    public interface IBuilder
    {
        void Reset();
        void SetLeatherSeats();
        void SetSportEngine();
        void SetAlloyWheels();
        void SetTripComputer();
        void SetGps();
    }
}