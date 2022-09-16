using Born.InterviewTest.Network.Messages;
using System;
using System.IO;
using System.Threading;
using UnityEngine;

namespace Born.InterviewTest.Network
{
    /// <summary>
    /// 
    /// </summary>
    public class Connection : IDisposable
    {
        /// <summary>
        /// Creates a new Connection object.
        /// The created Connection object will be in an unconnected state.
        /// </summary>
        public Connection()
        {
        }

        /// <summary>
        /// Invoked when this connection is closed.
        /// </summary>
        public event Action Opened;
        
        /// <summary>
        /// Invoked when a message is received on this connection.
        /// </summary>
        public event Action<Message> MessageReceived;

        /// <summary>
        /// Invoked when this connection is closed.
        /// </summary>
        public event Action Closed;

        /// <summary>
        /// Returns whether this connection is currently open.
        /// </summary>
        public bool IsOpen { get; private set; }

        /// <summary>
        /// Will try to to open the connection to the remote endpoint synchronously.
        /// </summary>
        public void Open()
        {
            IsOpen = true;
        
            OnConnected();
        }

        /// <summary>
        /// Closes and disposes the connection. 
        /// </summary>
        public void Close() => Dispose();

        /// <summary>
        /// Closes and disposes the connection.
        /// </summary>
        public void Dispose()
        {
            if (IsOpen)
            {
                IsOpen = false;
                Closed?.Invoke();
            }
        }

        /// <summary>
        /// Sends a message over this connection.
        /// </summary>
        /// <param name="message"><see cref="Message"/> to send.</param>
        public void Send(Message message)
        {
            // For the purpose of this exercise, assume the message is serialized and sent.
        }

        private void OnConnected()
        {
            Opened?.Invoke();
            
            StartReception();
        }

        private void StartReception()
        {
            // Assume that this starts running ReceiveMessage as a background task that runs in Unity's main thread.
        }

        private void ReceiveMessage(CancellationToken cancellationToken)
        {
            while (cancellationToken.IsCancellationRequested == false)
            {
                try
                {
                    Message message = null;
                
                    // Assume that deserialization from an incoming stream will take place here.
                
                    if (message != null)
                    {
                        MessageReceived?.Invoke(message);
                    }
                }
                catch (IOException)
                {
                    // Connection must have been terminated.
                    Close();
                }
                catch (Exception e)
                {
                    Debug.LogException(e);
                }
            }

            cancellationToken.ThrowIfCancellationRequested();
        }
    }
}
