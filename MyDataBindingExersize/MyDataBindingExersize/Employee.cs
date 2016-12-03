using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyDataBindingExersize
{
    public class Employee : INotifyPropertyChanged
    {
        private string firstname;
        public string firstName
        {
            get { return firstname; }
            set
            {
                firstname = value;
                OnPropertyChanged();
            }
        }

        private string lastname;
        public string lastName
        {
            get { return lastname; }
            set 
            {
                lastname = value;
                OnPropertyChanged();
}
        }
        public static Employee GetEmployee()
        {
            var emp = new Employee()
            {
                firstName = "Stefan",
                lastName = " Bursac"
            };
            return emp;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(
            [CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }

        }
    }
}

