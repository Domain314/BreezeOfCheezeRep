using System.Collections;
using UnityEngine;

public class CrosshairController : MonoBehaviour
{
    bool isTarget = false;

    private void Start()
    {
        EventManager.Instance.MoveLeft += MoveLeft;
        EventManager.Instance.MoveRight += MoveRight;
        EventManager.Instance.MoveUp += MoveUp;
        EventManager.Instance.MoveDown += MoveDown;
        EventManager.Instance.PhaseTwo += TargetLock;
        EventManager.Instance.TargetWarningEnd += TargetUnlock;
    }

    private void OnDisable()
    {
        EventManager.Instance.MoveLeft -= MoveLeft;
        EventManager.Instance.MoveRight -= MoveRight;
        EventManager.Instance.MoveUp -= MoveUp;
        EventManager.Instance.MoveDown -= MoveDown;
        EventManager.Instance.PhaseTwo -= TargetLock;
        EventManager.Instance.TargetWarningEnd -= TargetUnlock;
    }

    void TargetLock()
    {
        isTarget = true;
        StartCoroutine(AutomatedTargetUnlocker());
    }

    void TargetUnlock()
    {
        isTarget = false;
        StopAllCoroutines();
    }

    void MoveLeft(float speed)
    {
        if (!isTarget)
        {
            gameObject.transform.Translate(-speed, 0f, 0f);
        }
    }

    void MoveRight(float speed)
    {
        if (!isTarget)
        {
            gameObject.transform.Translate(speed, 0f, 0f);
        }
    }

    void MoveUp(float speed)
    {
        gameObject.transform.Translate(0f, speed, 0f);
    }

    void MoveDown(float speed)
    {
        gameObject.transform.Translate(0f, -speed, 0f);
    }

    IEnumerator AutomatedTargetUnlocker()
    {
        yield return new WaitForSeconds(8f);
        isTarget = false;
    }
}
