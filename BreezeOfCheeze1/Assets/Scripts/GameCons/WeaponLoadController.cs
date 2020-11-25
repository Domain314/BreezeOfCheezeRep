using UnityEngine;

public class WeaponLoadController : MonoBehaviour
{
    private void Awake()
    {
        EventManager.Instance.PhaseTwo += StepA;
    }

    void StepA()
    {
        MatchInput.Instance.onTextTypedCorrectly += StepS;
        MatchInput.Instance.NewText("a");
    }

    void StepS()
    {
        MatchInput.Instance.onTextTypedCorrectly -= StepS;
        MatchInput.Instance.onTextTypedCorrectly += StepD;
        MatchInput.Instance.NewText("s");
    }

    void StepD()
    {
        MatchInput.Instance.onTextTypedCorrectly -= StepD;
        MatchInput.Instance.onTextTypedCorrectly += StepF;
        MatchInput.Instance.NewText("d");
    }

    void StepF()
    {
        MatchInput.Instance.onTextTypedCorrectly -= StepF;
        if (GameManager.Instance.keyboardLayoutLanguage)
        {
            MatchInput.Instance.onTextTypedCorrectly += StepOE;
        }
        else
        {
            MatchInput.Instance.onTextTypedCorrectly += StepColon;
        }
        MatchInput.Instance.NewText("f");
    }

    void StepOE()   //ger layout
    {
        MatchInput.Instance.onTextTypedCorrectly -= StepOE;
        MatchInput.Instance.onTextTypedCorrectly += StepL;
        MatchInput.Instance.NewText("ö");
    }

    void StepColon()    //eng layout
    {
        MatchInput.Instance.onTextTypedCorrectly -= StepColon;
        MatchInput.Instance.onTextTypedCorrectly += StepL;
        MatchInput.Instance.NewText(";");
    }

    void StepL()
    {
        MatchInput.Instance.onTextTypedCorrectly -= StepL;
        MatchInput.Instance.onTextTypedCorrectly += StepK;
        MatchInput.Instance.NewText("l");
    }

    void StepK()
    {
        MatchInput.Instance.onTextTypedCorrectly -= StepK;
        MatchInput.Instance.onTextTypedCorrectly += StepJ;
        MatchInput.Instance.NewText("k");
    }

    void StepJ()
    {
        MatchInput.Instance.onTextTypedCorrectly -= StepJ;
        MatchInput.Instance.onTextTypedCorrectly += EndPhaseTwo;
        MatchInput.Instance.NewText("j");
    }

    void EndPhaseTwo()
    {
        MatchInput.Instance.onTextTypedCorrectly -= EndPhaseTwo;
        EventManager.Instance.OnPhaseTwoComplete();
    }
}
