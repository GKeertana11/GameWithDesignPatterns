using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam=GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit Hitinfo;
            Vector3 point = new Vector3(cam.pixelWidth / 2, cam.pixelHeight / 2, 0);
            Ray ray = cam.ScreenPointToRay(point);
            if (Physics.Raycast(ray.origin, ray.direction, out Hitinfo))
            {
                Debug.Log(Hitinfo);
                Debug.Log("hit");
                if (Hitinfo.transform.tag == "Enemy")
                {
                    Debug.Log(Hitinfo);
                    Debug.Log(tag);
                    //  Destroy(Hitinfo.transform.gameObject);
                    Hitinfo.transform.gameObject.SetActive(false);
                    Debug.Log("Destroyed");
                }



            }
        }
    }
}
