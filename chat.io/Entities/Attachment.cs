namespace chat.io.Entities
{
    public class Attachment
    {
        public int AttachmentId { get; set; } // Birincil Anahtar
        public int MessageId { get; set; } // Hangi Mesaja Ait
        public string FilePath { get; set; } = null!; // Dosya Yolu
        public string FileType { get; set; } = null!; // Dosya Türü
        public DateTime UploadedAt { get; set; } = DateTime.UtcNow; // Yüklenme Tarihi

        // Navigation Properties
        public Message Message { get; set; } = null!;
    }
}
