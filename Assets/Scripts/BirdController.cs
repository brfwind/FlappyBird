using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    private Vector2 startPos;
    public float floatSpeed;
    public float floatA;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed) * floatA;

        transform.position = new Vector2(startPos.x,newY);
    }
}
