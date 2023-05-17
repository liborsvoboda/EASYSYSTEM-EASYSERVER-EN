using System;

namespace GlobalNET.Classes {

    public partial class UserList {
        public int Id { get; set; } = 0;
        public int RoleId { get; set; }
        public string Username { get; set; } = null;
        public string Password { get; set; } = null;
        public string Name { get; set; } = null;
        public string Surname { get; set; } = null;
        public string Description { get; set; } = null;
        public bool Active { get; set; } = false;
        public DateTime? Timestamp { get; set; } = null;
        public string Token { get; set; } = null;
        public DateTime? Expiration { get; set; } = null;
        public byte[] Photo { get; set; } = null;
        public string MimeType { get; set; } = null;
        public string PhotoPath { get; set; } = "";

        public string Translation { get; set; } = null;
    }
}