using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject newPrefab;
    public float intervalSec = 1;
    void Start()
    {
        InvokeRepeating("CreatePrefab", intervalSec, intervalSec);
    }

    void CreatePrefab()
    {
        Vector3 area = GetComponent<SpriteRenderer>().bounds.size;

        Vector3 newPos = this.transform.position;
        newPos.x += Random.Range(-area.x, area.x);
        newPos.y = this.transform.position.y;
        newPos.z = -5;
        //프리팹을 만든다
        if (newPos.x > 10)
        {
            newPos.x -= 10;
        }
        else if (newPos.x < -10)
        {
            newPos.x += 10;
        }
        GameObject newGameObject = Instantiate(newPrefab) as GameObject;
        newGameObject.transform.position = newPos;
    }
}
