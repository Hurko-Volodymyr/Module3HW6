namespace MessageBox
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var messageBox = new MessageBox();
            messageBox.OnClose += messageBox.EventHandler;
            messageBox.Open();
            Task.Delay(7000).Wait();
            Console.WriteLine("Done");
        }
    }
}