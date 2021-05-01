using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinchAmount : MonoBehaviour
{
    public float pinchStartDistance;
    public float Speed = 1.0f;
    public float pinFinshDistance;
    public float difference;

    

    void Update()
    {
        if (Input.touchCount == 2 && (Input.GetTouch(0).phase == TouchPhase.Began
            || Input.GetTouch(1).phase == TouchPhase.Began))
        {
            pinchStartDistance = Vector2.Distance(Input.GetTouch(0).position, Input.GetTouch(1).position);

        }
        else if (Input.touchCount == 2 && (Input.GetTouch(0).phase == TouchPhase.Moved || Input.GetTouch(1).phase == TouchPhase.Moved))
        {
            pinFinshDistance = Vector2.Distance(Input.GetTouch(0).position, Input.GetTouch(1).position);
        }
        difference = pinFinshDistance - pinchStartDistance;

        /*if (this.gameObject.transform.position.z < )
        {

        }*/
        Camera.main.transform.Translate(0, 0, difference * Speed * Time.deltaTime);


        pinchStartDistance = pinFinshDistance;

    }
}



    


