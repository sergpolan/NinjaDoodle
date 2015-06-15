using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {

	public Vector2 velocity = new Vector2(0, -4);

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().velocity = velocity;
	}

}
