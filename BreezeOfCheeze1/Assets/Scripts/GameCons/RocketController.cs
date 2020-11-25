using System.Collections;
using UnityEngine;
using DigitalRuby.Tween;

public class RocketController : MonoBehaviour
{
    GameObject Splash;
    float flyTime = 4f;

    public SpriteRenderer dotRenderer;

    private void Awake()
    {
        StartCoroutine(DotBlinking());
    }

    public void FetchCoordinates(Vector3 coord, GameObject _splash)
    {
        if (coord == Vector3.zero)
        {
            Destroy(gameObject);
            return;
        }
        Splash = _splash;
        TweenMove(coord);
    }

    void TweenMove(Vector3 _coord)
    {
        System.Action<ITween<Vector3>> updateRocketPos = (t) =>
        {
            gameObject.transform.position = t.CurrentValue;
        };

        System.Action<ITween<Vector3>> moveCompleted = (t) =>
        {
            SpawnSplash(_coord);
        };

        gameObject.Tween("MoveRocket", gameObject.transform.position, _coord, flyTime, TweenScaleFunctions.CubicEaseOut, updateRocketPos, moveCompleted);

        StartCoroutine(SelfdestroyAfterFailedStart(_coord));
    }

    void SpawnSplash(Vector3 _coord)
    {
        Quaternion rnd = new Quaternion();
        rnd.eulerAngles = new Vector3(0, 0, Random.Range(0, 360));

        Instantiate(Splash, _coord, rnd, gameObject.transform.parent);
        StopAllCoroutines();
        Destroy(gameObject);
    }

    IEnumerator SelfdestroyAfterFailedStart(Vector3 _coord)
    {
        yield return new WaitForSeconds(flyTime + 0.1f);
        SpawnSplash(_coord);
        Destroy(gameObject);
    }

    IEnumerator DotBlinking()
    {
        for (float i = 0.2f; i >= 0; i -= Time.deltaTime)
        {
            dotRenderer.color = new Color(1, 0f, 0f, Mathf.Lerp(0, 1, i * 5));
            yield return null;
        }
        for (float i = 0; i <= 0.2f; i += Time.deltaTime)
        {
            dotRenderer.color = new Color(1, 0f, 0f, Mathf.Lerp(0, 1, i * 5));
            yield return null;
        }
        StartCoroutine(DotBlinking());
    }
}
