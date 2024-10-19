using System;

namespace Assets.Project.Scripts.Models.Achivments
{
    public class Achivment
    {
        public string Name { get; set; }
        public string Description { get; set; }

        // Если данный предикат возвращает True - достижение выполнено.
        public Func<bool> Predicate { get; set; }
    }
}
