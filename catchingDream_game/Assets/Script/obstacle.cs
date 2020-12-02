using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    public int damage = 15;
    public float speed;
    public Animator camAnim;

    private void Start()
    {
        camAnim = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
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
            camAnim.SetTrigger("shake"); 
            other.GetComponent<player>().currentHealth -= damage;
            Debug.Log(other.GetComponent<player>().currentHealth);
            Destroy(gameObject);
        }
    }
}
