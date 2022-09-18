namespace Born.InterviewTest.Network.Messages
{
    public class UpdateData : Message
    {
        public readonly string PlayerName;

        public readonly int AvatarId;

        public UpdateData(string playerName = null, int avatarId = -1)
        {
            PlayerName = playerName;
            AvatarId = avatarId;
        }
    }
}