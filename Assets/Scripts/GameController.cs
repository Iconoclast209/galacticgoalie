using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

 	public static int score = 0;
 	public static int highScore;
	public LevelManager levelManager;
	public Text scoreText;

	// Use this for initialization
	void Start () {
		StartRound();
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "score: " + score.ToString();
	}

	public void EndRound ()
	{
		//Check for new High Score
		if (PlayerPrefs.HasKey ("highestScore")) 
		{
			highScore = PlayerPrefs.GetInt ("highestScore");
			Debug.Log("A high score already exists");
			if (highScore < score) 
			{
				PlayerPrefs.SetInt ("highestScore", score);
				Debug.Log("New High Score Set at " + score);
			}
		} 
		else 
		{
			PlayerPrefs.SetInt ("highestScore", score);
			Debug.Log("Initial High Score Set at " + score);
		}

		levelManager.LoadLevel("lose");
	}

	public void StartRound ()
	{
		score = 0;
	}
}

/*
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class DataController : MonoBehaviour {

	private RoundData[] allRoundData;

	private PlayerProgress playerProgress;
	private string gameDataFileName = "data.json";

	void Start () 
	{
		DontDestroyOnLoad(gameObject);
		LoadGameData();
		LoadPlayerProgress();

		SceneManager.LoadScene("Menu");
	}

	public RoundData GetCurrentRoundData ()
	{
		return allRoundData[0];
	}

	public void SubmitNewPlayerScore (int newScore)
	{
		if (newScore > playerProgress.highestScore) 
		{
			playerProgress.highestScore = newScore;
			SavePlayerProgress();
		}
	}

	public int GetHighestPlayerScore ()
	{
		return playerProgress.highestScore;
	}

	void LoadPlayerProgress()
	{
		playerProgress = new PlayerProgress();

		if(PlayerPrefs.HasKey("highestScore"))
		{
			playerProgress.highestScore = PlayerPrefs.GetInt("highestScore");
		}
	}

	void SavePlayerProgress()
	{
		PlayerPrefs.SetInt("highestScore", playerProgress.highestScore);
	}

	void LoadGameData ()
	{
		string filePath = Path.Combine (Application.streamingAssetsPath, gameDataFileName);

		if (File.Exists (filePath)) {
			string dataAsJson = File.ReadAllText (filePath);
			GameData loadedData = JsonUtility.FromJson<GameData> (dataAsJson);
			allRoundData = loadedData.allRoundData;
		} 
		else 
		{
			Debug.LogError("Cannot load game data.");
		}



	}



}
*/