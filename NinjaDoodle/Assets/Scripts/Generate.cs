using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {

	public GameObject wall_left;
	public GameObject wall_right;

	// Use this for initialization
	void Start () {
		print ("Walls creating.");
		print ("Ancho de pantalla " + Screen.width);
		print ("Alto de pantalla " + Screen.height);
		InvokeRepeating ("CreatingWall", 1f, 0.65f);
	}
	
	void CreatingWall()
	{
		Instantiate (wall_left, new Vector3(Screen.width - Screen.width + 10 ,11.25f,0),  Quaternion.identity);	
		Instantiate (wall_right, new Vector3(Screen.width/2 ,11.25f,0),  Quaternion.identity);	

	}
}
