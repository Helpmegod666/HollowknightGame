using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{

    public RectTransform self;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
      
        
        
    }

    // Update is called once per frame
    void Update()
    {
        self.position = new Vector3(self.position.x + speed, self.position.y);
    }
}
