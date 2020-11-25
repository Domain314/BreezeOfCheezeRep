using UnityEngine;

public class CloseButtonMiniScript : MonoBehaviour
{
    public void CLOSEBUTTON()
    {
        GameManager.Instance.isPaused = false;
        Destroy(gameObject);
    }
}