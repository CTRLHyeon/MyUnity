using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour      //장애물을 생성하는 오브젝트에 적용 시, 장애물을 랜덤한 위치에서 생성해내는 스크립트
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
        // 아래부터 프리팹을 만드는 스크립트
        if (newPos.x > 10)  //오차 범위에 생성 시 위치 조정
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
