using UnityEngine;

namespace Born.InterviewTest.Players
{
    /// <summary>
    /// Represents the player in the scene. Responsible for instantiating the player avatar.
    /// </summary>
    public class Player : MonoBehaviour
    {
        [SerializeField] private Transform avatarRoot;
    }
}