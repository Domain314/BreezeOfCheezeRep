using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial4Script : MonoBehaviour
{
    public List<Image> Buttons;

    public Color ButtonOn;
    public Color ButtonOff;

    private void Awake()
    {
        StartCoroutine(ButtonBlinking());
    }

    IEnumerator ButtonBlinking()
    {
        for (int i = 0; i < Buttons.Count; i++)
        {
            if (i != 0)
            {
                Buttons[i - 1].color = ButtonOff;
            }
            Buttons[i].color = ButtonOn;
            yield return new WaitForSeconds(0.3f);
        }
        Buttons[7].color = ButtonOff;
        yield return new WaitForSeconds(1f);
        StartCoroutine(ButtonBlinking());
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
    }
}
