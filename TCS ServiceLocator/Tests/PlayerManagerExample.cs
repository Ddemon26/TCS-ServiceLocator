using UnityEngine;
namespace TCS.ServiceLocator.Tests {
    internal interface IPlayerManager {
        void SpawnPlayer();
    }
    internal class PlayerManagerExample : IPlayerManager {
        public void SpawnPlayer() {
            Debug.Log("Player spawned.");
            // Add player spawn logic here
        }
    }
}