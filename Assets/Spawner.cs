using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject spawnee;
    public int count = 0;

    void Setup() {
        for (int i = 0; i < count; i++)
        {
            Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
        } 
    }

    // Update is called once per frame
    void Update()
    {        
        if(Input.GetMouseButton(0)) {
            Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
        } 
    }
}
