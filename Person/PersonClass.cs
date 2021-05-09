using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Person
{
    public class PersonClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string name;
        public string Name
        {
            get => name;
            set { name = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name")); }
        }
        private string surname;
        public string Surname
        {
            get => surname;
            set { surname = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Surname")); }
        }



        private DateTime date;
        public DateTime Date
        {
            get => date;
            set { date = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Date")); }
        }



        public static ObservableCollection<PersonClass> AllPeople { get; set; } = new ObservableCollection<PersonClass>();

        public static void InitPeople()
        {
            AllPeople.Add( new PersonClass
            {
                Name = "Martin",
                Surname = "Jína",
                Date = new DateTime(2003, 8, 22, 6, 15, 0),
              
            });
            AllPeople.Add(new PersonClass
            {
                Name = "Martin",
                Surname = "Král",
                Date = new DateTime(2002, 5, 7, 3, 30, 0),
               
            });
            AllPeople.Add(new PersonClass
            {
                Name = "Klára",
                Surname = "Nová",
                Date = new DateTime(1995, 8, 16, 14, 10, 0),
               
            });
            AllPeople.Add(new PersonClass
            {
                Name = "Ronald",
                Surname = "McDonald",
                Date = new DateTime(1963, 1, 5, 12, 0, 0),
               
            });
        }
    }
}
