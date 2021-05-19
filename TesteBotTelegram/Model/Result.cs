namespace TesteBotTelegram.Model
{ 
    public class Result
    {
        public int update_id { get; set; }
        public MyChatMember my_chat_member { get; set; }
        public MessageTelegram message { get; set; }
    }
}