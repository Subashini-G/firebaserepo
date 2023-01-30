using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Task3firebase
{
    public partial class MainPage : ContentPage
    {
        ViewModel.MainPageVM vm;
        public MainPage()
        {
            InitializeComponent();
            vm = new ViewModel.MainPageVM();
            BindingContext = vm;
        }
    }
}

