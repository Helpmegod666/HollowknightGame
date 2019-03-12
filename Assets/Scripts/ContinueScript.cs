using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueScript : MonoBehaviour
{
    
    public void Continue()
        {
        Time.timeScale = 1;
        PauseMenuScript.isPaused = false;
        
        }
}
