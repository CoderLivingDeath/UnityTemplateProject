
namespace YG
{
    [System.Serializable]
    public class SavesYG
    {
        #region DO NOT DELETE
        // "Технические сохранения" для работы плагина (Не удалять)
        public int idSave;
        public bool isFirstSession = true;
        public string language = "ru";
        public bool promptDone;
        #endregion

        #region Data
        

        #endregion

        public SavesYG()
        {
        }
    }
}
