using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplayAtEnd : MonoBehaviour {

	private Text scoreDisplay;
	// Use this for initialization
	void Start () {
		scoreDisplay = GetComponent<Text>();
		scoreDisplay.text = "your score was " + GameController.score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
