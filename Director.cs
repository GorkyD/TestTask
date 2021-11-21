namespace CarTest.Properties
{
    // Данный класс необходим для того что бы заставить работать строителя
    // в нужно последовательности. Работает со строителем через общий интерфейс
    // IBuilder,благодаря этому он не знает тип изготавляемого продукта.Также
    // из-за особенностей используемого за основу паттерна Builder клиент может напрямую 
    // обращаться к строителю
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set => _builder = value;
        }
        
        // Директор может строить несколько вариаций продукта, используя
        // одинаковые шаги построения.
        public void BuildMinimalViableCar()
        {
            _builder.SetGps();
        }

        public void BuildFullFeaturedCar()
        {
            _builder.SetSportEngine();
            _builder.SetLeatherSeats();
            _builder.SetTripComputer();
            _builder.SetGps();
            _builder.SetAlloyWheels();
        }
    }
}