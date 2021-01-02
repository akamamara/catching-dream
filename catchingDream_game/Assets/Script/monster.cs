using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster : MonoBehaviour
{
	//public GameObject BloodEffect;
	public GameObject[] BloodAnim;
	public GameObject BiteSFX;
	public float speed;

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

	private void Update()
	{
		transform.Translate(Vector2.down * speed * Time.deltaTime);
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			//Instantiate(BloodEffect, transform.position, Quaternion.identity);
			Instantiate(BiteSFX, transform.position, Quaternion.identity);
			// Player take damage!
			other.GetComponent<player>().currentHealth = 0;
			other.GetComponent<player>().destroyPlayer();
			// Debug.Log(other.GetComponent<player>().currentHealth);
			// Destroy(gameObject);
		}
	}
}
