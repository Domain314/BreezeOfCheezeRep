using System.Collections;
using UnityEngine;

public class SplashCon : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    private void Awake()
    {
        SoundManager.Instance.ChooseSplash();
 
        spriteRenderer = new SpriteRenderer();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut()
    {
        yield return new WaitForSeconds(2f);
        for (float i = 4f; i >= 0; i -= Time.deltaTime)
        {
            spriteRenderer.color = new Color(1, 1, 1, Mathf.Lerp(0, 1, i / 4));
            yield return null;
        }
        Destroy(gameObject);
    }
}
