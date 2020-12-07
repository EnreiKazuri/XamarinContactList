using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinContactList.Models;
using XamarinContactList.ViewModels;

namespace XamarinContactList.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage(ObservableCollection<Person> people)
        {
            InitializeComponent();
            BindingContext = new RegisterViewModel(people);
        }
    }
}