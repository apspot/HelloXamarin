using SQLite;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HelloXamarin.Model
{
    public class Contact : INotifyPropertyChanged
    {
        //for ContactBook excercise:
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                SetValue(ref _firstName, value);
                OnPropertyChanged(nameof(FullName));
            }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                SetValue(ref _lastName, value);
                OnPropertyChanged(nameof(FullName));
            }
        }

        public string FullName { get { return $"{FirstName} {LastName}"; } }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool IsBlocked { get; set; }     

        //for other pages:
        public string Name { get; set; }
        public string Status { get; set; }
        public string ImageUrl { get; set; }

        //handling property changed:
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected void SetValue<T>(ref T backingField, T value, [CallerMemberName] string propertyName = null)
        { //ref is needed for value types
            if (EqualityComparer<T>.Default.Equals(backingField, value)) //if we use == we get error: unable to compare T & T
                return;
            backingField = value;
            OnPropertyChanged(propertyName);
        }
    }
}
