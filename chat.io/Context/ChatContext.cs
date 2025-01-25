using chat.io.Entities;
using Microsoft.EntityFrameworkCore;

namespace chat.io.Context
{
    public class ChatContext:DbContext
    {
        public ChatContext(DbContextOptions<ChatContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Conversation> Conversations { get; set; } = null!;
        public DbSet<UserConversation> UserConversations { get; set; } = null!;
        public DbSet<Message> Messages { get; set; } = null!;
        public DbSet<Attachment> Attachments { get; set; } = null!;
    }
}
