namespace Pansiyon.Models
{
    public class Floor
    {
        public int Id { get; set; }
        public string Name { get; set; }


        //navigation prop.
        public List<Room> Rooms { get; set; } = new List<Room>();
        public Hotel Hotel { get; set; }
        public int HotelId { get; set; }
    }
}
