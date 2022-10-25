using System;
using System.Threading;

namespace MessageBox
{
    internal partial class MessageBox
    {
        private event Action<State>? OnClose;

        public async void Open()
        {
            Console.WriteLine("Window has opened");
            await Task.Delay(3000);
            Console.WriteLine("Window has closed by user");
            OnClose = EventHandler;
            OnClose?.Invoke(GetRandomStatus());
        }

        private State GetRandomStatus()
        {
            var rnd = new Random().Next(0, 2);
            if (rnd == 1)
            {
                return State.Ok;
            }
            else
            {
                return State.Cancel;
            }
        }

        private void EventHandler(State state)
        {
            if (state == State.Ok)
            {
                Console.WriteLine("Operation is succesfull");
            }
            else
            {
                Console.WriteLine("Operation has denied");
            }
        }
    }
}
