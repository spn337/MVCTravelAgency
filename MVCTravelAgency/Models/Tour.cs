namespace MVCTravelAgency.Models
{
    public class Tour
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public string DepartureTown { get; set; }
        public ushort Period { get; set; }
        public bool IsNightCrossing { get; set; }
        public string Countries { get; set; }
        public ushort Price { get; set; }
        public string DepartureDate { get; set; }
        public bool isFavorite { get; set; }
        public virtual Category Category { get; set; }
    }
}
