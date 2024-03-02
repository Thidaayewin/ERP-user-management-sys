namespace ERP_user_management_sys.Models
{
    public class Permission
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FeatureId { get; set; }

        public Feature Feature { get; set; }
        public List<RolePermission> RolePermissions { get; set; }
    }
}
