using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class obstacle : MonoBehaviour
{
    public int damage = 15;
    public float speed = 5;
    private shake shake;
    
    public int score = -15;

    private void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<shake>();
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
            // Player take damage!
            shake.CamShake();
            other.GetComponent<player>().currentHealth -= damage;
            FindObjectOfType<scoreManager>().addScore(score);
            // Debug.Log(other.GetComponent<player>().currentHealth);
            Destroy(gameObject);
        }
    }
}
