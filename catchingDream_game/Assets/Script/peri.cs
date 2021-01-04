using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class peri : MonoBehaviour
{
	public int addSanity = 10;
	public float speed = 5;
	
	public GameObject effect;
	public GameObject PeriEffectSound;
	
	public int score = 10;
    /* private Animator anim;
	public GameObject[] ObjectToAnimate;
	public float TimeToAnimate;
	private void Start ()
	{	for (int i = 0; i < ObjectToAnimate.Length; i++)
		{
		 anim = ObjectToAnimate[i].GetComponent<Animator>();
		}
	
		anim.enabled = false;
		StartCoroutine(Ahead());
    	}
    	
   	
	// Update is called once per frame
	IEnumerator Ahead()
	{
		yield return new WaitForSeconds(TimeToAnimate);
		anim.enabled = true;
	} */
    private void Start()
    {
		if (SceneManager.GetActiveScene().name == "Level 1")
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

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			//Sound Effect
			Instantiate(PeriEffectSound, transform.position, Quaternion.identity);
			
			//effect
			Instantiate(effect, transform.position, Quaternion.identity);
			FindObjectOfType<scoreManager>().addScore(score);

			// healing player
			other.GetComponent<player>().currentHealth += addSanity;
			// Debug.Log(other.GetComponent<player>().currentHealth);
			Destroy(gameObject);
		}
	}
}
