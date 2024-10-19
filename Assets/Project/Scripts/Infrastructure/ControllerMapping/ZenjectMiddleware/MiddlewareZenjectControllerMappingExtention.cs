using Assets.Project.Scripts.Infrastructure.SettingsProvider;
using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Assets.Project.Scripts.Infrastructure.ControllersMapping.ZenjectMiddleware
{
    public static class MiddlewareZenjectControllerMappingExtention
    {
        private const string NAMESPACE_DEFAULT = "Assets.Project.Scripts.Controllers";

        public static void AddZenjectMiddlewareControllerMapping(this DiContainer container, AppSettings settings)
        {
            ControllersMapper mapper = new ControllersMapper(@namespace: settings.ControllersNameSpace);

            IEnumerable<ControllerMapItmeInfo> map = mapper.CreateMap();

            foreach (var info in map)
            {
                ConcreteIdBinderNonGeneric scope = container.Bind(info.ControllerType);
                switch (info.InitialType)
                {
                    case LifeScopeEnum.Singlton:
                        scope.AsSingle();
                        break;
                    case LifeScopeEnum.Transient:
                        scope.AsTransient();
                        break;
                    default:
                        throw new Exception();
                }

                if (info.Lazy) scope.Lazy();
            }
        }
    }
}
