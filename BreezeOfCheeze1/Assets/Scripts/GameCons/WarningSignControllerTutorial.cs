using UnityEngine;

public class WarningSignControllerTutorial : MonoBehaviour
{
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
        EventManager.Instance.Fire += Selfdestruct;
    }

    private void OnDestroy()
    {
        EventManager.Instance.Fire -= Selfdestruct;
    }

    void Selfdestruct(Vector3 pos)
    {
        if (pos == gameObject.transform.position)
        {
            Destroy(gameObject);
        }
    }
}
