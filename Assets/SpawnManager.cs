using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpawnManager : MonoBehaviour
{
    //  public GameObject Enemy;
    // public GameObject[] zombieePrefabs;
    public int number;
    public float spawnRadius;
    bool spawnOnStart = true;
    // Start is called before the first frame update
    void Start()
    {
        // CreateAllEnemies();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject temp = GameController.instance.GetObjectsFromPool("Enemy");
        if (temp != null)
        {
          //  Vector3 randompoint = transform.position + Random.insideUnitSphere * spawnRadius;
           // NavMeshHit hit;
           // if (NavMesh.SamplePosition(randompoint, out hit, 10f, NavMesh.AllAreas))
            {
                Debug.Log("active");
              //  Debug.Log(randompoint);
                if (Random.Range(0, 100) < 1f)
                {

                    temp.transform.position = temp.transform.position +new Vector3(Random.Range(80f,1f),1f,Random.Range(80f,2f));
                    temp.SetActive(true);
                }
            }

        }
    }
}
 
    

