using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	public Vector2 jumpForce = new Vector2 (300, 0);
		
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("Pressed left click.");
			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			GetComponent<Rigidbody2D>().AddForce (jumpForce);
		}
		if (Input.GetMouseButtonDown (1))
			Debug.Log ("Pressed right click.");
		if (Input.GetMouseButtonDown (2))
			Debug.Log ("Pressed middle click.");

		//Muere cuando se sale de la pantalla
		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0)
		{
			Die();
		}
	}

	//Metodo que cuando colisiona muere
	void OnCollisionEnter2D(Collision2D other)
	{
		Die();
	}
	
	void Die()
	{
		Debug.Log ("Muere el player1------------------------------");
		Application.LoadLevel(Application.loadedLevel);
	}
}

