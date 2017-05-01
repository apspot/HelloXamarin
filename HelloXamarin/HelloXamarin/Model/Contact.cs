using SQLite;

namespace HelloXamarin.Model
{
    public class Contact
    {
        //for ContactBook excercise:
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool IsBlocked { get; set; }

        //for other pages:
        public string Name { get; set; }
        public string Status { get; set; }
        public string ImageUrl { get; set; }
    }
}
