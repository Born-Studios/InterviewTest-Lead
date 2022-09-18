using Born.InterviewTest.Network;
using UnityEngine;
using UnityEngine.UI;

namespace Born.InterviewTest.Players
{
    /// <summary>
    /// Represents the player name in the scene. Responsible for displaying the player name on the UI canvas.
    /// </summary>
    [RequireComponent(typeof(Text))]
    public class PlayerNameView : MonoBehaviour
    {
        private IPlayerInfoProvider playerInfoProvider;
        private Text nameText;
        
        private void Awake()
        {
            playerInfoProvider = Runtime.App.Instance.PlayerInfoProvider;
            nameText = GetComponent<Text>();
            nameText.text = "";

            playerInfoProvider.OnUpdateName += UpdateName;
        }

        private void UpdateName()
        {
            nameText.text = playerInfoProvider.PlayerName ?? "";
        }

        private void OnDestroy()
        {
            playerInfoProvider.OnUpdateName -= UpdateName;
        }
    }
}