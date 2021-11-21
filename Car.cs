using System.Collections.Generic;

namespace CarTest.Properties
{
    // Экземпляр данного класса используется для передвижения,
    // добавления различных опций, так же в зависимости от комплектации у
    // авто будет разная цена 
    public class Car
    {
        private readonly List<object> _parts = new List<object>();

        public int Cost { get; set; } = 50000;

        public void Add(string part)
        {
            this._parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this._parts.Count; i++)
            {
                    str += this._parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2);

            return "Комплектация: " + str + "\n";
        }

        public int CarCost()
        {
            return Cost;
        }

        
        public void MoveForward()
        {
            Context context = new Context(new StateMoveForward());
            context.Request();
        }
        public void MoveLeft()
        {
            Context context = new Context(new StateMoveLeft());
            context.Request();
        }
        public void MoveRight()
        {
            Context context = new Context(new StateMoveRight());
            context.Request();
        }
        public void MoveReverse()
        {
            Context context = new Context(new StateMoveReverse());
            context.Request();
        }
        public void MoveReverseLeft()
        {
            Context context = new Context(new StateMoveReverseLeft());
            context.Request();
        }
        public void MoveReverseRight()
        {
            Context context = new Context(new StateMoveReverseRight());
            context.Request();
        }
        public void Stay()
        {
            Context context = new Context(new StateStay());
            context.Request();
        }

    }
}