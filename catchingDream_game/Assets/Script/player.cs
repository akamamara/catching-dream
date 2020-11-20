using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{	
	public float Xincrement;
	public float speed;
	public float maxWidth;
	public float minWidth;
	public int health = 5;

	private Vector2 targetPos;
	private void Update()
	{
		// Smooth Speed
		// transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
		if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < maxWidth)
		{
			targetPos = new Vector2(transform.position.x + Xincrement, transform.position.y);
			transform.position = targetPos;
		} else if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > minWidth)
		{
			targetPos = new Vector2(transform.position.x - Xincrement, transform.position.y);
			transform.position = targetPos;
		}
	}
}
