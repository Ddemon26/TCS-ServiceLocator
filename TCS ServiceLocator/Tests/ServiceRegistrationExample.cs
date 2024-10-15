using UnityEngine;
namespace TCS.ServiceLocator.Tests {
    [DefaultExecutionOrder(-1000)]
    public class ServiceRegistrationExample : MonoBehaviour {
        void Awake() {
            // Get the global ServiceLocator instance
            var serviceLocator = ServiceLocator.Global;
        
            // Register all the necessary services here
            serviceLocator
                .Register<IAudioManager>(new AudioManagerExampleOne()) // Register AudioManagerOne
                //.Register<IAudioManager>(new AudioManagerExampleTwo()) // Register AudioManagerTwo
                .Register<IScoreManager>(new ScoreManagerExample())
                .Register<IPlayerManager>(new PlayerManagerExample());
        
            Debug.Log("Services registered with the ServiceLocator.");
        }
    }
}