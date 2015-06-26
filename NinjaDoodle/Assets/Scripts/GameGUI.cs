using UnityEngine;
using System.Collections;

public class GameGUI : MonoBehaviour {

	public int score = 0;
	public float offSetY = 7;
	public float sizeX = 80;
	public float sizeY = 25;
	public Font fontNormal;
	public int fontSize;
	private float heldTime = 0.0f;


	void Update()
	{
		heldTime += Time.deltaTime;
		if(heldTime >= 1){
			score += (int)heldTime;
			heldTime -= (int)heldTime;
		}
	}

	void OnGUI()
	{
		GUI.color = Color.white;
		GUI.skin.font = fontNormal;

		GUILayout.BeginArea( new Rect( Screen.width/2 - sizeX/2, offSetY, 200, 200 ) );
		GUILayout.BeginHorizontal();
		GUILayout.FlexibleSpace();
		GUILayout.Label(score.ToString());
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}
}
