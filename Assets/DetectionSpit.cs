using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionSpit : MonoBehaviour
{
    public bool detected = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
           detected = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            detected = false;
        }
    }
}
