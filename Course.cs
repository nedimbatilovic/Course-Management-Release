using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Management_Release
{
    public class Course : INotifyPropertyChanged
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        public ObservabeCollection<Attendant> Attendants;

        public event PropertyChangedEventHandler? PropertyChanged;
        private void Change(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
