using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Rotate_Object : MonoBehaviour
{
    public float speed=2f;

    public float rotatespeede = -0.1f;

    private Vector2 TouchPosition;

    private Touch touch;

    private Quaternion rotationY;

    public float rotatespeed = 10f;
    private float startingPosition;


    void Start()
    {
        
    }

   
    void Update()
    {

        /*transform.Rotate(0, -90 * speed, 0);
         * 
         * 
         * 
*/


        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    startingPosition = touch.position.x;
                    break;
                case TouchPhase.Moved:
                    if (startingPosition > touch.position.x)
                    {
                        transform.Rotate(Vector3.back, -rotatespeed * Time.deltaTime);
                    }
                    else if (startingPosition < touch.position.x)
                    {
                        transform.Rotate(Vector3.back, rotatespeed * Time.deltaTime);
                    }
                    break;
                case TouchPhase.Ended:
                    Debug.Log("Touch Phase Ended.");
                    break;
            }
        }

       /* if (Input.touchCount > 0)
         {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                rotationY = Quaternion.Euler(0f, -touch.deltaPosition.x * rotatespeede, 0f);

                transform.rotation = rotationY * transform.rotation;
            }
         }*/

/*#if UNITY_EDITOR
        if (Input.GetMouseButtonDown(0))
        {
            

            if (touch.phase == TouchPhase.Moved)
            {
                rotationY = Quaternion.Euler(0f, -touch.deltaPosition.x * rotatespeed, 0f);

                transform.rotation = rotationY * transform.rotation;
            }
        }
#endif*/

    }
    
}

