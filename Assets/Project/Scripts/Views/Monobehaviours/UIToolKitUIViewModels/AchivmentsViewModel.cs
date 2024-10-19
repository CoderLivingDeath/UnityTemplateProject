using Assets.Project.Scripts.Infrastructure.EventBus.EventHandlers;
using Assets.Project.Scripts.Infrastructure.EventBuss;
using Assets.Project.Scripts.Views.Monobehaviours.UIToolKitUIViewModels.Base;
using UniRx;
using UnityEngine;
using UnityEngine.UIElements;
using Zenject;
namespace Assets.Project.Scripts.Views.Monobehaviours.UIToolKitUIViewModels
{
    public class AchivmentsViewModel : MonoViewModelBase, ITenClickedAchivmentEventHandler
    {
        public ReactiveProperty<int> CountProperty = new ReactiveProperty<int>();

        private Button _counterBtn;

        private IEventBus _eventBus;

        private CompositeDisposable _compositeDisposable = new();

        [Inject]
        private void Construct(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        private void Start()
        {
            _eventBus.Subscribe(this);

            _counterBtn = Document.rootVisualElement.Q<Button>("CounterBtn");
            _counterBtn.clicked += _counterBtn_clicked;

            CountProperty.Subscribe(x =>
            {
                Debug.Log($"Кажется счетчик поменялся, его значение: {x}");
                if (x >= 10)
                {
                    _eventBus.RaiseEvent<ITenClickedAchivmentEventHandler>(h => h.AchivmentHandler());
                    _eventBus.Unsubscribe(this);
                }
            }).AddTo(_compositeDisposable);
        }

        private void OnDestroy()
        {
            _compositeDisposable.Clear();
        }

        private void _counterBtn_clicked()
        {
            CountProperty.Value += 1;
            _counterBtn.text = $"Click me : {CountProperty.Value}";
        }

        public void AchivmentHandler()
        {
            Debug.Log("Поздравляю, вы крутой!");
        }
    }
}
