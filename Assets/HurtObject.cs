using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HurtObject : MonoBehaviour
{
    
    public string load = "Level 2";


    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.tag == "Player") 
        {
            
            print("You died"); 
            
            SceneManager.LoadScene(load); 
        }
    }
}
