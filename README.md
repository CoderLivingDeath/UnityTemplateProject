# Tamplate3d
Шаблон проекта на юнити с использованием архитектуры MVC.

В разработке...

## MVC и MVVM структура проекта
MVC структура папок в проекте расположана по пути Asset/Project/Scripts. Для UI может использововаться MVVM архитектура с использованием UIToolkit или других интрументов, для это сделана папка ViewModels в директории View. Для MVVM используется базовые классы ViewModelBase и MonoViewModelBase созданные в той же папке.

## Отслеживание контроллеров
Контроллеры отслеживаются через промежуточный код, в определенной сборке и пространстве имен. Namespace указан в AppSettings(наследует ScriptableObject. путь Asset/Project/Infrastructure/Settings), который находится в папке Asset/Settings.
Промежуточный код для DiContainer zenject находится в Asset/Project/Infrastructure/ZenjectMiddleware.
