using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.UIElements;

namespace Assets.Project.Scripts.Views.Monobehaviours.UIToolKitUIViewModels.Base
{
    public abstract class ViewModelBase : IViewModel
    {
        public abstract UIDocument Document { get; }

        public abstract void Init();
        public abstract void Show();
        public abstract void Hide();
    }
}
