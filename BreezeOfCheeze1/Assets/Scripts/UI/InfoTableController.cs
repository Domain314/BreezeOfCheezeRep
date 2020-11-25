using UnityEngine;
using TMPro;
using System.Globalization;

public class InfoTableController : MonoBehaviour
{
    public TextMeshProUGUI DateText;
    public TextMeshProUGUI StarvationInfoText;
    public TextMeshProUGUI ScoreText;

    public System.DateTime today;
    public int dayCounter;

    public int dailyStarvation = 24420;
    public int totalStarvation;
    public float totalScore;

    private void Awake()
    {
        EventManager.Instance.UpdateProgress += UpdateDailyStarv;
        EventManager.Instance.AddScore += UpdateScore;
        EventManager.Instance.EndOfTutorial += EndTutorial;

        today = System.DateTime.Today;
        DateUpdate();
        DailyStarvationUpdate();
    }

    private void OnDestroy()
    {
        EventManager.Instance.UpdateProgress -= UpdateDailyStarv;
        EventManager.Instance.AddScore -= UpdateScore;
        EventManager.Instance.EndOfTutorial -= EndTutorial;
    }

    void EndTutorial()
    {
        InvokeRepeating("DayPassing", 3f, 3f);
    }

    void DayPassing()
    {
        if (GameManager.Instance.isPaused)
        {
            return;
        }

        today = today.AddDays(1);
        dayCounter++;
        totalStarvation += dailyStarvation;
        DailyStarvationUpdate();
        DateUpdate();
    }

    void DateUpdate()
    {
        DateText.text = 
            today.Month.ToString() + "/" + 
            today.Day.ToString() + "\n" + 
            today.Year.ToString();
    }

    void DailyStarvationUpdate()
    {
        StarvationInfoText.text = string.Format("+{0}\n{1}", 
            dailyStarvation.ToString("N0", CultureInfo.CurrentCulture), 
            totalStarvation.ToString("N0", CultureInfo.CurrentCulture));
    }

    void UpdateDailyStarv(float prog)
    {
        dailyStarvation = (int)Mathf.Lerp(24420, 0, prog);
        DailyStarvationUpdate();
    }

    void UpdateScore(float score)
    {
        totalScore += score * 100;
        ScoreText.text = string.Format("{0}", totalScore.ToString("N0", CultureInfo.CurrentCulture));
    }
}
