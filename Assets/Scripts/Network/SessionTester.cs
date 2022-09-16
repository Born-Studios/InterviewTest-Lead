using Born.InterviewTest.Network.Messages;
using UnityEngine;

namespace Born.InterviewTest.Network
{
    public class SessionTester : MonoBehaviour
    {
        [Header("Session")]
        [SerializeField] private bool hasJoined;
        [SerializeField] private bool acceptJoinRequest;

        [Header("Player Data")]
        [SerializeField] private string playerName;
        [SerializeField] private bool updatePlayerName;
        [SerializeField] private int avatarId;
        [SerializeField] private bool updateAvatarId;
        [SerializeField] private bool sendDataUpdate;


        private ISessionInfoProvider sessionInfoProvider;
        private ITestMessageReceiver testMessageReceiver;
        
        private void Awake()
        {
            sessionInfoProvider = Runtime.App.Instance.SessionInfoProvider;
            testMessageReceiver = Runtime.App.Instance.TestMessageReceiver;
        }

        private void Update()
        {
            hasJoined = sessionInfoProvider.HasJoinedSession;

            if (acceptJoinRequest)
            {
                testMessageReceiver.ReceiveTestMessage(new JoinSessionResponse(true));
                acceptJoinRequest = false;
            }

            if (sendDataUpdate)
            {
                UpdateData updateData = new();
                
                // Construct UpdateData message.
                if (updatePlayerName)
                {
                    // Add player name update to UpdateData message.
                }
                if (updateAvatarId)
                {
                    // Add avatar id update to UpdateData message.
                }
                
                testMessageReceiver.ReceiveTestMessage(updateData);
                
                sendDataUpdate = false;
            }
        }
    }
}