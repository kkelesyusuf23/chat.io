namespace chat.io.Entities
{
    public class Conversation
    {
        public int ConversationId { get; set; } // Birincil Anahtar
        public string? Title { get; set; } // Grup Başlığı
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Oluşturulma Tarihi

        // Navigation Properties
        public ICollection<UserConversation> UserConversations { get; set; } = new List<UserConversation>();
        public ICollection<Message> Messages { get; set; } = new List<Message>();
    }
}
