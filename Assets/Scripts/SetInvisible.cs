using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInvisible : MonoBehaviour
{
    void Start()
    {

        GetComponent<SpriteRenderer>().enabled = false;
    }
}
