using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveAmmo : MonoBehaviour
{
    public RangedAttacksScript ammo;
    public int ammoToGive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Giveammo()
    {
        ammo.ammo += ammoToGive;
    }
    
            
}
