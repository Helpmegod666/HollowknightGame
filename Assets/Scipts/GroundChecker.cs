using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
   




    public JumpFeedback feedback;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            
            feedback.Shake(0.01f,0.1f);
        }

    }
}
