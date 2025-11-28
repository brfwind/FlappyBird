using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float lastOffsetY;
    public GameObject spawnObject;

    void Start()
    {
        StartCoroutine(startPush());
    }

    void Update()
    {
        if(BirdController.isDead)
        {
            StopCoroutine(startPush());
        }
    }

    IEnumerator startPush()
    {
        yield return new WaitUntil(() => UIManager.isStart);

        InvokeRepeating("Spawn",0f,Random.Range(2f,2f));
    }

    private void Spawn()
    {
        float offsetY = Random.Range(-2.41f,2.18f);

        while(Mathf.Abs(lastOffsetY - offsetY) > 3 || Mathf.Abs(lastOffsetY - offsetY) < 1)
        {
            offsetY = Random.Range(-2.41f,2.18f);
        }

        lastOffsetY = offsetY;

        Vector3 position = new Vector3(transform.position.x,transform.position.y + offsetY,0);

        Instantiate(spawnObject,position,Quaternion.identity,transform);
    }
}
