using UnityEngine;
using UnityEngine.UI;

namespace Born.InterviewTest.Network
{
    [RequireComponent(typeof(Text))]
    public class SessionStatusTextView : MonoBehaviour
    {
        private ISessionInfoProvider sessionInfoProvider;
        private Text text;
        
        private void Awake()
        {
            sessionInfoProvider = Runtime.App.Instance.SessionInfoProvider;
            text = GetComponent<Text>();
        }

        private void Update()
        {
            text.text = sessionInfoProvider.HasJoinedSession ? "In session" : "Not in session";
        }
    }
}