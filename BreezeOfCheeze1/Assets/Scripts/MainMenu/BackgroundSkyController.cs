using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSkyController : MonoBehaviour
{
    Material material;
    Vector2 offset;

    public float yVelocity;

    void Awake()
    {
        material = GetComponent<Renderer>().material;
        offset = new Vector2(0, yVelocity);
    }

    void Update()
    {
        offset = new Vector2(0, yVelocity);
        material.mainTextureOffset += offset * Time.deltaTime;
    }
}
