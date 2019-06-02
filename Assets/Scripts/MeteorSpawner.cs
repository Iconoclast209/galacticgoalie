using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour {

	public GameObject[] meteor;
	public float spawnYMax;
	public float spawnXPosition;
	public float timeBetweenSpawns;

	private float timeSinceLastSpawn = 0f;



	void Update ()
	{
		timeSinceLastSpawn += Time.deltaTime;
		if (timeSinceLastSpawn >= timeBetweenSpawns) 
		{
			SpawnMeteor();
			timeSinceLastSpawn = 0f;
		}

	}

	void SpawnMeteor ()
	{
		int meteorIndex = Random.Range (0, meteor.Length);
		float spawnYPosition = Random.Range (-spawnYMax, spawnYMax);
		Vector3 spawnPosition = new Vector3 (spawnXPosition, spawnYPosition, 0f);
		Instantiate(meteor[meteorIndex], spawnPosition, Quaternion.identity);
	}

}
