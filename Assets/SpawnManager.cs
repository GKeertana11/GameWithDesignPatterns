using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpawnManager : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        GameObject temp = GameController.instance.GetObjectsFromPool("Enemy");
        if (temp != null)
        {
         
                if (Random.Range(0, 100) < 1f)
                {

                    temp.transform.position = temp.transform.position +new Vector3(Random.Range(80f,1f),1f,Random.Range(80f,2f));
                    temp.SetActive(true);
                }
            }

        }
    }

 
    

