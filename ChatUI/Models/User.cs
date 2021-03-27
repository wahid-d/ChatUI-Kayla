using System;
using System.Linq;

namespace ChatUI.Models
{
    public class User
    {
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime LastSeen { get; set; }
        public string AvatarUrl { get; set; }

        public User()
        {
            var random = new Random();

            ID = Guid.NewGuid();
            FirstName = getRandomString(random.Next(5, 13));
            LastName = getRandomString(random.Next(5, 13));
            LastSeen = DateTime.Now.AddSeconds(random.Next(0, 1000000) * -1);
            AvatarUrl = $"https://i.pravatar.cc/500?img={random.Next(1, 70)}";
        }

        private string getRandomString(int length)
        {
            var random = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower();
            string randomString = new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());

            return randomString;
        }
    }
}
