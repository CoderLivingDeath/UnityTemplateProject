using Assets.Project.Scripts.Infrastructure.ControllersMapping.ZenjectMiddleware;
using Assets.Project.Scripts.Infrastructure.EventBuss;
using Assets.Project.Scripts.Infrastructure.SettingsProvider;
using Assets.Project.Scripts.Services;
using UnityEngine;
using Zenject;

public class ProjectContextInstaller : MonoInstaller
{
    [SerializeField] private AppSettings _settings;
    public override void InstallBindings()
    {
        Container.BindInterfacesAndSelfTo<EventBus>().AsSingle();
        BindServices();
        BindMiddlewares();
    }

    private void BindServices()
    {
        Container.Bind<SceneLoaderService>().AsSingle();
    }

    private void BindMiddlewares()
    {
        Container.AddZenjectMiddlewareControllerMapping(_settings);
    }
}