using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverer : MonoBehaviour
{
    Rigidbody2D body;
    public string TargetObjectName;
    public string sceneName;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        body.velocity = new Vector2(0, -10);    //오브젝트는 생성 시 -10의 y성분을 가짐
    }

    private void Update()
    {
        if (this.transform.position.y < -1)     //오브젝트의 좌표가 -1 이하일 시
        {
            Destroy(gameObject);                //해당 오브젝트 제거
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == TargetObjectName)
        {
            SceneManager.LoadScene(sceneName);
            Time.timeScale = 0;             //TargetObjectName에 충돌하면 게임 정지
            
        }
    }
}
