using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float zoomspeed = 5.0f;
    public GameObject targetobject;
    public float rotatespeed = 10.0f;
    private Vector3 point;

    void Start()
    {
        point = targetobject.transform.position;
        transform.LookAt(point);
    }

    void Update()
    {
        //Rotate the Entire Camera around the relevant Object
        transform.RotateAround(point, new Vector3(0.0f, -1.0f, 0.0f), 20 * Time.deltaTime * rotatespeed);

        //Find the distance between starting and end points when zoom the camera
        float dist = Vector3.Distance(transform.position, point);


        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.position += transform.right * zoomspeed * Time.deltaTime;
        //}

        //if (Input.GetKey(KeyCode.LeftArrow))

        //{
        //    transform.position -= transform.right * zoomspeed * Time.deltaTime;

        //}

        //Zoom in and Zoom Out
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (dist > 1.5)
            {
                transform.position += transform.forward * zoomspeed * Time.deltaTime;
                //Debug.Log(dist);
            }

        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (dist < 7)
            {
                transform.position -= transform.forward * zoomspeed * Time.deltaTime;
                //Debug.Log(dist);
            }
        }
    }
}
