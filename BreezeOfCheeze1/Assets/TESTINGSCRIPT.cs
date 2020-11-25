using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TESTINGSCRIPT : MonoBehaviour
{
    public Image image;

    Vector2 endPos;
    Vector2 startPos;


    void Start()
    {
        startPos = new Vector2(100, 0);
        endPos = new Vector2(-100, 0);
        StartCoroutine(ShowNews());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ShowNews()
    {
        image.transform.localPosition = startPos;

        for (float x = 0; x <= 1; x += Time.deltaTime)
        {
            image.transform.localPosition = Vector2.Lerp(startPos, endPos, x);
            //NewsContent.transform.Translate(new Vector3(Mathf.Lerp(screensizeX, -screensizeX, x), 0, 0));
            yield return null;
        }


        //while (NewsContent.transform.localPosition.x >= (Screen.width * -1))
        //{
        //    NewsContent.transform.Translate(new Vector3(NewsContent.transform.localPosition.x + Time.deltaTime, 0, 0));
        //    yield return null;
        //}        
    }
}
