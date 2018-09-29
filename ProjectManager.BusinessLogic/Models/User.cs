namespace ProjectManager.BusinessLogic.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public Permission PermissionId { get; set; }
        public string Email { get; set; }
    }
}
