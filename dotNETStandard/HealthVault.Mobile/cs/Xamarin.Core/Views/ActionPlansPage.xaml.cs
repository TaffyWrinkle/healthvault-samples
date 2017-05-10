﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HealthVault.Sample.Xamarin.Core.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActionPlansPage : ContentPage
    {
        public ActionPlansPage()
        {
            InitializeComponent();
        }

        private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            // Prevents a menu item from showing as "selected"
            ((ListView)sender).SelectedItem = null;
        }
    }
}
