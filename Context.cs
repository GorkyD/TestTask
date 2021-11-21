using System;

namespace CarTest.Properties
{
    // Контекст хранит ссылку на экземпляр подкласса Состояния, который отображает
    // текущее состояние Контекста
    public class Context
    {
        // Ссылка на текущее состояние Контекста.
        private State _state;

        public Context(State state)
        {
            this.TransitionTo(state);
        }
        // Контекст позволяет изменять объект Состояния во время выполнения
        public void TransitionTo(State state)
        {
            Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
            this._state = state;
            this._state.SetContext(this);
        }
        // Контекст делегирует часть своего поведения текущему объекту Состояния
        public void Request()
        {
            this._state.Handle();
        }

    }
}