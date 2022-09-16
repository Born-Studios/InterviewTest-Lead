namespace Born.InterviewTest.Network.Messages
{
    /// <summary>
    /// Message that session server sends as a response to <see cref="JoinSessionRequest"/>.
    /// </summary>
    public class JoinSessionResponse : Message
    {
        public readonly bool Joined;

        public JoinSessionResponse(bool joined)
        {
            Joined = joined;
        }
    }
}