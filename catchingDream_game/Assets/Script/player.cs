using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{	
	public GameObject KiriKananSFX;
	public float Xincrement;
	
	// public float speed = 5;
	public float maxWidth;
	public float minWidth;

	public int maxHealth = 100;
	public int currentHealth;
	public int lowInsanity = 4;
   	public HealthBar healthBar;
   	private AudioSource audioSource;

	private float timer;
	private Vector2 targetPos;

	private void Start()
    {
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
		audioSource = GetComponent<AudioSource>();	
		audioSource.Play();
    }

	public void destroyPlayer()
    {
		// Open game over panel
		FindObjectOfType<GameOverManager>().endGame();
		audioSource.Pause();

		// Destroy player object
		Destroy(gameObject);
	}
	private void Update()
	{
		// Smooth Speed
		// transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
		
		// Current Health condition
		if(currentHealth <= 0)
        {
			destroyPlayer();
		}

		if (currentHealth > 100)
		{
			currentHealth = 100;
		}
		
		// Player controller
		if ((Input.GetKeyDown(KeyCode.RightArrow) || SwipeManager.swipeRight) && transform.position.x < maxWidth)
		{
			Instantiate(KiriKananSFX, transform.position, Quaternion.identity);
			targetPos = new Vector2(transform.position.x + Xincrement, transform.position.y);
			transform.position = targetPos;
		} else if ((Input.GetKeyDown(KeyCode.LeftArrow) || SwipeManager.swipeLeft) && transform.position.x > minWidth)
		{
			Instantiate(KiriKananSFX, transform.position, Quaternion.identity);
			targetPos = new Vector2(transform.position.x - Xincrement, transform.position.y);
			transform.position = targetPos;
		}

		// Audio SFX behavior
		if(Time.timeScale == 0){
			audioSource.Pause();
		}
		if(Time.timeScale == 1){
			audioSource.UnPause();
		}
		
		// Sanity decrease over time
		healthBar.SetHealth(currentHealth);
		timer += Time.deltaTime;
		if(timer > 1)
        {
			currentHealth -= lowInsanity;
			timer = 0;
		}
	}
}
