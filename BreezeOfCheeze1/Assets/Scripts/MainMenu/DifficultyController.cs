using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultyController : MonoBehaviour
{
    public void EasyGame()
    {
        PlayerPrefs.SetInt("difficulty", 0);
        SceneManager.LoadScene(1);
    }

    public void HardGame()
    {
        PlayerPrefs.SetInt("difficulty", 1);
        SceneManager.LoadScene(1);
    }
}
