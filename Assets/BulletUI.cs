using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BulletUI : MonoBehaviour
{
    TextMeshProUGUI text;
    public RangedAttacksScript bullets;
    public Color noAmmo;
    Color hasAmmo;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        hasAmmo = text.faceColor;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = string.Format("Bullets left: {0}", bullets.ammo);
        if(bullets.ammo == 0)
        {
            text.color = noAmmo;
        }
        if(bullets.ammo > 0)
        {
            text.color = hasAmmo;
        }
    }

}
