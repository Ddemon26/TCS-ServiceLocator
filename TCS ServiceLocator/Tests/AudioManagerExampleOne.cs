using UnityEngine;
namespace TCS.ServiceLocator.Tests {
    internal interface IAudioManager {
        void PlayMusic(string trackName);
        void StopMusic();
    }

    internal class AudioManagerExampleOne : IAudioManager {
        public void PlayMusic(string trackName) {
            Debug.Log($"Playing music: {trackName} using AudioManagerExampleOne");
            // Add your audio logic here.
        }

        public void StopMusic() {
            Debug.Log("Stopping music");
            // Add your audio logic here.
        }
    }
    
    internal class AudioManagerExampleTwo : IAudioManager {
        public void PlayMusic(string trackName) {
            Debug.Log($"Playing music: {trackName} using AudioManagerExampleTwo");
            // Add your audio logic here.
        }

        public void StopMusic() {
            Debug.Log("Stopping music");
            // Add your audio logic here.
        }
    }
}