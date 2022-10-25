namespace MessageBox
{
    internal class Program
    {
        private event Action<State>? OnClose;

        public static void Main(string[] args)
        {
            var messageBox = new MessageBox();
            var program = new Program();
            messageBox.Open();
            program.OnClose = program.EventHandler;
            program.OnClose?.Invoke(messageBox.GetRandomStatus());
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