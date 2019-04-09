using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashUI : MonoBehaviour
{
    public DashMovement dash;
    public Sprite fullDash;
    public Sprite usedDash;
    SpriteRenderer icon;
    private void Start()
    {
        icon = GetComponent<SpriteRenderer>();
        icon.enabled = true;
    }
    private void Update()
    {
        if(dash.dashes >= 1)
        {
            icon.sprite = fullDash;
        }
        if(dash.dashes <= 0)
        {
            icon.sprite = usedDash;
        }
    }
}
