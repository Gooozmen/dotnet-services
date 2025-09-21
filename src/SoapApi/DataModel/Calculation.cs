namespace SoapApi.DataModel;

public class Calculation
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Operation { get; set; } = string.Empty; // "Add", "Subtract"
    public decimal Operand1 { get; set; }
    public decimal Operand2 { get; set; }
    public decimal Result { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
