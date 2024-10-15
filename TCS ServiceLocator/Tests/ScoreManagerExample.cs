using UnityEngine;
namespace TCS.ServiceLocator.Tests {
    internal interface IScoreManager {
        void Reset();
        void AddPoints(int points);
        int GetScore();
    }

    internal class ScoreManagerExample : IScoreManager {
        int m_score;

        public void Reset() {
            m_score = 0;
            Debug.Log("Score has been reset.");
        }

        public void AddPoints(int points) {
            m_score += points;
            Debug.Log($"Added {points} points. Total score: {m_score}");
        }

        public int GetScore() {
            return m_score;
        }
    }
}