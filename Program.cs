using System;
using CarTest.Properties;

namespace CarTest
{
    // За основу создания авто выбран паттерн проектирования Строитель
    // который как я считаю идеально для этого подходит. Минусом данного решения вижу
    // то, что пользователь будет привязан к классу CarBuilder так как Директор не возвращает 
    // метод получения результата. Но плюсами будет возможность создавать продукты пошагово,
    // данный паттерн позволяет использовать один и тот же код для создания различных продуктов,
    // а самое главное это изоляция  сложного кода сборки продукта(машины) от его логики (передвижение).
    // Управления авто реализовано через паттерн Состояние, что в свою очередь избавляет код от
    // избыточного использования условных операторов и концетрирует в одном месте код связанный 
    // с определенным состоянием. Минусом данного выбора будет то, что если состояний мало и они 
    // редко меняются код неоправданно усложняется.
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Director director = new Director(); 
            CarBuilder builder = new CarBuilder();
            Client client = new Client();
            
            director.Builder = builder;
            
            Console.WriteLine("Базовая комплектация машины:");
            director.BuildMinimalViableCar();
            Console.WriteLine(builder.GetResult().ListParts());
            
            Console.WriteLine("Максимальная комплектация машины:");
            director.BuildFullFeaturedCar();
            Console.WriteLine(builder.GetResult().ListParts());

            Console.WriteLine("Кастомная комплектация машины:");
            builder.SetSportEngine();
            builder.SetAlloyWheels();

            var car = builder.GetResult();
            Console.WriteLine(car.ListParts());
            Console.WriteLine( car.CarCost());
            
            client.BuyCar(car.CarCost());

            client.Access(car);
            
            client.car.MoveForward();

        }
    }
    
}