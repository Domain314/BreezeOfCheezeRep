using UnityEngine;
using TMPro;

public class WorldController : MonoBehaviour
{
    public GameObject TargetIndicationGO;
    public TextMeshProUGUI TargetIndication;
    public bool isTarget = false;
    public bool isLockedAndLoaded = false;

    Vector3 signPos;

    private void Awake()
    {
        EventManager.Instance.TargetWarning += EnableTargetIndication;
        EventManager.Instance.TargetWarningEnd += DisableTargetIndication;
        EventManager.Instance.PhaseOneComplete += PhaseTwo;
        EventManager.Instance.PhaseTwoComplete += LockedAndLoaded;
        TargetIndicationGO.SetActive(false);
    }

    private void OnDisable()
    {
        EventManager.Instance.TargetWarning -= EnableTargetIndication;
        EventManager.Instance.TargetWarningEnd -= DisableTargetIndication;
        EventManager.Instance.PhaseOneComplete -= PhaseTwo;
        EventManager.Instance.PhaseTwoComplete -= LockedAndLoaded;
    }

    void EnableTargetIndication(Vector3 pos)
    {
        signPos = pos;
        TargetIndicationGO.SetActive(true);
        TargetIndication.text = "Lock and Load!";
        isTarget = true;
    }

    void DisableTargetIndication()
    {
        signPos = new Vector3(0, 0, 0);
        TargetIndicationGO.SetActive(false);
        isTarget = false;
    }

    //Enter rnd Number
    public void PhaseOne()
    {
        if (isTarget)
        {
            if (GameManager.Instance.difficulty)
            {
                EventManager.Instance.OnPhaseOne();
            }
            else
            {
                PhaseTwo();
            }
            isTarget = false;
        }   
    }

    //Enter ASDFÖLKJ
    void PhaseTwo()
    {
        EventManager.Instance.OnPhaseTwo();
    }

    void LockedAndLoaded()
    {
        TargetIndication.text = "Fire!";
        isLockedAndLoaded = true;
    }

    public void Fire()
    {
        if (isLockedAndLoaded)
        {
            //Debug.Log("Fireded. fuk u, scum. lol");
            EventManager.Instance.onFire(signPos);
            isLockedAndLoaded = false;
            TargetIndicationGO.SetActive(false);
        }
    }
}
