using UnityEngine;

namespace Born.InterviewTest.Runtime
{
    /// <summary>
    /// Provides an entry point for the application.
    /// This script's execution order is set to be before other scripts.
    /// Instantiates the <see cref="App"/> instance.
    /// </summary>
    [DefaultExecutionOrder(-5000)]
    public class AppEntry : MonoBehaviour
    {
        private Runtime.App app;
        
        private void Awake()
        {
            app = new Runtime.App();
            
            DontDestroyOnLoad(this);
        }
    }
}
