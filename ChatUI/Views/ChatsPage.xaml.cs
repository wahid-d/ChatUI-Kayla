using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ChatUI.Models;
using Xamarin.Forms;

namespace ChatUI.Views
{
    public partial class ChatsPage : ContentPage
    {
        public ChatsPage()
        {
            InitializeComponent();
        }

        async void CollectionView_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            var user = e.CurrentSelection[0] as User;
            await Shell.Current.GoToAsync("//chatroom"); ;
        }
    }
}
