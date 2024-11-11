using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStarter : MonoBehaviour
{

    public string sceneName;
    private void OnMouseDown()  //마우스로 클릭 시
    {
        SceneManager.LoadScene(sceneName);      //다른 씬 전환, sceneName public 변수를 통해 이름 지정
    }
}
