using System;

namespace CarTest.Properties
{
    // Реализация управления авто через перечесление с побитовым флагом,
    // что позволяет складывать состояния между собой и на их
    // основе реализовывать управление авто
    public class CarControl
    {
        [Flags]
        public enum Condition
        {
            // Из-за того, что состояний не много решил приравнивать к степени двойки 
            // так же можно было представить в виде : 0b00000001 и т.д.
            Not        = 1,
            Accelerate = 2,
            Forward    = 4,
            Left       = 8,
            Right      = 16,
            Reverse    = 32,

            MovingForward = Forward | Accelerate,
            MovingForwardLeft = Left | Forward | Accelerate,
            MovingForwardRight = Right | Forward | Accelerate,
            MovingReverse = Forward | Reverse | Accelerate,
            MovingReverseLeft = Left | Reverse | Accelerate,
            MovingReverseRight = Right | Reverse | Accelerate,
            Stay = Not & Left & Right & Reverse & Forward
            
        }
    }
}
