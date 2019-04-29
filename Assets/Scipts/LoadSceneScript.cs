using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneScript : MonoBehaviour
{
    public string sceneToLoad;
    public void LoadScene()
    {
        PauseMenuScript.isPaused = false;
        SceneManager.LoadScene(sceneToLoad);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
