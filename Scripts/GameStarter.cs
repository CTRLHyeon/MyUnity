using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStarter : MonoBehaviour
{

    public string sceneName;
    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
    }
}
