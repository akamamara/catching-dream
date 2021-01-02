using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endGameObstacle : MonoBehaviour
{
	public float speed = 5;
	// Update is called once per frame
	private void Update()
	{
		transform.Translate(Vector2.down * speed * Time.deltaTime);
	}
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			FindObjectOfType<EndGameManager>().openPanel();
		}
	}
}
