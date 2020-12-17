using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peri : MonoBehaviour
{
	public int addSanity = 10;
	public float speed;

	public GameObject effect;
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
			//effect
			Instantiate(effect, transform.position, Quaternion.identity);

			// healing player
			other.GetComponent<player>().currentHealth += addSanity;
			// Debug.Log(other.GetComponent<player>().currentHealth);
			Destroy(gameObject);
		}
	}
}
