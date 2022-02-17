using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BindingTest.Lib
{
    public class Person : INotifyPropertyChanged
    {
        private int _id;
        public int Id
        {
            get => _id;
            set
            {
                if (_id == value) return;
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        private string _first;
        public string FirstName
        {
            get => _first;
            set
            {
                if (_first == value) return;
                _first = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        private string _last;
        public string LastName
        {
            get => _last;
            set
            {
                if (_last == value) return;
                _last = value;
                OnPropertyChanged(nameof(LastName));
            }
        }

        private DateTime _date;
        public DateTime DateOfBirth
        {
            get => _date;
            set
            {
                if (_date == value) return;
                _date = value;
                OnPropertyChanged(nameof(DateOfBirth));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}