public interface INotifier
{
    void Send(string recipient, string subject, string message);
}