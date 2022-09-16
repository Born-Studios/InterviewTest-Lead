using UnityEngine;
using UnityEngine.UI;

namespace Born.InterviewTest.Players
{
    [RequireComponent(typeof(Text))]
    public class PlayerNameView : MonoBehaviour
    {
        private Text nameText;
        
        private void Awake()
        {
            nameText = GetComponent<Text>();
            nameText.text = "";
        }
    }
}