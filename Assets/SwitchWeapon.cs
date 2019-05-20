using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWeapon : MonoBehaviour
{
    public GameObject attackHitbox;
    public GameObject rangedWeapon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetButtonDown("Swap"))
        {
            if(attackHitbox.activeSelf == true)
            {
                attackHitbox.SetActive(false);
                rangedWeapon.SetActive(true);
            }
            else if (attackHitbox.activeSelf == false)
            {
                attackHitbox.SetActive(true);
                rangedWeapon.SetActive(false);
            }
        }
    }
}
