using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScirpt : MonoBehaviour
{
    public GameObject cherryprefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("e"))
        {
            Vector3 randomSpawnposition = new Vector3(Random.Range(-8, 8), (5), (0f));
            Instantiate(cherryprefab, transform.position, Quaternion.identity);
            
        }
    }

}
