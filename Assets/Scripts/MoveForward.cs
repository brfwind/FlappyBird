using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float moveSpeed;
    private Vector2 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void FixedUpdate()
    {
        if(Mathf.Abs(startPos.x - transform.position.x) > 10)
        {
            Destroy(this.gameObject);
        }

        transform.position += transform.right * -1 * Time.deltaTime * moveSpeed;
    }
}
