using Microsoft.Practices.Unity;

namespace ZwabyBeta.Extensions
{
    public static class UnityContainerExtensions
    {
        public static void RegisterSingleton<TInterface, TImplementation>(this IUnityContainer unityContainer)
            where TImplementation : TInterface
        {
            unityContainer.RegisterType<TInterface, TImplementation>(new ContainerControlledLifetimeManager());
        }
    }
}
