using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace UserApp.Model
{

    public class User : INotifyPropertyChanged
    {
        private string name;
        private string age;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"
               ));
                //OnPropertyChanged("Name");
            }
        }
        public string Age
        {
            get { return age; }
            set
            {
                age = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Age"));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        //protected virtual void OnPropertyChanged(string propertyName)
        //{
        // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property
       // Name));
 //}
 }
}
