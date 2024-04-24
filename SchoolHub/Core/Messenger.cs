public class Messenger
{
    private static Messenger instance;
    private Messenger() { }
    public static Messenger Instance => instance ??= new Messenger();

    public event Action<object> OnMessageReceived;

    public void Send(object message)
    {
        OnMessageReceived?.Invoke(message);
    }
}