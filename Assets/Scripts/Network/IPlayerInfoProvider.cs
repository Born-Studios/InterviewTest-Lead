using System;

namespace Born.InterviewTest.Network
{
    public interface IPlayerInfoProvider
    {
        string PlayerName { get; }
        int AvatarId { get; }
        event Action OnUpdateName;
        event Action OnUpdateAvatar;
    }
}