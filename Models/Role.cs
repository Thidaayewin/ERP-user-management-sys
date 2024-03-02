namespace ERP_user_management_sys.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<User> Users { get; set; }
        public List<RolePermission> RolePermissions { get; set; }
    }
}
