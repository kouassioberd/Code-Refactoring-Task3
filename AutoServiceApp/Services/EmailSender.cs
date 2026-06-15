namespace AutoServiceApp.Services;

public class EmailSender : INotifier
{
    public List<string> Log { get; set; } = new();

    public void Send(string recipient, string subject, string message)
    {
        Log.Add($"EMAIL {DateTime.Now:g} -> {recipient}: {subject} {message}");
    }
}
