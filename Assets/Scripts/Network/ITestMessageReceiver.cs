using Born.InterviewTest.Network.Messages;

namespace Born.InterviewTest.Network
{
    public interface ITestMessageReceiver
    {
        void ReceiveTestMessage(Message message);
    }
}