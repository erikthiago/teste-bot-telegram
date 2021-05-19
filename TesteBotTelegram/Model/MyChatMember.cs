namespace TesteBotTelegram.Model
{ 
    public class MyChatMember
    {
        public Chat chat { get; set; }
        public From from { get; set; }
        public int date { get; set; }
        public OldChatMember old_chat_member { get; set; }
        public NewChatMember new_chat_member { get; set; }
    }
}