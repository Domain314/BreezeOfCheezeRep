using System.Collections;
using UnityEngine;

public class ContinentalController : MonoBehaviour
{
    public SpriteRenderer AfricaBase;
    public SpriteRenderer AfricaOutline;
    public SpriteRenderer AsiaBase;
    public SpriteRenderer AsiaOutline;
    public SpriteRenderer AustraliaBase;
    public SpriteRenderer AustraliaOutline;
    public SpriteRenderer EuropeBase;
    public SpriteRenderer EuropeOutline;
    public SpriteRenderer NAmericaBase;
    public SpriteRenderer NAmericaOutline;
    public SpriteRenderer SAmericaBase;
    public SpriteRenderer SAmericaOutline;

    public Color poorColour;
    public Color richColour;
    public Color cheeseColour;

    public int africaMax;
    public int asiaMax;
    public int ausMax;
    public int euMax;
    public int naMax;
    public int saMax;

    private void Awake()
    {
        EventManager.Instance.UpdateStatsUI += UpdateContinents;
    }

    public void fetchMaxAmounts(int _africaMax, int _asiaMax, int _ausMax, int _euMax, int _naMax, int _saMax)
    {
        africaMax = _africaMax;
        asiaMax = _asiaMax;
        ausMax = _ausMax;
        euMax = _euMax;
        naMax = _naMax;
        saMax = _saMax;
    }

    void UpdateContinents(int nA, int sA, int eu, int asia, int afr, int aus)
    {
        StartCoroutine(UpdateAfrica((africaMax - afr) / (float)africaMax));
        StartCoroutine(UpdateAsia((asiaMax- asia) / (float)asiaMax));
        StartCoroutine(UpdateAustralia((ausMax - aus) / (float)ausMax));
        StartCoroutine(UpdateEurope((euMax - eu) / (float)euMax));
        StartCoroutine(UpdateNAmerica((naMax - nA) / (float)naMax));
        StartCoroutine(UpdateSAmerica((saMax - sA) / (float)saMax));
    }

    IEnumerator UpdateAfrica(float percent)
    {
        yield return new WaitForSeconds(4f);

        Color oldColour = AfricaBase.color;
        Color nextColour = Color.Lerp(poorColour, cheeseColour, percent);
        for (float i = 0; i <= 1; i += Time.deltaTime)
        {
            AfricaBase.color = Color.Lerp(oldColour, nextColour, i);
            AfricaOutline.color = Color.Lerp(oldColour, nextColour, i);
            yield return null;
        }
    }

    IEnumerator UpdateAsia(float percent)
    {
        yield return new WaitForSeconds(4f);

        Color oldColour = AsiaBase.color;
        Color nextColour = Color.Lerp(poorColour, cheeseColour, percent);
        for (float i = 0; i <= 1; i += Time.deltaTime)
        {
            AsiaBase.color = Color.Lerp(oldColour, nextColour, i);
            AsiaOutline.color = Color.Lerp(oldColour, nextColour, i);
            yield return null;
        }
    }

    IEnumerator UpdateAustralia(float percent)
    {
        yield return new WaitForSeconds(4f);

        Color oldColour = AustraliaBase.color;
        Color nextColour = Color.Lerp(richColour, cheeseColour, percent);
        for (float i = 0; i <= 1; i += Time.deltaTime)
        {
            AustraliaBase.color = Color.Lerp(oldColour, nextColour, i);
            AustraliaOutline.color = Color.Lerp(oldColour, nextColour, i);
            yield return null;
        }
    }

    IEnumerator UpdateEurope(float percent)
    {
        yield return new WaitForSeconds(4f);

        Color oldColour = EuropeBase.color;
        Color nextColour = Color.Lerp(richColour, cheeseColour, percent);
        for (float i = 0; i <= 1; i += Time.deltaTime)
        {
            EuropeBase.color = Color.Lerp(oldColour, nextColour, i);
            EuropeOutline.color = Color.Lerp(oldColour, nextColour, i);
            yield return null;
        }
    }

    IEnumerator UpdateNAmerica(float percent)
    {
        yield return new WaitForSeconds(4f);

        Color oldColour = NAmericaBase.color;
        Color nextColour = Color.Lerp(richColour, cheeseColour, percent);
        for (float i = 0; i <= 1; i += Time.deltaTime)
        {
            NAmericaBase.color = Color.Lerp(oldColour, nextColour, i);
            NAmericaOutline.color = Color.Lerp(oldColour, nextColour, i);
            yield return null;
        }
    }

    IEnumerator UpdateSAmerica(float percent)
    {
        yield return new WaitForSeconds(4f);

        Color oldColour = SAmericaBase.color;
        Color nextColour = Color.Lerp(poorColour, cheeseColour, percent);
        for (float i = 0; i <= 1; i += Time.deltaTime)
        {
            SAmericaBase.color = Color.Lerp(oldColour, nextColour, i);
            SAmericaOutline.color = Color.Lerp(oldColour, nextColour, i);
            yield return null;
        }
    }

}
