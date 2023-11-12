using Praktika.Command;
using Praktika.Models;
using Praktika.Pages;
using Praktika.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace Praktika.ViewModels.PageViewModels
{
    public class FirstPageModel:NotificationService
    {
        public ObservableCollection<Root?> users;
        public ObservableCollection<Root?> Users { get => users; set { users = value; OnPropertyChanged(); } }

        public ICommand ShowCommand { get ; set; }
        public ICommand BackCommand { get ; set; }
        public ICommand AddCommand { get ; set; }

        
        public FirstPageModel()
        {
            var txt = File.ReadAllText("../../../DataBase/Users.json");

            var usr = JsonSerializer.Deserialize<ObservableCollection<Root>>(txt);
            Users= usr;
            ShowCommand = new RelayCommand(show);
            BackCommand = new RelayCommand(back);
            AddCommand = new RelayCommand(add);
            
        }

        public void show(object? parameter)
        {
            Page? window = parameter as Page;
            if (window != null)
            {
                window.NavigationService.Navigate(new ShowPage());
            }
        }

        public void add(object? parameter)
        {
            Page? window = parameter as Page;
            if (window != null)
            {
                window.NavigationService.Navigate(new AddPage());
            }
        }

        public void back(object? parameter)
        {
            Page? window = parameter as Page;
            if (window != null)
            {
                window.NavigationService.GoBack();
            }
        }




        public void SaveUsersToJson()
        {
            var json = JsonSerializer.Serialize(Users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("../../../DataBase/Users.json", json);
        }


    }
}
