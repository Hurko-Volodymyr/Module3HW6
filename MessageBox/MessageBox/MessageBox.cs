namespace MessageBox
{
    public class MessageBox
    {
        public event Action<State>? OnClose;
        public async void Open()
        {
            Console.WriteLine("Window has opened");
            await Task.Delay(3000);
            Console.WriteLine("Window has closed by user");
            OnClose?.Invoke(GetRandomStatus());
        }

        public static State GetRandomStatus()
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
    }
}
