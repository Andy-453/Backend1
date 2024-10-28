namespace backendjuego.Model
{
    public class Users
    {
        public int UserId { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsDeleted { get; set; }

        public int UserTypeId { get; set; }
        public  Usertype Usertype { get; set; }
        public object UserType { get; internal set; }
    }
}