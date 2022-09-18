using Born.InterviewTest.Network;
using System;
using UnityEngine;

namespace Born.InterviewTest.Players
{
    /// <summary>
    /// Represents the player in the scene. Responsible for instantiating the player avatar.
    /// </summary>
    public class Player : MonoBehaviour
    {
        [SerializeField] private Transform avatarRoot;
        [SerializeField] private GameObject[] avatarPrefabs;
        private IPlayerInfoProvider playerInfoProvider;
        private GameObject avatarInstance;

        private void Awake()
        {
            playerInfoProvider = Runtime.App.Instance.PlayerInfoProvider;
            playerInfoProvider.OnUpdateAvatar += UpdateAvatar;
        }

        private void UpdateAvatar()
        {
            GameObject newAatarPrefab = null;
            foreach(GameObject avatarPrefab in avatarPrefabs)
            {
                if(avatarPrefab.name.EndsWith(playerInfoProvider.AvatarId.ToString()))
                {
                    newAatarPrefab = avatarPrefab;
                    break;
                }
            }
            if (newAatarPrefab != null)
            {
                if (avatarInstance != null) Destroy(avatarInstance);
                avatarInstance = Instantiate(newAatarPrefab, avatarRoot);
            }
        }

        private void OnDestroy()
        {
            playerInfoProvider.OnUpdateAvatar -= UpdateAvatar;
        }
    }
}