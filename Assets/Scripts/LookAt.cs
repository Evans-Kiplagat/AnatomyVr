using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public float speed = 10f;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);

        Vector3 Distance = target.position - this.transform.position;
        Distance *= speed;
        Distance *= Time.deltaTime;

       transform.Translate(Distance,Space.World);
    }
}
