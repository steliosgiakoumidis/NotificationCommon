namespace NotificationCommon.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string SMS { get; set; }
        public User() { }
        public User(int id, string username, string email, string Sms)
        {
            Id = id;
            Username = username;
            Email = email;
            SMS = Sms;
        }
    }
}
