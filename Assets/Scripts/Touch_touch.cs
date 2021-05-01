using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch_touch : MonoBehaviour
{
    public GameObject gObj = null;
   Ray GenerateMouse()
    {
        Vector3 mouseFar = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.farClipPlane);
        Vector3 mouseNear = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane);

        Vector3 mousePosFar = Camera.main.ScreenToWorldPoint(mouseFar);
        Vector3 mousePosNear = Camera.main.ScreenToWorldPoint(mouseNear);

        Ray ray = new Ray(mousePosNear, mousePosFar - mousePosNear);

        
        return ray;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray MousePos =  GenerateMouse();
            RaycastHit Hit;
             if(Physics.Raycast(MousePos.origin,MousePos.direction, out Hit))
            {
                gObj = Hit.transform.gameObject;
            }

        } else if(Input.GetMouseButton(0) && gObj)
        {
            Vector3 newPOS = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            gObj.transform.position = new Vector3(newPOS.x, newPOS.y, gObj.transform.position.z);
        }
        else if (Input.GetMouseButtonUp(0) && gObj) {
            gObj = null;
        }
    }
}
