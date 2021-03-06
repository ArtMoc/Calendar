using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace Calendar
{
    class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        void Notify(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        string _name;
        long _tel;
        DateTime _bday;
        Person _person = new Person("", 0, DateTime.Now);


        public ICommand OkCommand
        {
            get
            {
                return new ButtonCommand(new Action(() =>

                {
                    MessageBox.Show(_person.Name);
                }
            ));
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                _person = new Person(Name, Tel, Bday);
                Notify("Name");
            }
        }
        public long Tel
        {
            get { return _tel; }
            set
            {
                _tel = value;
                _person = new Person(Name, Tel, Bday);
                Notify("Tel");
            }
        }
        public DateTime Bday
        {
            get { return _bday; }
            set
            {
                _bday = value;
                _person = new Person(Name, Tel, Bday);
                Notify("Bday");
            }
        }
    }
}
