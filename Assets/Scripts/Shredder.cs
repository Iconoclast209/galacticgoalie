﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shredder : MonoBehaviour 
{

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.CompareTag("Enemy"))
		{
			Destroy(col.gameObject);
			GameController.score++;
		}
	}
}
