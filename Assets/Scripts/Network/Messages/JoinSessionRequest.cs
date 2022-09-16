namespace Born.InterviewTest.Network.Messages
{
    /// <summary>
    /// Message that the app sends to the session server to join a session.
    /// </summary>
    public class JoinSessionRequest : Message
    {
        public readonly string UserName;

        public readonly string Password;

        public JoinSessionRequest(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
    }
}