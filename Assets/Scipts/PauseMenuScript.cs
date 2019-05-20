using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuScript : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pauseMenu;
    void Start()
    {
        pauseMenu.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Pause"))
        {
            if(isPaused == false)
            {
                Time.timeScale = 0;
                isPaused = true;
                pauseMenu.SetActive(true);
            }
        }
        if(isPaused == false)
        {
            pauseMenu.SetActive(false);
        }
      
    }
}
