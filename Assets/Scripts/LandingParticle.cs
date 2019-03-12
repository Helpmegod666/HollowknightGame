using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandingParticle : MonoBehaviour
{
    [SerializeField]
    GameObject Dirt;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag.Equals("Ground"))
            {
            Instantiate(Dirt, transform.position, Dirt.transform.rotation);
            }
        }
}
