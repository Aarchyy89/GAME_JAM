
using UnityEngine;
using TMPro;

public class Calidad_Manager : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public int calidad;

    
    // Start is called before the first frame update
    void Start()
    {
        calidad = PlayerPrefs.GetInt("Calidad", 3);
        dropdown.value = calidad;
        AjustarCalidad();
    }

    public void AjustarCalidad()
    {
        QualitySettings.SetQualityLevel(dropdown.value);
        PlayerPrefs.SetInt("Calidad", dropdown.value);
        calidad = dropdown.value;   
    }
}
