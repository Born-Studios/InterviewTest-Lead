using System;

namespace Born.InterviewTest.Network.Messages
{
    /// <summary>
    /// Base type for messages exchanged between a session server and the apps.
    /// </summary>
    public abstract class Message
    {
        /// <summary>
        /// Timestamp of when this message is created.
        /// </summary>
        public DateTime CreatedAt { get; private set; } = DateTime.Now;
    }
}