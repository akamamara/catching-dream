using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    public int damage = 15;
    public float speed;
    private shake shake;

    private void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<shake>();
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
            Debug.Log(other.GetComponent<player>().currentHealth);
            Destroy(gameObject);
        }
    }
}
