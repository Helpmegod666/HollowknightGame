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
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            attackHitbox.SetActive(true);
            rangedWeapon.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            attackHitbox.SetActive(false);
            rangedWeapon.SetActive(true);
        }
    }
}
