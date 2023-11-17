namespace Pansiyon.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RoomNo { get; set; }
        public bool IsAvailable { get; set; }
        public int BedNo { get; set; }
        public decimal Price { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

       
        //navigation prop.
        public int FloorId {  get; set; }   
        public Floor Floor { get; set; }
    }
}
