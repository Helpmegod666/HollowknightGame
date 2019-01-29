using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badEnemyScript : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(0f, -10f * Time.deltaTime, 0f);

        if (transform.position.y < -5)
        {
            transform.position = new Vector3(transform.position.x, 5f, transform.position.z);
        }
    }
}
