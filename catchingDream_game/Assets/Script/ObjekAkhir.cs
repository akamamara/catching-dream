using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjekAkhir : MonoBehaviour
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
			if(SceneManager.GetActiveScene().name == "Level 1")
				FindObjectOfType<EndGameManager>().Invoke("openPanel", 0.15f);
			else
				FindObjectOfType<EndGameManager>().Invoke("openPanel", 0.5f);
		}
	}
}
