using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroController : MonoBehaviour
{
    public List<TextMeshProUGUI> TextMeshPros;
    public GameObject LastText;

    public Image Background;

    public Color startColour;
    public Color endColour;
    public Color backgroundColour;

    private void Awake()
    {
        StartCoroutine(BlendInFirstPage());
    }

    IEnumerator BlendInFirstPage()
    {
        for (int i = 0; i < 3; i++)
        {
            StartCoroutine(BlendIn(TextMeshPros[i]));
            yield return new WaitForSeconds(3.5f);
        }
        yield return new WaitForSeconds(3f);
        StartCoroutine(CleanUpAndBlendInSecondPage());
    }   

    IEnumerator CleanUpAndBlendInSecondPage()
    {
        for (float i = 0; i < 1; i += Time.deltaTime)
        {
            TextMeshPros[0].color = Color.Lerp(endColour, startColour, i);
            TextMeshPros[1].color = Color.Lerp(endColour, startColour, i);
            TextMeshPros[2].color = Color.Lerp(endColour, startColour, i);
            yield return null;
        }

        for (int i = 3; i < 6; i++)
        {
            StartCoroutine(BlendIn(TextMeshPros[i]));
            yield return new WaitForSeconds(3.5f);
        }

        StartCoroutine(MoveLastText());
        for (float i = 0; i < 3; i += Time.deltaTime)
        {
            Background.color = Color.Lerp(backgroundColour, startColour, i/3);
            TextMeshPros[3].color = Color.Lerp(endColour, startColour, i/3);
            TextMeshPros[4].color = Color.Lerp(endColour, startColour, i/3);
            
            yield return null;
        }
    }

    IEnumerator MoveLastText()
    {
        for (float i = 0; i < 3; i += Time.deltaTime)
        {
            LastText.transform.Translate(new Vector3(0f, -0.23f, 0f));
            yield return null;
        }
        StartCoroutine(EndOfIntro());
    }

    IEnumerator EndOfIntro()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(2);
    }

    IEnumerator BlendIn(TextMeshProUGUI textMP)
    {
        for (float i = 0; i < 2; i += Time.deltaTime)
        {
            textMP.color = Color.Lerp(startColour, endColour, i / 2);
            yield return null;
        }
    }
}
