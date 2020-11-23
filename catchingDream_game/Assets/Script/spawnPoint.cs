using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPoint : MonoBehaviour
{
    public GameObject obstacle;
    
    // Update is called once per frame
    void Start()
    {
        Instantiate(obstacle, transform.position, Quaternion.identity);
    }
}
