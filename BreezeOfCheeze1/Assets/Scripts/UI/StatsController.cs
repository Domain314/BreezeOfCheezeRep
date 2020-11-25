using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StatsController : MonoBehaviour
{
    public Image Total;
    public Image NAmerica;
    public Image SAmerica;
    public Image Europe;
    public Image Asia;
    public Image Africa;
    public Image Australia;

    public TextMeshProUGUI TotalText;
    public TextMeshProUGUI NAmericaText;
    public TextMeshProUGUI SAmericaText;
    public TextMeshProUGUI EuropeText;
    public TextMeshProUGUI AsiaText;
    public TextMeshProUGUI AfricaText;
    public TextMeshProUGUI AustraliaText;

    public int totalMax, NAmericaMax, SAmericaMax, EuropeMax, AsiaMax, AfricaMax, AustraliaMax;

    private void Start()
    {
        SignSpawnerController sSC = GameObject.FindGameObjectWithTag("World").GetComponent<SignSpawnerController>();
        NAmericaMax = sSC.NAmericaSpawnPoints.Count;
        SAmericaMax = sSC.SAmerikaSpawnPoints.Count;
        EuropeMax = sSC.EuropeSpawnPoints.Count;
        AsiaMax = sSC.AsiaSpawnPoints.Count;
        AfricaMax = sSC.AfrikaSpawnPoints.Count;
        AustraliaMax = sSC.AustraliaSpawnPoints.Count;
        totalMax = NAmericaMax + SAmericaMax + EuropeMax + AsiaMax + AfricaMax + AustraliaMax;

        EventManager.Instance.UpdateStatsUI += UpdateStats;
    }

    private void OnDisable()
    {
        EventManager.Instance.UpdateStatsUI -= UpdateStats;
    }

    void UpdateStats(int nA, int sA, int eu, int asia, int afr, int aus)
    {
        NAmerica.fillAmount = (NAmericaMax - nA) / (float)NAmericaMax;
        NAmericaText.text = (Mathf.RoundToInt(NAmerica.fillAmount * 100)).ToString() + "%";
        SAmerica.fillAmount = (SAmericaMax - sA) / (float)SAmericaMax;
        SAmericaText.text = (Mathf.RoundToInt(SAmerica.fillAmount * 100)).ToString() + "%";
        Europe.fillAmount = (EuropeMax - eu) / (float)EuropeMax;
        EuropeText.text = (Mathf.RoundToInt(Europe.fillAmount * 100)).ToString() + "%";
        Asia.fillAmount = (AsiaMax - asia) / (float)AsiaMax;
        AsiaText.text = (Mathf.RoundToInt(Asia.fillAmount * 100)).ToString() + "%";
        Africa.fillAmount = (AfricaMax - afr) / (float)AfricaMax;
        AfricaText.text = (Mathf.RoundToInt(Africa.fillAmount * 100)).ToString() + "%";
        Australia.fillAmount = (AustraliaMax - aus) / (float)AustraliaMax;
        AustraliaText.text = (Mathf.RoundToInt(Australia.fillAmount * 100)).ToString() + "%";
        float totalRec = (totalMax - nA - sA - eu - asia - afr - aus) / (float)totalMax;
        Total.fillAmount = totalRec;
        TotalText.text = (Mathf.RoundToInt(totalRec * 100)).ToString() + "%";
        EventManager.Instance.onUpdateProgress(totalRec);
    }
}
