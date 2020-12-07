using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinContactList.ViewModels;

namespace XamarinContactList.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PeoplePage : ContentPage
    {
        public PeoplePage()
        {
            InitializeComponent();
            BindingContext = new PeopleViewModel();
        }
    }
}