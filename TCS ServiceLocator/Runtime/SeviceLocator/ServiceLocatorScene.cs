using UnityEngine;

namespace TCS.ServiceLocator {
    [AddComponentMenu("ServiceLocator/ServiceLocator Scene")]
    public class ServiceLocatorScene : ServiceBootstrapper {
        protected override void Bootstrap() => Container.ConfigureForScene();
    }
}