namespace Pansiyon.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }


        //navigation prop.
        public List<Floor> Floors { get; set; } = new List<Floor>();
    }
}
