using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace Assets.Project.Scripts.Services
{
    public class SceneLoaderService
    {
        private ZenjectSceneLoader _sceneLoader;

        public SceneLoaderService(ZenjectSceneLoader sceneLoader)
        {
            _sceneLoader = sceneLoader;
        }

        public AsyncOperation LoadAsync(int sceneIndex, LoadSceneMode mode = LoadSceneMode.Single)
        {
            return _sceneLoader.LoadSceneAsync(sceneIndex, mode);
        }

        public AsyncOperation LoadAndAwait(int sceneIndex, LoadSceneMode mode = LoadSceneMode.Single)
        {
            var operation = _sceneLoader.LoadSceneAsync(sceneIndex, mode);
            operation.allowSceneActivation = false;

            return operation;
        }
    }
}
