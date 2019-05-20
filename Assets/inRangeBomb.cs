using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inRangeBomb : MonoBehaviour
{
    EnemySense sense;
    public AudioSource tick;
    // Start is called before the first frame update
    void Start()
    {
        sense = GetComponent<EnemySense>();
    }

    // Update is called once per frame
    void Update()
    {
        if(sense.Area == true)
        {
            tick.Play();
        }
    }
}
