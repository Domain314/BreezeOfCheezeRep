using System.Collections.Generic;
using UnityEngine;

public class SplashController : MonoBehaviour
{
    public GameObject rocketCrosshair;
    public List<GameObject> Splashes;

    float rocketSpawnLeft = -20;
    float rocketSpawnRight = 20;
    float rocketSpawnDown = -15;

    private void Awake()
    {
        EventManager.Instance.Fire += SpawnRocket;       
    }

    void SpawnRocket(Vector3 coord)
    {
        Vector2 spawnPoint = new Vector2(Random.Range(rocketSpawnLeft, rocketSpawnRight), rocketSpawnDown);
        var rocket = Instantiate(rocketCrosshair, spawnPoint, Quaternion.identity, gameObject.transform);
        int rnd = Random.Range(0, Splashes.Count);
        rocket.GetComponent<RocketController>().FetchCoordinates(coord, Splashes[rnd]);
    }

}
