using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewsController : MonoBehaviour
{
    // 0-20%
    string Zero1 = "Several witnesses from Africa report cheese falling from the sky.";
    string Zero2 = "Psychologists suspect mass hallucination behind rumours on cheese falling from the sky.";
    string Zero3 = "Some videos went viral about cheese falling from the sky. They are all fake. Right?";
    string Zero4 = "A new conspiracy theory takes the stage: cheese falling from the sky.";
    string Zero5 = "Some military stations recorded strange space activity.";

    // 20-40%
    string Two1 = "Strange cheese-related weather phenomena occur around the world.";
    string Two2 = "“IT’S A CHEESE MIRACLE” some witnesses report in a 3rd world country.";
    string Two3 = "US citizen tries to sue the sky for covering his house with cheese.";
    string Two4 = "Conflicts in the middle east settled down, after “blessings from the cheese god”.";
    string Two5 = "Australian bushfire crisis ended thanks to cheese that fell from the sky";
    string Two6 = "Scientologists claim that sky cheese is a gift from their alien-god.";

    //40-65%
    string For1 = "Food company CEOs warn of food poisoning and space AIDS from Sky-Cheese.";
    string For2 = "Naked conspiracy theorist was found confused in a mall: “THIS IS THE CHEESOCALYPSE!”";
    string For3 = "ISIS gave up completely. “Our god was a lie. We converted to Cheesoism.”";
    string For4 = "Sky-Cheese turns out to be 100% lactose free.";
    string For5 = "The 5-seconds rule doesn’t apply to Sky-Cheese. It was roasted in the atmosphere and is too hot for microbes.";
    string For6 = "Spongebob confessed to be made from cheese.";
    string For7 = "North Koreans thank their supreme leader over cheesy rain.";
    string For8 = "The Flying Spaghetti Monster lost its popularity to the Tripping Mac'n'Cheese Monster."; // or "Dripping"?

    // 65-100%
    string Six1 = "Conspiracy theorists are sure about “cheesocalypse”.";
    string Six2 = "Newest single climbs to the top of the charts: “It’s raining cheese! Hallelujah!”";
    string Six3 = "Nobody wants to buy Cheeseburgers anymore. McRonald’s faces bankruptcy.";
    string Six4 = "Netflux released two new shows: “Cheese is the new black” and “Stranger Cheese” ";
    string Six5 = "“Cheesetastic” is the new word of year. “Cheesy” not negative anymore.";
    string Six6 = "Sky-Cheese must be 100% vegan, due to lack of space cows.";
    string Six7 = "Nostradamus prophesied Sky-cheese, before it was cool.";
    string Six8 = "A “cheese-nado” devastated parts of Texas. Worldfirst Cheese-related deaths: 2";
    string Six9 = "Cooking websites are exploding with cheese-related entries.";

    public List<string> Zero;
    public List<string> Twenty;
    public List<string> Forty;
    public List<string> Sixty;

    public GameObject NewsBackground;
    public GameObject NewsContent;

    public float totalProg;
    int progStage = 1;
    float timer = 75f;
    float timeUntilNews = 75f;

    Vector2 startPos;
    Vector2 endPos;

    private void Awake()
    {
        Zero.Add(Zero1); Zero.Add(Zero2); Zero.Add(Zero3); Zero.Add(Zero4); Zero.Add(Zero5);
        Twenty.Add(Two1); Twenty.Add(Two2); Twenty.Add(Two3); Twenty.Add(Two4); Twenty.Add(Two5); Twenty.Add(Two6);
        Forty.Add(For1); Forty.Add(For2); Forty.Add(For3); Forty.Add(For4); Forty.Add(For5); Forty.Add(For6); Forty.Add(For7); Forty.Add(For8);
        Sixty.Add(Six1); Sixty.Add(Six2); Sixty.Add(Six3); Sixty.Add(Six4); Sixty.Add(Six5); Sixty.Add(Six6); Sixty.Add(Six7); Sixty.Add(Six8); Sixty.Add(Six9);

        EventManager.Instance.UpdateProgress += UpdateProg;
        startPos = new Vector2(800f, 0);
        endPos = new Vector2(-630f, 0);
        timer = timeUntilNews;

        //CalculateNewsStage();
    }

    private void OnDisable()
    {
        EventManager.Instance.UpdateProgress -= UpdateProg;
    }

    private void Update()
    {
        if (!GameManager.Instance.isPaused) 
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                CalculateNewsStage();
                timer = timeUntilNews;
            }
        }      
    }

    void UpdateProg(float prog)
    {
        totalProg = prog * 100;

        if (totalProg >= 20 && totalProg < 40)
        {
            progStage = 2;
        }
        else if (totalProg >= 40 && totalProg < 65)
        {
            progStage = 3;
        }
        else if (totalProg >= 65)
        {
            progStage = 4;
        }
    }

    void CalculateNewsStage()
    {
        switch (progStage)
        {
            case 1:
                CalculateNewsMes(Zero);
                break;
            case 2:
                CalculateNewsMes(Twenty);
                break;
            case 3:
                CalculateNewsMes(Forty);
                break;
            case 4:
                CalculateNewsMes(Sixty);
                break;

            default:
                Debug.Log("No News found");
                break;
        }
    }

    void CalculateNewsMes(List<string> Mes)
    {
        if (Mes.Count == 0)
        {
            Debug.Log("News-pool empty");
            return;
        }
        int rnd = Random.Range(0, Mes.Count);
        StartCoroutine(ShowNews(Mes[rnd]));
        Mes.RemoveAt(rnd);
    }

    IEnumerator ShowNews(string news)
    {
        SoundManager.Instance.NewsAlert.source.Play();
        //NewsBackground.transform.position = Vector3.zero;
        NewsContent.transform.localPosition = startPos;
        NewsContent.GetComponent<TextMeshProUGUI>().text = "BREAKING NEWS: " + news;
       
        for (float x = 0; x <= 40; x += Time.deltaTime)
        {
            NewsContent.transform.localPosition = Vector2.Lerp(startPos, endPos, x / 40);
            //NewsContent.transform.Translate(new Vector3(Mathf.Lerp(screensizeX, -screensizeX, x), 0, 0));
            yield return null;
        }
    }
}
