using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehaviour
{
    public float lifetime;

    // Update is called once per frame
    void Start()
    {
        Destroy(gameObject, lifetime);
    }
}
