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
		InvokeRepeating ("CreatingWall", 1f, 0.6f);
	}

	void Update()
	{
		print (Camera.main.ScreenToViewportPoint(Input.mousePosition));
		//Instantiate (wall_left, Camera.main.ScreenToViewportPoint(Input.mousePosition),  Quaternion.identity);
	}
	
	void CreatingWall()
	{

		print ("Creando");
		Instantiate (wall_left, new Vector3(-4,13,-1),  Quaternion.identity);	
		Instantiate (wall_right, new Vector3(4,13,-1),  Quaternion.identity);	
	}
}
