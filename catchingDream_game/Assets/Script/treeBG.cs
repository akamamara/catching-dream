﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeBG : MonoBehaviour
{
	public float speed;

	private void Update()
	{
		transform.Translate(Vector2.down * speed * Time.deltaTime);
	}
}
