namespace chat.io.Entities
{
    public class UserConversation
    {
        public int UserConversationId { get; set; } // Birincil Anahtar
        public int ConversationId { get; set; } // Sohbet ID
        public int UserId { get; set; } // Kullanıcı ID
        public bool IsAdmin { get; set; } = false; // Yönetici mi?
        public DateTime JoinedAt { get; set; } = DateTime.UtcNow; // Katılma Tarihi

        // Navigation Properties
        public Conversation Conversation { get; set; } = null!;
        public User User { get; set; } = null!;
    }
}
