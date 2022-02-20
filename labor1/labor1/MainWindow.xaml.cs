using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace labor1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   
    public partial class MainWindow : Window
    {
        private List<Person> people = new List<Person>();

        public MainWindow()
        {
            
            
            InitializeComponent();
            people.Add(new Person { FirstName = "John", LastName = "Doe" });
            people.Add(new Person { FirstName = "Joe", LastName = "Jack" });
            people.Add(new Person { FirstName = "Jack", LastName = "Daniels" });

            peopleComboBox.ItemsSource = people;

        
    }

    private void submitbtnclick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Your first name is:{firstNameTxtBx.Text} and your last name is:{lastNameTxtBx.Text}!");
        }

        /* private void submitButton_Click(object sender, RoutedEventArgs e)
         {
             MessageBox.Show($"Your first name is:{firstNameTxtBx.Text} and your last name is:{lastNameTxtBx.Text}!");
         }*/


    }
}
