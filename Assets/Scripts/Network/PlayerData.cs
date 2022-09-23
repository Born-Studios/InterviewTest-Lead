using System;

namespace Born.InterviewTest.Network
{
    /// <summary>
    /// Represents the player data. 
    /// </summary>
    public class PlayerData : IPlayerInfoProvider
    {
        public string PlayerName { get; private set; }

        public int AvatarId { get; private set; }

        public event Action OnUpdateName;

        public event Action OnUpdateAvatar;

        /// <summary>
        /// Update the player name. This invokes the OnUpdateName event.
        /// </summary>
        public void UpdatePlayerName(string playerName)
        {
            if (playerName != null)
            {
                PlayerName = playerName;
                OnUpdateName?.Invoke();
            }
        }

        /// <summary>
        /// Update the player avatar ID. This invokes the OnUpdateAvatar event.
        /// </summary>
        public void UpdateAvatarId(int avatarId)
        {
            if (avatarId >= 0 && avatarId != AvatarId)
            {
                AvatarId = avatarId;
                OnUpdateAvatar?.Invoke();
            }
        }
    }
}
