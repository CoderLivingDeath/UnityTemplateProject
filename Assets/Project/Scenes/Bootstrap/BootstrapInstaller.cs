using Assets.Project.Scripts.Services;
using System.Collections;
using UnityEngine;
using Zenject;

public class BootstrapInstaller : MonoInstaller
{
    [SerializeField] private int _sceneIndex = 0;

    [Inject]
    private SceneLoaderService _loader;

    public override void InstallBindings()
    {
    }

    private void BindServices()
    {
        //выши сервисы.
    }

    private new void Start()
    {
        //_loader.LoadAsync(_sceneIndex);
    }
}