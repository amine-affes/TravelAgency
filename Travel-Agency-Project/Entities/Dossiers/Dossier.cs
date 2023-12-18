using Travel_Agency_Project.Entities.Clients;
using Travel_Agency_Project.Entities.Products;

namespace Travel_Agency_Project.Entities.Dossiers
{
    public class Dossier
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public DateTime ArrivalDate { get; set; }
        public int Duration { get; set; }
        public string FlightNumber { get; set; }
        public virtual Product Product { get; set; }
        public virtual Client Client {  get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
