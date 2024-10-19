using UnityEngine.UIElements;

namespace Assets.Project.Scripts.Views.Monobehaviours.UIToolKitUIViewModels.Base
{
    public interface IViewModel
    {
        UIDocument Document { get; }

        void Hide();
        void Init();
        void Show();
    }
}