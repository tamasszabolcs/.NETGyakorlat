using System;
using System.Collections.Generic;
using System.Text;
using UserApp.Model;
using System.Collections.ObjectModel;

namespace UserApp.ViewModel
{
    public class CollectionViewModel
    {
       
        public ObservableCollection<User> Users { get; set; }
        public CollectionViewModel()
        {
            Users = new ObservableCollection<User>();
            Users.Add(new User() { Name = "Administrator", Age = "25" });
            Users.Add(new User() { Name = "root", Age = "33" });
            Users.Add(new User() { Name = "Blackhawk", Age = "18" });
            Users.Add(new User() { Name = "User001", Age = "20" });
            Users.Add(new User() { Name = "Cortana", Age ="3" });
        }
    }

}
