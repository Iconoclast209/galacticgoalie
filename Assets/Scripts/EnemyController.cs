using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	public float enemyMovementSpeed;
	public float enemyTorqueSpeed;

	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		rb.AddForce(Vector2.up*enemyMovementSpeed);
		rb.AddTorque(enemyTorqueSpeed);
	}
	
	// Update is called once per frame
	void Update ()
	{
		MoveShip();
	}


	void MoveShip ()
	{
		rb.AddForce(Vector2.up*enemyMovementSpeed);
	}



}
