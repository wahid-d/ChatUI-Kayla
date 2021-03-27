
using ChatUI.Models;
using Xamarin.Forms;

namespace ChatUI.Views
{
    public partial class ChatRoom : ContentPage
    {
        public User User { get; set; }

        public ChatRoom()
        {
            InitializeComponent();


        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            BindingContext = this.User;
        }
    }
}
