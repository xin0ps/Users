using Praktika.Models;
using Praktika.ViewModels.PageViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace Praktika.Pages
{
    /// <summary>
    /// Interaction logic for AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        public AddPage()
        {
            InitializeComponent();
            DataContext = new FirstPageModel();
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            FirstPageModel viewModel = DataContext as FirstPageModel;
           
            
            Root user = new Root();
            if(name.Text.Length > 0)
            {
                user.name= name.Text;
            }
            if(username.Text.Length > 0)
            {
                user.username= username.Text;
            }

            if(email.Text.Length > 0)
            {
                user.email= email.Text;
            }
            if(street.Text.Length > 0)
            {
                user.address.street=street.Text;
            }
            if(city.Text.Length > 0)
            {
                user.address.city= city.Text;
            }
            if(website.Text.Length > 0)
            {
                user.website= website.Text;
            }
            if(company.Text.Length > 0)
            {
                user.company.name= company.Text;
            }
            if(bs.Text.Length > 0)
            {
                user.company.bs= bs.Text;
            }
            viewModel.Users.Add(user);
            viewModel.SaveUsersToJson();

        }
    }
}
