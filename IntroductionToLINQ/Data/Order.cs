namespace IntroductionToLINQ.Data;

public class Order {
    public int Id { get; set; }
    public int Quantity { get; set; }
    public bool Shipped { get; set; }
    public string Month { get; set; }
    public int ProductId { get; set; }
    public override string ToString() => $"Order Id: {Id} - ProductId: {ProductId} - Quantity: {Quantity} - Shipped: {Shipped} - Month: {Month}";
}
