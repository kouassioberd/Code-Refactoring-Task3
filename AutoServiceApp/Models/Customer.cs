namespace AutoServiceApp.Models;

public class Customer : BaseEntity, IExportable
{
    public ContactInfo ContactInfo { get; set; } = new();
    [System.Text.Json.Serialization.JsonIgnore]
    public List<Car> Cars { get; set; } = new();
    public string LastPaymentMethod { get; set; } = "cash";
    public string Format()
    {
        return $"{Name} / {Phone}";
    }

    public string Export() => $"{Name};{Phone};{Email};{Address}";
    public override string ToString() => string.IsNullOrWhiteSpace(Phone) ? Name : $"{Name} ({Phone})";
}
