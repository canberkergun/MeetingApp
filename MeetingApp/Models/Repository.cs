namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo { Id = 1, Name = "Canberk", Phone = "1234", Email = "canberk@info.com", WillAttend = true });
            _users.Add(new UserInfo { Id = 2, Name = "Can", Phone = "14", Email = "can@info.com", WillAttend = true });
            _users.Add(new UserInfo { Id = 3, Name = "Berk", Phone = "134", Email = "berk@info.com", WillAttend = true });
          
        }

        public static List<UserInfo> Users { get { return _users; } }

        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }

        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}
