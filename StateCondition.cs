using System;

namespace CarTest.Properties
{
    // Конкретные Состояния реализуют различные модели поведения, связанные с
    // состоянием Контекста.
    class StateMoveForward : State
    {
        public override void Handle()
        {
            var movingForward = CarControl.Condition.MovingForward;
            if (movingForward != 0)
            {
                Console.WriteLine("Машина едет прямо");
            }
            else
            {
                StateDefected.Defected();
            }
        }
    }
    class StateMoveLeft : State
    {
        public override void Handle()
        {
            var movingLeft = CarControl.Condition.MovingForwardLeft;
            if (movingLeft != 0)
            {
                Console.WriteLine("Машина едет налево");
            }
            else
            {
                StateDefected.Defected();
            }
        }
    }
    class StateMoveRight : State
    {
        public override void Handle()
        {
            var movingRight = CarControl.Condition.MovingForwardRight;
            if (movingRight != 0)
            {
                Console.WriteLine("Машина едет вправо");
            }
            else
            {
                StateDefected.Defected();
            }

        }
    }
    class StateMoveReverse : State
    {
        public override void Handle()
        {
            var movingReverse = CarControl.Condition.MovingReverse;
            if (movingReverse != 0)
            {
                Console.WriteLine("Машина едет назад");
            }
            else
            {
                StateDefected.Defected();
            }
        }
    }
    class StateMoveReverseLeft : State
    {
        public override void Handle()
        {
            var movingReverseLeft = CarControl.Condition.MovingReverseLeft;
            if (movingReverseLeft != 0)
            {
                Console.WriteLine("Машина едет задом влево");
            }
            else
            {
                StateDefected.Defected();
            }
        }
    }
    class StateMoveReverseRight : State
    {
        public override void Handle()
        {
            var movingReverseRight = CarControl.Condition.MovingReverseRight;
            if (movingReverseRight != 0)
            {
                Console.WriteLine("Машина едет задом вправо");
            }
            else
            {
                StateDefected.Defected();
            }
        }
    }
    class StateStay : State
    {
        public override void Handle()
        {
            var stay = CarControl.Condition.Stay;
            if (stay == 0)
            {
                Console.WriteLine("Машина стоит");
            }
            else
            {
                StateDefected.Defected();
            }
        }
    }
    class StateDefected
    {
        public static void Defected()
        {
            Console.WriteLine("Машина сломалась :c Едь на сто ");
        }
    }
}