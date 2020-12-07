using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using XamarinContactList.Models;
using XamarinContactList.Views;

namespace XamarinContactList.ViewModels
{
    class PeopleViewModel : BaseViewModel
    {
        public Person SelectedPerson
        {
            get { return selectedPerson; }
            set
            {
                if (value != null)
                {
                    selectedPerson = value;
                    //DisplayPerson(selectedPerson);
                }
            }
        }
        public PeopleViewModel()
        {
            People = new ObservableCollection<Person>();
            RegisterPageCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new RegisterPage(People));
            });
            DeletePersonCommand = new Command(() =>
            {
                People.Remove(People.Where(i => i.Name == selectedPerson.Name).Last());
            });
            MoreCommand = new Command(async () =>
            {
                var action = await App.Current.MainPage.DisplayActionSheet("", "Cancel", null, "Call " + selectedPerson.PhoneNumber, "Edit");
                if (action == $"Call {selectedPerson.PhoneNumber}")
                {
                    PhoneDialer.Open(selectedPerson.PhoneNumber);
                }
                else if (action == "Edit")
                {
                    var editAction = await App.Current.MainPage.DisplayPromptAsync("Change Number", "Introduce the new number");
                    var found = People.FirstOrDefault(i => i.PhoneNumber == selectedPerson.PhoneNumber);
                    int place = People.IndexOf(found);
                    People[place] = new Person(selectedPerson.Name, editAction);
                }
            });
        }
        public ICommand RegisterPageCommand { get; }
        public ICommand DeletePersonCommand { get; }
        public ICommand MoreCommand { get; }
        public ObservableCollection<Person> People { get; set; }
        private Person selectedPerson;
    }
}
