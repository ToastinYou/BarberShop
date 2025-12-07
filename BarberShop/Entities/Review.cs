namespace BarberShop.Entities;

public class Review
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public string CustomerName { get; set; }

    public int BarberId { get; set; }

    public string Comment { get; set; }
}
