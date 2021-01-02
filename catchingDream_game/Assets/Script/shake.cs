using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shake : MonoBehaviour
{
    public GameObject GetarSFX;
    public Animator camAnim;
    public void CamShake()
    {
    	Instantiate(GetarSFX, transform.position, Quaternion.identity);
        camAnim.SetTrigger("shake");
    }
}
