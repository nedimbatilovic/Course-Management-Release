using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Management_Release
{
    public class Attendant : INotifyPropertyChanged
    {

        private string _id;
        public string Id
        {
            get => _id;
            set
            {
                _id = value;
                Change("Id");
            }
        }

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                Change("Name");
            }
        }

        private string _surname;
        public string Surname
        {
            get => _surname;    
            set
            {
                _surname = value;
            }
        }
        private int _age;
        public int Age
        {
            get => _age;
            set
            {
                _age = value;
                Change("Age");
            }
        }

        // finish later
        private bool _hasPaid;
        public bool HasPaid
        {
            get => _hasPaid;
            set
            {
                _hasPaid = value;
                Change("HasPaid");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void Change(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
