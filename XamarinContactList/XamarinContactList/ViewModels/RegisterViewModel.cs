using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinContactList.Models;

namespace XamarinContactList.ViewModels
{
    class RegisterViewModel : BaseViewModel
    {
        public RegisterViewModel(ObservableCollection<Person> people)
        {
            People = people;
            AddPersonCommand = new Command(() =>
            {
                if (People.Count != 0)
                {
                    if (!People.Contains(People.FirstOrDefault(i => i.Name == Name)))
                    {
                        People.Add(new Person(Name, PhoneNumber));
                    }
                    else { App.Current.MainPage.DisplayAlert("Error", "Este nombre ya existe", "Cancel"); }
                }
                else { People.Add(new Person(Name, PhoneNumber)); }
            });
        }
        public ObservableCollection<Person> People { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public ICommand AddPersonCommand { get; }
    }
}
