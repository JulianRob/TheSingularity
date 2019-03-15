﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser2 : MonoBehaviour {

	private Rigidbody2D rb2d;
	public int direction = 0;

	// Use this for initialization
	void Start ()
	{
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (direction == 0) 
		{
			rb2d.velocity = new Vector2 (-15f, 0f);
		} 
		else
		{
			rb2d.velocity = new Vector2 (15f, 0f);
		}

		if (gameObject.transform.position.x <= -12)
		{
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Shine")
		{
			direction = 1;
		}
	}
}
