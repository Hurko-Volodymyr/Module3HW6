namespace MessageBox
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var messageBox = new MessageBox();
            var tcs = new TaskCompletionSource();
            messageBox.OnClose += (State state) =>
            {
                if (state == State.Ok)
                {
                    Console.WriteLine("Operation is succesfull");
                }
                else
                {
                    Console.WriteLine("Operation has denied");
                }

                tcs.SetResult();
            };

            messageBox.Open();
            await tcs.Task;
        }
    }
}