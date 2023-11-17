namespace Pansiyon.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public bool IsPayed { get; set; }

        //navigation prop.
        public virtual Customer Customer { get; set; } //one to one with

    }
}
