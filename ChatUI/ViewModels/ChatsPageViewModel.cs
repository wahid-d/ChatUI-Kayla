using System;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using ChatUI.Models;

namespace ChatUI.ViewModels
{
    public class ChatsPageViewModel : BaseViewModel
    {
        public ChatsPageViewModel()
        {
            AddUsers();
        }

        private async Task AddUsers()
        {
            for (int i = 0; i < 10; i++)
            {
                var user = new User();
                Console.WriteLine(user.AvatarUrl);
                Users.Add(user);
                await Task.Delay(500);
            }

        }

        public ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>();
    }
}
