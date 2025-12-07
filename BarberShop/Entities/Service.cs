namespace BarberShop.Entities;

public class Service
{
    public int Id { get; set; }

    public string Title { get; set; }

    /// <summary>
    /// Average duration of the service in minutes.
    /// </summary>
    public int Duration { get; set; }
}
