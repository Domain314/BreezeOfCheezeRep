using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class NuclearSignController : MonoBehaviour
{
    float selfDestructTimer;
    float selfDestructMax = 20f;
    bool isPaused = false;

    public Image TimeFillerImage;
    public SpriteRenderer NuclearSign;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("crosshair"))
        {
            EventManager.Instance.OnTargetWarning(gameObject.transform.position);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        EventManager.Instance.OnTargetWarningEnd();
    }

    private void Awake()
    {
        SoundManager.Instance.NuclearWarning.source.Play();
        EventManager.Instance.Fire += Selfdestruct;
        EventManager.Instance.Pause += PauseTimer;
        StartCoroutine(FadeSymbol());
        selfDestructTimer = selfDestructMax;
    }

    private void Update()
    {
        if (!isPaused)
        {
            selfDestructTimer -= Time.deltaTime;
            UpdateFillerImage(selfDestructTimer);
            if (selfDestructTimer <= 0) 
            {
                EventManager.Instance.onNuclearDamage();
                Destroy(gameObject);
            }
        }
    }

    private void OnDestroy()
    {       
        EventManager.Instance.Fire -= Selfdestruct;
        EventManager.Instance.Pause -= PauseTimer;
    }

    void UpdateFillerImage(float timer)
    {
        TimeFillerImage.fillAmount = timer / selfDestructMax;
    }

    void Selfdestruct(Vector3 pos)
    {
        if (pos == gameObject.transform.position)
        {
            Destroy(gameObject);
        }
    }

    void PauseTimer(bool _isPaused)
    {
        isPaused = _isPaused;
    }

    IEnumerator FadeSymbol()
    {
        for (float i = 1; i >= 0; i -= Time.deltaTime)
        {
            NuclearSign.color = new Color(1, 1, 1, Mathf.Lerp(0, 1, i));
            yield return null;
        }
        StopAllCoroutines();
        StartCoroutine(BlendSymbol());
    }

    IEnumerator BlendSymbol()
    {
        for (float i = 0; i <= 1; i += Time.deltaTime)
        {
            NuclearSign.color = new Color(1, 1, 1, Mathf.Lerp(0, 1, i));
            yield return null;
        }
        StopAllCoroutines();
        StartCoroutine(FadeSymbol());
        
    }
}
