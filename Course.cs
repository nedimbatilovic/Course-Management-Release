using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Management_Release
{
    // public ObservableCollection<Attendant> CourseAttendants { get; set; }
    // ne znam zasto ovo funkcionisse samo van klase pitaj profesora
    public class Course : INotifyPropertyChanged
    {
        private int _id;
        public int Id
        {
            get => _id;
            set
            {
                _id = value;
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

        private DateTime _durationStart;
        public DateTime DurationStart
        {
            get => _durationStart;
            set
            {
                _durationStart = value;
                Change("Duration");
            }
        }

        private DateTime _durationEnd;
        public DateTime DurationEnd
        {
            get => _durationEnd;
            set
            {
                _durationEnd = value;
            }
        }

        public ObservableCollection<Attendant> CourseAttendants { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void Change(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
