using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitGameToMenu : MonoBehaviour
{
    public void ExitGame()
    {
        SceneManager.LoadScene(0);
    }
}
