namespace Pansiyon.Models
{
    public class Customer:Person
    {
        public int DaysStayed { get; set; }


        //navigation prop.
        public virtual Payment Payment { get; set; } //one to one with

    }
}
