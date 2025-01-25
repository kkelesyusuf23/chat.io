using System.Net.Mail;

namespace chat.io.Entities
{
    public class Message
    {
        public int MessageId { get; set; } // Birincil Anahtar
        public int ConversationId { get; set; } // Hangi Sohbete Ait
        public int SenderId { get; set; } // Gönderen Kullanıcı
        public string? Content { get; set; } // Mesaj İçeriği
        public DateTime SentAt { get; set; } = DateTime.UtcNow; // Gönderilme Tarihi

        // Navigation Properties
        public Conversation Conversation { get; set; } = null!;
        public User Sender { get; set; } = null!;
        public ICollection<Attachment> Attachments { get; set; } = new List<Attachment>();
    }
}
