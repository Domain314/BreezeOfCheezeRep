using System.Collections;
using UnityEngine;

public class TutorialCon : MonoBehaviour
{
    public GameObject Paper1;
    public GameObject Paper2;
    public GameObject Paper3;
    public GameObject Paper4;
    public GameObject Paper5;

    public GameObject HungerSignTutorial;
    public Transform HungerSignParent;

    private void Awake()
    {
        GameManager.Instance.isPaused = true;
        Paper1.SetActive(true);
    }

    public void NextPaper()
    {
        Paper1.SetActive(false);
        Paper2.SetActive(true);
    }

    public void PreviousPaper()
    {
        Paper2.SetActive(false);
        Paper1.SetActive(true);
    }

    public void ClosePaper2()
    {
        Destroy(Paper1);
        Destroy(Paper2);
        StartCoroutine(TutorialWaitForNextStep());
    }

    IEnumerator TutorialWaitForNextStep()
    {
        yield return new WaitForSeconds(8f);
        Paper3.SetActive(true);
    }

    public void ClosePaper3()
    {
        Destroy(Paper3);
        StartCoroutine(TutorialWaitForHungersign());
    }

    IEnumerator TutorialWaitForHungersign()
    {
        yield return new WaitForSeconds(1f);
        Instantiate(HungerSignTutorial, new Vector3(-1, -1, 0), Quaternion.identity, HungerSignParent);
        SoundManager.Instance.PlayStomachGrowl();
        EventManager.Instance.TargetWarning += LockAndLoadInstruction;
    }

    void LockAndLoadInstruction(Vector3 pos)
    {
        Paper4.SetActive(true);
    }

    public void ClosePaper4()
    {
        Destroy(Paper4);
        EventManager.Instance.Fire += TutorialFire;
    }

    void TutorialFire(Vector3 pos)
    {
        StartCoroutine(WaitForRocketToExplode());
    } 

    IEnumerator WaitForRocketToExplode()
    {
        yield return new WaitForSeconds(4.5f);
        Paper5.SetActive(true);
    }

    public void EndTutorialAndClosePaper()
    {
        EventManager.Instance.onEndOfTutorial();
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        EventManager.Instance.TargetWarning -= LockAndLoadInstruction;
        EventManager.Instance.Fire -= TutorialFire;
    }
}
