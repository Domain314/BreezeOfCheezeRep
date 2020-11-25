using System.Collections;
using UnityEngine;

public class TutorialController : MonoBehaviour
{
    public GameObject TutorialQuestion;
    public GameObject TutorialCanvas;
    public GameObject NuclearTutorial;

    private void Awake()
    {
        EventManager.Instance.NuclearActivated += ShowNuclearTutorial;
    }

    public void SkipTutorial()
    {       
        EventManager.Instance.onEndOfTutorial();
        Destroy(TutorialCanvas);
        Destroy(TutorialQuestion);
    }

    public void BeginnTutorial()
    {
        TutorialCanvas.SetActive(true);
        Destroy(TutorialQuestion);
    }

    void ShowNuclearTutorial()
    {
        StartCoroutine(ShowNuclearTut());
    }

    IEnumerator ShowNuclearTut()
    {
        yield return new WaitForSeconds(4.5f);
        GameManager.Instance.isPaused = true;
        NuclearTutorial.SetActive(true);
    }

    private void OnDestroy()
    {
        EventManager.Instance.NuclearActivated -= ShowNuclearTutorial;
    }
}
