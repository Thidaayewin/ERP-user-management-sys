namespace ERP_user_management_sys.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public int RoleId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public bool Gender { get; set; }
        public bool IsActive { get; set; }
        public Role Role { get; set; }
    }
}
