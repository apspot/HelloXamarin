using System;

namespace HelloXamarin.Model
{
    public class Search
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public String CheckInOut {  get { return CheckIn.ToString("yyyy.MM.dd") + " - " + CheckOut.ToString("yyyy.MM.dd"); } }
    }
}
