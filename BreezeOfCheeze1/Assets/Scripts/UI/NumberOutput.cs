using UnityEngine;

public class NumberOutput : MonoBehaviour
{
    int min = 100;
    int max = 999;
    public int rndNumber = 0;

    private void Start()
    {
        EventManager.Instance.PhaseOne += RandomNumber;
    }

    private void OnDisable()
    {
        EventManager.Instance.PhaseOne -= RandomNumber;
    }

    public void CorrectInput()
    {
        MatchInput.Instance.onTextTypedCorrectly -= CorrectInput;
        MatchInput.Instance.onTextTypedIncorrectly -= RandomNumber;
        EventManager.Instance.OnPhaseOneComplete();
    }

    public void RandomNumber()
    {       
        rndNumber = Random.Range(min, max);
        MatchInput.Instance.onTextTypedCorrectly += CorrectInput;
        MatchInput.Instance.onTextTypedIncorrectly += RandomNumber;
        MatchInput.Instance.NewText(rndNumber.ToString());
    }
    
}
