using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TutorialHelperScript : MonoBehaviour
{
    public Image ButtonV;
    public Image ButtonN;
    public Image ButtonF;
    public Image ButtonG;

    public Color buttonOn;
    public Color buttonOff;
    public Color buttonOn1;
    public Color buttonOff1;

    private void Awake()
    {
        StartCoroutine(AlternatelyPressingButtons());
    }

    IEnumerator AlternatelyPressingButtons()
    {
        ButtonV.color = buttonOn;
        ButtonN.color = buttonOff;
        ButtonF.color = buttonOn1;
        ButtonG.color = buttonOn1;
        yield return new WaitForSeconds(1);
        ButtonV.color = buttonOff;
        ButtonN.color = buttonOn;
        ButtonF.color = buttonOff1;
        ButtonG.color = buttonOff1;
        yield return new WaitForSeconds(1);
        StartCoroutine(AlternatelyPressingButtons());
    }
}
