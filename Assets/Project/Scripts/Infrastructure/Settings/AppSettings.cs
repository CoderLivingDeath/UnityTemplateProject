using System;
using System.IO;
using UnityEngine;


namespace Assets.Project.Scripts.Infrastructure.SettingsProvider
{
    [Serializable]
    [CreateAssetMenu(fileName = "AppSettings", menuName = "Project/AppSettings", order = 1)]
    public class AppSettings : ScriptableObject
    {
        public string ControllersNameSpace;
    }
}
