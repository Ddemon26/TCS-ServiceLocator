using UnityEngine;
namespace TCS.ServiceLocator {
    [AddComponentMenu("ServiceLocator/ServiceLocator Global")]
    public class ServiceLocatorGlobal : ServiceBootstrapper {
        [SerializeField] bool m_dontDestroyOnLoad = true;
        
        protected override void Bootstrap() => Container.ConfigureAsGlobal(m_dontDestroyOnLoad);
    }
}