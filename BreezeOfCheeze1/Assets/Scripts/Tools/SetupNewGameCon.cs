using UnityEngine;

public class SetupNewGameCon : MonoBehaviour
{
    private void Start()
    {
        EventManager.Instance.onGameStart();
    }
}
