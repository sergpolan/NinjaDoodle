using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {

	public GameObject wall_left;
	public GameObject wall_right;
	public GameObject player;
	Vector3 v3WallLeft = new Vector3(0.01f, 1.2f, 1);
	Vector3 v3WallRight = new Vector3(0.99f, 1.2f, 1);
	Vector3 v3Player = new Vector3(0.5f, 0.5f, 1);

	// Use this for initialization
	void Start () {
		print ("Walls creating.");
		print ("Ancho de pantalla " + Screen.width);
		print ("Alto de pantalla " + Screen.height);
		Invoke ("CreatingPlayer", 0.5f);
		InvokeRepeating ("CreatingWall", 1f, 0.6f);
	}
	
	void CreatingWall()
	{
		print ("Creando el muro");
		Instantiate (wall_left, Camera.main.ViewportToWorldPoint (v3WallLeft), Quaternion.identity);
		Instantiate (wall_right, Camera.main.ViewportToWorldPoint (v3WallRight), Quaternion.identity);
	}

	void CreatingPlayer()
	{
		print ("Creando el personaje");
		Instantiate (player, Camera.main.ViewportToWorldPoint (v3Player), Quaternion.identity);

	}
}
