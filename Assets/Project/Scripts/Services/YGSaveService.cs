using System.Collections.Generic;
using YG;
namespace Assets.Project.Scripts.Services
{
    public class YGSaveService
    {
        public SavesYG LocalSavesYG { get; set; }

        public void Save()
        {
            YandexGame.savesData = LocalSavesYG;
            YandexGame.SaveProgress();
        }

        public void Load()
        {
            YandexGame.LoadProgress();
        }
    }
}
