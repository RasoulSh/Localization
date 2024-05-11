using Localization.Base.Enums;
using UnityEngine;

namespace Localization
{
    public class LocalizationAccessor : MonoBehaviour
    {
        private static LocalizationAccessor instance { get; set; }
        [SerializeField] private Base.Localization data;
        public static Base.Localization Localization => instance == null ? null : instance.data;
        private bool isInitialized = false; 

        
        private void OnEnable()
        {
            if (instance != null)
            {
                Debug.LogWarning("There could be only one instance of localization");
                return;
            }
            Initialize();
        }

        private void Initialize()
        {
            if (isInitialized)
            {
                Debug.LogWarning("The localization has already been initialized");
                return;
            }
            instance = this;
            Localization.Initialize();
            isInitialized = true;
        }

        [ContextMenu(nameof(ChangeToEnglish))]
        public void ChangeToEnglish()
        {
            data.ChangeLanguage(Languages.English, this);
        }
        
        [ContextMenu(nameof(ChangeToPersian))]
        public void ChangeToPersian()
        {
            data.ChangeLanguage(Languages.Persian, this);
        }
    }
}
