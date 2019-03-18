using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour {

	public float timeLeft = 30.0f;
	public Text startText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		startText.text = (timeLeft).ToString("0");
		if (timeLeft <= 5)
		{
			//Do something useful or Load a new game scene depending on your use-case
			startText.color = Color.red;
		}

		if (timeLeft < 1) {
			//timeLeft = 0;
			startText.text = "Time Up!";
			Time.timeScale = 0;
		}
	}
}
