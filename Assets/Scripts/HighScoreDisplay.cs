using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreDisplay : MonoBehaviour {

	private Text highScoreDisplay;

	void Start () 
	{
		highScoreDisplay = GetComponent<Text>();
		highScoreDisplay.text = "highest score " + PlayerPrefs.GetInt("highestScore").ToString();
	}


}
