using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Globalization;

public class GameOverController : MonoBehaviour
{
    public List<TextMeshProUGUI> TextMPs;

    public TextMeshProUGUI EndMsg;
    public TextMeshProUGUI plsComment;

    public GameObject NextButton;

    string endMsg1 = "I hope you're a bit exhausted.\n\nBecause this is a tiny bit what it feels like to fight world starvation irl.\nEven if your score was ";
    string endMsg2 = " people had to die on the way.\n\nDont be a bystander.\nInform yourself and help someone.\n\nCheers,\n\nDom";

    public Color startColor;
    public Color endColor;

    int counter = 0;

    int playerScore;
    int totalStarvations;
    int daysNeeded;

    public void SetupDisplay()
    {
        for (int i = 0; i < TextMPs.Count; i++)
        {
            TextMPs[i].color = startColor;
        }
        EndMsg.color = startColor;
        plsComment.color = startColor;
        NextButton.SetActive(false);

        playerScore = Mathf.RoundToInt(GameManager.Instance.TotalScore());
        totalStarvations = GameObject.FindGameObjectWithTag("InfoTable").GetComponent<InfoTableController>().totalStarvation;
        daysNeeded = GameObject.FindGameObjectWithTag("InfoTable").GetComponent<InfoTableController>().dayCounter;

        if (GameManager.Instance.isWin)
        {
            TextWinGame();
        } else
        {
            TextLoseGame();
            counter++;
        }

        TextMPs[3].text = playerScore.ToString("N0", CultureInfo.CurrentCulture);
        TextMPs[5].text = totalStarvations.ToString("N0", CultureInfo.CurrentCulture);
        TextMPs[7].text = daysNeeded.ToString();
        EndMsg.text = string.Format("{0}{1}, {2}{3}", endMsg1, playerScore.ToString("N0", CultureInfo.CurrentCulture), totalStarvations.ToString("N0", CultureInfo.CurrentCulture), endMsg2);

        StartCoroutine(DisplayInfo());
    }

    void TextWinGame()
    {
        TextMPs[0].text = "Congratulations!";
        TextMPs[1].text = "You have conquered world hunger!";
    }

    void TextLoseGame()
    {
        TextMPs[0].text = "You lost";
        TextMPs[1].text = "The food industry got rid of you..";
    }

    IEnumerator DisplayInfo()
    {
        yield return new WaitForSeconds(0.5f);
        for (int i = 0; i < TextMPs.Count; i++)
        {
            BlendIn(TextMPs[i]);
            yield return new WaitForSeconds(0.8f);
        }
        NextButton.SetActive(true);
    }

    void BlendIn(TextMeshProUGUI text)
    {
        text.color = endColor;
    }

    public void NEXT_BUTTON()
    {
        switch (counter)
        {
            case 0:
                BlendOutFirtstPage();
                break;
            case 1:
                plsComment.color = endColor;
                NextButton.GetComponentInChildren<TextMeshProUGUI>().text = "Goodbye";
                break;
            case 2:
                SceneManager.LoadScene(0);
                break;
            default:
                break;
        }
        counter++;
    }

    void BlendOutFirtstPage()
    {
        for (int i = 0; i < TextMPs.Count; i++)
        {
            TextMPs[i].color = startColor;
        }
        EndMsg.color = endColor;
    }
}
