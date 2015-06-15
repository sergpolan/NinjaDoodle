using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {

	public GameObject walls;

	// Use this for initialization
	void Start () {
		print ("Walls creating.");
		InvokeRepeating ("CreatingWall", 1f, 0.65f);
	}
	
	void CreatingWall()
	{
		Instantiate (walls);
	}
}
