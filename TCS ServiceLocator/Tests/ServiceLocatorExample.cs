using UnityEngine;
using static TCS.ServiceLocator.ServiceLocator;
namespace TCS.ServiceLocator.Tests {
    public class ServiceLocatorExample : MonoBehaviour {
        IAudioManager m_audioManager;
        IScoreManager m_scoreManager;

        void Start() {
            // Get the global ServiceLocator instance
            var serviceLocator = Global;

            // Retrieve the services
            m_audioManager = serviceLocator.Get<IAudioManager>();
            m_scoreManager = serviceLocator.Get<IScoreManager>();

            // Use the services
            PlayGameMusic();
            ResetScore();
        }

        void PlayGameMusic() {
            m_audioManager.PlayMusic("GameMusic");
        }

        void ResetScore() {
            m_scoreManager.Reset();
            m_scoreManager.AddPoints(100);
            m_scoreManager.AddPoints(200);
            int score = m_scoreManager.GetScore();
            Debug.Log($"Score: {score}");
        }
    }
}