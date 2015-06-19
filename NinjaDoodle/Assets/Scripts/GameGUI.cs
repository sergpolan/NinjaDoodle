using UnityEngine;
using System.Collections;

public class GameGUI : MonoBehaviour {

	public int score = 0;
	public float offSetY = 7;
	public float sizeX = 80;
	public float sizeY = 25;

	void Update()
	{
		score++;
	}

	void OnGUI()
	{
		GUI.color = Color.white;
		GUI.Box (new Rect(Screen.width/5, offSetY, sizeX, sizeY), "Score: " + score);
	}
}
