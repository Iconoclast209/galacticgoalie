using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public GameObject[] enemies;
	public float spawnXMax;
	public float spawnYPosition;
	public float timeBetweenSpawns;

	private float timeSinceLastSpawn = 0f;



	void Update ()
	{
		timeSinceLastSpawn += Time.deltaTime;
		if (timeSinceLastSpawn >= timeBetweenSpawns) 
		{
			SpawnEnemy();
			timeSinceLastSpawn = 0f;
		}

	}

	void SpawnEnemy ()
	{
		int enemiesIndex = Random.Range(0,enemies.Length);
		float spawnXPosition = Random.Range(-spawnXMax,spawnXMax);
		Vector3 spawnPosition = new Vector3(spawnXPosition, spawnYPosition,0f);
		Instantiate(enemies[enemiesIndex], spawnPosition, Quaternion.identity);
	}

}
