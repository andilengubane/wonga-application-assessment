namespace WongaApplication.Domain.Entities
{
    public class UserEntitiy
    {
        public Guid Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public DateTime DateLogged { get; set; } = DateTime.Now;
    }
}
