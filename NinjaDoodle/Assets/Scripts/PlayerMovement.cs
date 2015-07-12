using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	public Vector2 jumpForce;
	private Animator animator;
	private bool moveRight = true;
	private GameObject lastWallHitted;
	public float jumpX = 10;
	public float jumpY = 7.5f;
		
	void Start()
	{
		animator = GetComponent<Animator>();
	}

	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("Pressed left click.");
			playerJump();
			GetComponent<Rigidbody2D> ().gravityScale = 1;
		}
		//if (Input.GetMouseButtonDown (1)) {
		//	Debug.Log ("Pressed right click.");
		//	animator.SetBool("glide", true);
		//}
		if (Input.GetMouseButtonDown (1)) {
			Debug.Log ("Pressed right click.");
		}
		if (Input.GetMouseButtonDown (2)) {
			Debug.Log ("Pressed middle click.");
		}

		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0)
		{
			Die();
		}
	}

	//Metodo que cuando colisiona muere
	void OnCollisionEnter2D(Collision2D other)
	{
		GetComponent<Rigidbody2D> ().gravityScale = 0.1f;
		if (other.gameObject.tag == "WallIdle") {
			GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
			if(lastWallHitted != null)
					lastWallHitted.SetActive (true);
			lastWallHitted = other.gameObject;
			lastWallHitted.SetActive (false);
			flipAnimation ();
			print ("Choco con el muro que no se mueve");
		}
		
	}
	
	void Die()
	{
		Debug.Log ("Muere el player1------------------------------");
		NotificationCenter.DefaultCenter ().PostNotification (this, "DeadPlayerGameOver");

		//Application.LoadLevel(Application.loadedLevel);
	}

	//Añade una fuerza al personaje dependiendo de si el personaje se
	// tiene que mover a la derecha o a la izquierda, y dependiendo de esto
	// rota la animacion
	void playerJump ()
	{
		GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
		if (moveRight) {
			jumpForce = new Vector2 (jumpX, jumpY);
			print("Vamos derecha");
		} else {
			jumpForce = new Vector2 (-jumpX, jumpY);
			print("Vamos izquierda");
		}
		GetComponent<Rigidbody2D> ().AddForce (jumpForce, ForceMode2D.Impulse);
	}

	//Cambia el sentido de la animacion, haciendo un flip de 180
	void flipAnimation ()
	{
		moveRight = !moveRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;  
		print ("Cambia la animacion");
	}
}

