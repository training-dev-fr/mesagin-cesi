namespace sendme.Models
{
    public class MessageModel
    {
        public string? Content { get; set; }
        public int? userId { get; set; }
        public DateTime? createdAt { get; set; }

        public MessageModel(string? content, int? userId, DateTime? createdAt)
        {
            Content = content;
            this.userId = userId;
            this.createdAt = DateTime.Now;
        }
    }
}
