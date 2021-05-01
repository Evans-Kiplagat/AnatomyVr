using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestrictScrol : MonoBehaviour
{
    public Rect rect;
    public float MaxUp;
    public float MinDown;


    
    void Start()
    {
        MaxUp = 1000f;
        MinDown = -2f;
    }
     void Update()
    {
        MaxUp = rect.y;
        MinDown = rect.y;

        
    }
}
