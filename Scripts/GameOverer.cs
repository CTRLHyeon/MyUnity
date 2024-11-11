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
        body.velocity = new Vector2(0, -10);
    }

    private void Update()
    {
        if (this.transform.position.y < -1)
        {
            Destroy(gameObject);
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
