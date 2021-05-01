using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using EasyUI.Dialogs;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ObjectHit : MonoBehaviour
{
    float r = 25;
    float g = 159;
    float b = 180;

    public Object[] allObjects;
    public GameObject gameObjectt;
    public string names;
   /* public TextMeshProUGUI txt;*/
    public Text txt;
    public Touch tuch;

    private void Start()
    {
        allObjects = FindObjectsOfType<GameObject>();
       
    }

    void Update()
    {
        if (!EventSystem.current.IsPointerOverGameObject(tuch.fingerId)) {

            if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
            {
                Ray rayy = Camera.main.ScreenPointToRay(Input.touches[0].position);
                RaycastHit hit;

                if (Physics.Raycast(rayy, out hit))
                {



                    if (hit.collider != null)
                    {

                        foreach (GameObject all in allObjects)
                        {
                            if (hit.collider.gameObject == all)
                            {
                                /* Debug.Log(all.name);*/
                                /* txt.text = all.name;*/
                                DialogUI.Instance
            .SetTitle("Message 1")
            .SetMessage(txt.text = all.name)
            .SetButtonColor(DialogButtonColor.Blue)
            .OnClose(() => Debug.Log("Closed 1"))
            .Show();
                            }
                            Color newCl = new Color(r, g, b);
                            hit.collider.GetComponent<MeshRenderer>().material.color = newCl;

                        }

                    }



                }
            }
        }

#if UNITY_EDITOR


        if (!EventSystem.current.IsPointerOverGameObject())
        {
            if (Input.GetMouseButtonDown(0))
            {

                Ray rayy = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(rayy, out hit))
                {

                    if (hit.collider != null)
                    {

                        foreach (GameObject all in allObjects)
                        {
                            if (hit.collider.gameObject == all)
                            {
                                /* Debug.Log(all.name);*/
                                /*  txt.text = all.name;*/
                                DialogUI.Instance
           .SetTitle("The Name part is!!")
           .SetMessage(txt.text = all.name)
           .SetButtonColor(DialogButtonColor.Magenta)
           .OnClose(() => Debug.Log("Closed 1"))
           .Show();
                            }
                            Color newCl = new Color(r, g, b);
                            hit.collider.GetComponent<MeshRenderer>().material.color = newCl;

                        }

                    }
                }
            }
        }
#endif
    }
}
