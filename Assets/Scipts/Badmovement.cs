using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Badmovement : MonoBehaviour
{
    //public Transform spawnPoint;
    void Update()
    {
        //spawnPoint.position

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(2f * Time.deltaTime, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-2f * Time.deltaTime, 0f, 0f);
        }
    }
}
