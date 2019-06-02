using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMover : MonoBehaviour {

	
	public float initialMeteorMovementSpeed;
	public float meteorMovementSpeed;
	public float torqueSpeed;
	public GameObject explosion;

	private ParticleSystem ps;
	private Rigidbody2D rb;
	private GameController gc;
	private AudioSource audioSource;
	private GameObject gameController;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		gameController = GameObject.FindGameObjectWithTag("GameController");
		gc = gameController.GetComponent<GameController>();
		audioSource = gameController.GetComponent<AudioSource>();
		rb.AddForce(Vector2.left*initialMeteorMovementSpeed);
		rb.AddTorque(torqueSpeed);
	}
	
	// Update is called once per frame
	void Update ()
	{
		MoveMeteor();
	}


	void MoveMeteor ()
	{
		rb.AddForce(Vector2.left*meteorMovementSpeed);

	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.CompareTag("Player"))
		{
			DestroyObject(col.gameObject);
			audioSource.Play();
			PlayExplosionEffect();
			Invoke("CallRoundEnd",1.0f);
		}
	} 

	void CallRoundEnd ()
	{
		gc.EndRound();
	}

	void PlayExplosionEffect ()
	{
		GameObject explosionEffect = Instantiate(explosion,this.transform.position,Quaternion.identity) as GameObject;
		ps = explosionEffect.GetComponent<ParticleSystem>();
		ps.Play();
	}


}
