using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawnerEndGame : MonoBehaviour
{
	public GameObject[] objekTerakhir;

	// Update is called once per frame
	public void spawnEndGame()
	{
		// Spawn object
		if(SceneManager.GetActiveScene().name == "Level 1")
			Instantiate(objekTerakhir[0], transform.position, Quaternion.identity);
		else if(SceneManager.GetActiveScene().name == "Level 2")
			Instantiate(objekTerakhir[1], transform.position, Quaternion.identity);
		else if (SceneManager.GetActiveScene().name == "Level 3")
			Instantiate(objekTerakhir[2], transform.position, Quaternion.identity);
	}
}
