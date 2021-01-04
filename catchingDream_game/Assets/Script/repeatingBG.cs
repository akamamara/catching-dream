using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class repeatingBG : MonoBehaviour
{
	public float speed = 5;
	public float startY;
	public float endY;
	public countdownTimer countdownTimer;

	private void Start()
	{
		if (SceneManager.GetActiveScene().name == "Level 1")
			speed = 5;
		if (SceneManager.GetActiveScene().name == "Level 2")
			speed *= (float)1.25;
		if (SceneManager.GetActiveScene().name == "Level 3")
			speed *= (float)1.5;
	}

	// Update is called once per frame
	void Update()
	{
		transform.Translate(Vector2.down * speed * Time.deltaTime);
		if (transform.position.y <= endY)
		{
			Vector2 pos = new Vector2(transform.position.x, startY);
			transform.position = pos;
		}
	}
}
