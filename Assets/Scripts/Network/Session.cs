using Born.InterviewTest.Network.Messages;

namespace Born.InterviewTest.Network
{
    /// <summary>
    /// Represents the network session. 
    /// </summary>
    /// <remarks>
    /// A connection to the session will be established as soon a Session object is created.
    /// </remarks>
    public class Session : ISessionInfoProvider, ITestMessageReceiver
    {
        private const string Username = "Test-Player";
        private const string Password = "Not-A-Secret";

        private readonly Connection connection;
        private readonly PlayerData playerData;

        public Session(PlayerData playerData)
        {
            connection = new Connection();
            connection.MessageReceived += OnMessageReceived;
            connection.Opened += OnConnectionOpened;
            connection.Open();

            this.playerData = playerData;
        }

        public bool HasJoinedSession { get; private set; }

        public void ReceiveTestMessage(Message message)
        {
            OnMessageReceived(message);
        }

        private void OnConnectionOpened()
        {
            connection.Send(new JoinSessionRequest(Username, Password));
        }

        private void OnMessageReceived(Message message)
        {
            switch (message)
            {
                case JoinSessionResponse joinSessionResponse:
                    HasJoinedSession = joinSessionResponse.Joined;
                    break;
                
                case UpdateData updateData:
                    // Process message to update the local data elements that are being updated by the message. 
                    playerData.UpdatePlayerName(updateData.PlayerName);
                    playerData.UpdateAvatarId(updateData.AvatarId);
                    break;
            }
        }
    }
}