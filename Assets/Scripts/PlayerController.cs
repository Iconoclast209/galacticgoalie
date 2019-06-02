using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	
	public float speed;
	public float xMax;
	public float yMax;

	private AudioSource audioSource;
	private float h;
	private float v;

	// Use this for initialization
	void Start () 
	{
		audioSource = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update ()
	{
		MoveShip ();
	}


	void MoveShip ()
	{
		h = Input.GetAxis("Horizontal");
		v= Input.GetAxis("Vertical");
		transform.position += new Vector3(h*speed*Time.deltaTime,v*speed*Time.deltaTime,0f);

		// Restrict Player to game space
		float newX = Mathf.Clamp(transform.position.x,-xMax,xMax);
		float newY = Mathf.Clamp(transform.position.y,-yMax,yMax);
		transform.position = new Vector3(newX,newY,0f);
		/*
		float posX = Input.mousePosition.x/Screen.width;
		float posY = Input.mousePosition.y/Screen.height;
		transform.position = new Vector3(posX,posY,0f); */
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.CompareTag("Enemy"))
		{
			audioSource.Play();
		}
	}


}

