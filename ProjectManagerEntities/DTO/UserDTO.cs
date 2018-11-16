﻿namespace ProjectManager.Entities.DTO
{
    public class UserDTO
    {
        public int UserId { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public PermissionDTO PermissionId { get; set; }
        public string Email { get; set; }
    }
}
