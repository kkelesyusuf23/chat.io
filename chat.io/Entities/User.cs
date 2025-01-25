namespace chat.io.Entities
{
    public class User
    {
        public int UserId { get; set; } // Birincil Anahtar
        public string Username { get; set; } = null!; // Kullanıcı Adı
        public string Email { get; set; } = null!; // E-posta
        public string PasswordHash { get; set; } = null!; // Şifre (Hashlenmiş)
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Oluşturulma Tarihi

        // Navigation Properties
        public ICollection<UserConversation> UserConversations { get; set; } = new List<UserConversation>();
        public ICollection<Message> SentMessages { get; set; } = new List<Message>();
    }
}
