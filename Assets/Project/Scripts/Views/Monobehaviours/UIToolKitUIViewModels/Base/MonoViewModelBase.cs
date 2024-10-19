using Assets.Project.Scripts.Views.Monobehaviours.UIToolKitUIViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UIElements;

namespace Assets.Project.Scripts.Views.Monobehaviours.UIToolKitUIViewModels.Base
{
    public abstract class MonoViewModelBase : MonoBehaviour, IViewModel
    {
        [SerializeField] private UIDocument _document;
        public UIDocument Document => _document;

        public virtual void Hide()
        {
            Document.enabled = false;
        }

        public virtual void Init()
        {

        }

        public virtual void Show()
        {
            Document.enabled = true;
        }
    }
}
