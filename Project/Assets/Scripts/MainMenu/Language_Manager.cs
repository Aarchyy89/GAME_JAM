using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class Language_Manager : MonoBehaviour
{
    private void Start()
    {
        if (PlayerPrefs.HasKey("Language"))
        {
            StartCoroutine("SwapLanguage");
        }
    }

    public void SetLanguage(string newLanguageCode)
    {
        Dictionary<string, Locale> languages = new Dictionary<string, Locale>
        {
            {"es", LocalizationSettings.AvailableLocales.Locales[0]},
            {"en", LocalizationSettings.AvailableLocales.Locales[1]},
            {"fr", LocalizationSettings.AvailableLocales.Locales[2]},
            {"de", LocalizationSettings.AvailableLocales.Locales[3]},
            {"ca", LocalizationSettings.AvailableLocales.Locales[4]},
            {"it", LocalizationSettings.AvailableLocales.Locales[5]}

        };

        if (languages.ContainsKey(newLanguageCode))
        {
            LocalizationSettings.SelectedLocale = languages[newLanguageCode];
            PlayerPrefs.SetString("Language", newLanguageCode);
        }

    }

    IEnumerator SwapLanguage()
    {
        yield return new WaitForSeconds(0.5f);
        SetLanguage(PlayerPrefs.GetString("Language"));
    }
}
