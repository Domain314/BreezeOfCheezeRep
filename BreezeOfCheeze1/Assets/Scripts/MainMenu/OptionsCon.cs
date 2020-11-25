using UnityEngine;

public class OptionsCon : MonoBehaviour
{
    public GameObject NotSupportedLanguage;
    public GameObject OptionsBackground;
    public GameObject DifficultyBackground;

    public Vector3 startPos;
    public Vector3 endPos;

    private void Awake()
    {
        OptionsBackground.SetActive(false);
    }

    public void ChangeToGer()
    {
        PlayerPrefs.SetInt("language", 1);
        PlayerPrefs.Save();
        OptionsBackground.SetActive(false);
    }

    public void ChangeToEng()
    {
        PlayerPrefs.SetInt("language", 0);
        PlayerPrefs.Save();
        OptionsBackground.SetActive(false);
    }

    public void NotSupportedLan()
    {
        Instantiate(NotSupportedLanguage, gameObject.transform.position, Quaternion.identity, gameObject.transform);
    }

    public void OptionsActivate()
    {
        OptionsBackground.SetActive(true);
    }

    public void NewGame()
    {
        Instantiate(DifficultyBackground, gameObject.transform.position, Quaternion.identity, gameObject.transform);
    }


}
