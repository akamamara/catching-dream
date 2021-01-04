using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class treeBG : MonoBehaviour
{
	public float speed = 5;
    private void Start()
    {
        if(SceneManager.GetActiveScene().name == "Level 1")
            speed = 5;
        if (SceneManager.GetActiveScene().name == "Level 2")
            speed *= (float)1.25;
        if (SceneManager.GetActiveScene().name == "Level 3")
            speed *= (float)1.5;
    }

    private void Update()
	{
		transform.Translate(Vector2.down * speed * Time.deltaTime);
	}
}
