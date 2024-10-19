# Tamplate3d
Шаблон проекта на юнити с использованием архитектуры MVC/MVVM.

Используется Zenject, UniRX, Addresable.

В разработке...

## MVC и MVVM структура проекта
MVC структура папок в проекте расположана по пути
```Asset/Project/Scripts``` Для UI может использововаться MVVM архитектура с использованием UIToolkit или других интрументов, для это сделана папка ViewModels в директории View. Для MVVM используется базовые классы ViewModelBase и MonoViewModelBase созданные в той же папке. 

*Это не чистая реализация этих архитектур, а скорее их неуклюжее комбинация*

## Отслеживание контроллеров
Контроллеры отслеживаются через промежуточный код, в определенной сборке и пространстве имен. Namespace указан в AppSettings(наследует ScriptableObject. путь Asset/Project/Infrastructure/Settings), который находится в папке Asset/Settings.
Промежуточный код для DiContainer zenject находится в Asset/Project/Infrastructure/ZenjectMiddleware.

Отслеживаются только классы с атрибутом [Controller] и в указанном пространстве имен в AppSettings.

## Event bus
Используется шина событий через интерфейсы, которые были позаимствованы с этой статьи https://habr.com/ru/articles/527418/.
Конекретная реальизация шины прокидывается через Zenject в ProjectContext.
Реализация шины расположена по пути Asset/Project/Infrastructure/EventBus, а так же там расположены интерфейсы событий необходимые для работы.
