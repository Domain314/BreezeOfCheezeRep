using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsController : MonoBehaviour
{
    public Image TitelPic;
    public GameObject CreditsHolder;

    public Color startColour;
    public Color endColour;

    Vector2 startPos;
    Vector2 endPos;

    bool isCreditsRolling = false;

    private void Awake()
    {
        startPos = CreditsHolder.transform.position;
        endPos = new Vector2(CreditsHolder.transform.position.x, 3000f);
    }

    public void CREDITSBUTTON()
    {
        if (!isCreditsRolling)
        {
            isCreditsRolling = true;
            StartCoroutine(FadeOut());
            StartCoroutine(RollCredits());
        }       
    }

    IEnumerator FadeOut()
    {
        for (float i = 0; i < 1.5f; i += Time.deltaTime)
        {
            TitelPic.color = Color.Lerp(startColour, endColour, i / 1.5f);
            yield return null;
        }
    }

    IEnumerator FadeIn()
    {
        for (float i = 0; i < 1; i += Time.deltaTime)
        {
            TitelPic.color = Color.Lerp(endColour, startColour, i);
            yield return null;
        }
    }

    IEnumerator RollCredits()
    {
        for (float i = 0; i < 60f; i += Time.deltaTime)
        {
            CreditsHolder.transform.position = Vector2.Lerp(startPos, endPos, i/60);
            yield return null;
        }
        isCreditsRolling = false;
        StartCoroutine(FadeIn());       
    }
        
}

// 2685