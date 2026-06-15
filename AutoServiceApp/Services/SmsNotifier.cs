namespace AutoServiceApp.Services;

public class SmsNotifier : INotifier
{
    public List<string> SentMessages { get; set; } = new();

    public void Send(string recipient,string subject, string message)
    {
        SentMessages.Add($"SMS {DateTime.Now:g} -> {recipient}: {message}");
    }
}
