using UnityEngine;
using UnityEngine.UI;

public class WarningSignController : MonoBehaviour
{
    float selfDestructTimer;
    float selfDestructMax = 15f;
    bool isPaused = false;

    public Image TimeFillerImage;

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
        SoundManager.Instance.PlayStomachGrowl();
        EventManager.Instance.Fire += Selfdestruct;
        EventManager.Instance.Pause += PauseTimer;
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
                Destroy(gameObject);
            }
        }   
    }

    private void OnDestroy()
    {
        EventManager.Instance.onAddScore(selfDestructTimer);
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
}
