namespace ERP_user_management_sys.Models
{
    public class Feature
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Permission> Permissions { get; set; }
    }
}
