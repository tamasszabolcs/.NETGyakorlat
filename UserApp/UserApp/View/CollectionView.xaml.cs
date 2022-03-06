using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UserApp.ViewModel;

namespace UserApp.View
{
    /// <summary>
    /// Interaction logic for CollectionView.xaml
    /// </summary>
    public partial class CollectionView : UserControl
    {
        CollectionViewModel viewModel = new CollectionViewModel();
        public CollectionView()
        {
            InitializeComponent();
            DataContext = viewModel;
        }

        private void btnAddNewUser_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Users.Add(new Model.User() { Name = txtUserName.Text, Age = txtUserAge.Text });
            txtUserName.Text = string.Empty;
            txtUserAge.Text = string.Empty;

        }
    }
}
