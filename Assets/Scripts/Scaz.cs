using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaz : MonoBehaviour
{

    [SerializeField] GameObject target; //target moving object
    private Touch oldTouch1; //Last touch point 1 (finger 1)  
    private Touch oldTouch2; //Last touch point 2 (finger 2)  
    private float eulerAngles_x;
    private float eulerAngles_y;


    //Horizontal scroll related

    public float xSpeed​​= 5.0f;    //main camera horizontal rotation speed
    
    //Vertical scrolling related

    public int yMaxLimit = 90;          // aximum y(unit is the angle)
    public int yMinLimit = -90;         //minimum y (unit is angle)  
    public float ySpeed= 10.0f;             //main camera longitudinal rotation speed

    void Start()
    {
        Vector3 eulerAngles = this.transform.eulerAngles;//The Euler angle of the current object  
        this.eulerAngles_x = eulerAngles.y;
        this.eulerAngles_y = eulerAngles.x;
    }


    void Update()
    {
        //No touch  
        if (Input.touchCount <= 0)
        {
            return;
        }
                 // single touch, horizontal up and down rotation

        if (1 == Input.touchCount)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 deltaPos = touch.deltaPosition;

            //No dead angle rotation
            //transform.RotateAround(target.transform.position, Vector3.up, deltaPos.x);
            //transform.RotateAround(target.transform.position, -1 * transform.right, deltaPos.y);

            float sum = Vector3.Distance(this.transform.position, target.transform.position);

            if (this.target != null)
            {
                this.eulerAngles_x += ((deltaPos.x * this.xSpeed) * sum) * 0.005f;
                this.eulerAngles_y -= (deltaPos.y * this.ySpeed) * 0.005f;
                this.eulerAngles_y = ClampAngle(this.eulerAngles_y, (float)this.yMinLimit, (float)this.yMaxLimit);
                Quaternion quaternion = Quaternion.Euler(this.eulerAngles_y, this.eulerAngles_x, (float)0);
                Vector3 vector = ((Vector3)(quaternion * new Vector3((float)0, (float)0, -sum))) + this.target.transform.position;
                                 
                // Change the rotation angle and position of the main camera
                this.transform.rotation = quaternion;
                this.transform.position = vector;
            }

        }

        //Multiple touch, zoom in and out  
        Touch newTouch1 = Input.GetTouch(0);
        Touch newTouch2 = Input.GetTouch(1);

        //The second point is just touching the screen, only recording, no processing  
        if (newTouch2.phase == TouchPhase.Began)
        {
            oldTouch2 = newTouch2;
            oldTouch1 = newTouch1;
            return;
        }

                
        // Calculate the old two - point distance and the new distance between the two points, become larger to enlarge the model, become smaller to scale the model
        float oldDistance = Vector2.Distance(oldTouch1.position, oldTouch2.position);
        float newDistance = Vector2.Distance(newTouch1.position, newTouch2.position);

                 
        // The difference between the two distances, positive for the zoom gesture, negative for the zoom gesture
        float offset = newDistance - oldDistance;
        // DebugUtil.log("distance between objects:" + Vector3.Distance(this.transform.position, target.transform.position));
        if (offset > 0 && Vector3.Distance(this.transform.position, target.transform.position) > 4)
        {

            transform.Translate(Vector3.forward * 0.1f);
        }
        if (offset < 0 && Vector3.Distance(this.transform.position, target.transform.position) < 10)
        {
            transform.Translate(Vector3.forward * -0.1f);
        }

        //Remember the latest touch points, next time  
        oldTouch1 = newTouch1;
        oldTouch2 = newTouch2;
    }

         // Limit the angle to a given range

    public float ClampAngle(float angle, float min, float max)
    {
        while (angle < -360)
        {
            angle += 360;
        }

        while (angle > 360)
        {
            angle -= 360;
        }
        return Mathf.Clamp(angle, min, max);

    }
}

