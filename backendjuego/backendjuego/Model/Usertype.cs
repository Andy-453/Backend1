namespace backendjuego.Model
{
    public class Usertype
    {
        public int UserTipeId { get; set; }
        public string TypeName { get; set; }

        public ICollection<Users> Users { get; set; }
        
    }
}
