using Assets.Project.Scripts.Views.Monobehaviours.UIToolKitUIViewModels.Base;
using UniRx;
using UnityEngine;
using UnityEngine.UIElements;
namespace Assets.Project.Scripts.Views.Monobehaviours.UIToolKitUIViewModels
{
    public class AchivmentsViewModel : MonoViewModelBase
    {
        private Button _counterBtn;

        public ReactiveProperty<int> CountProperty = new ReactiveProperty<int>();

        private void Start()
        {
            _counterBtn = Document.rootVisualElement.Q<Button>("CounterBtn");
            _counterBtn.clicked += _counterBtn_clicked;

            CountProperty.Subscribe(x =>
            {
                Debug.Log($"Кажется счетчик поменялся, его значение: {CountProperty.Value}");
            });
        }

        private void _counterBtn_clicked()
        {
            CountProperty.Value += 1;
            _counterBtn.text = $"Click me : {CountProperty.Value}";
        }
    }
}
