using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {

	private readonly float defaultScale = 1f;
	private readonly float defaultGenerateVelocity = 0.6f;

	public GameObject wall;
	public GameObject vWall;
	public GameObject player;
	private Renderer wallRender;

	Vector3 v3WallLeft = new Vector3(0.01f, 1.2f, 1);
	Vector3 v3WallRight = new Vector3(0.99f, 1.2f, 1);
	Vector3 v3VerticalWallLeft = new Vector3(0.17f, 1.2f, 1);
	Vector3 v3VerticalWallRight = new Vector3(0.83f, 1.2f, 1);
	Vector3 v3Player = new Vector3(0.5f, 0.5f, 1);

	private int screenWidth;
	private int screenHeight;
	private float velocidadGeneracion;
	public float scale;

	void Start () {
		CalculateScale ();

		wall.transform.localScale = new Vector3(scale, scale, 0);
		Invoke ("CreatingPlayer", 0.5f);
		Invoke ("CreatinVerticalWall", 0.6f);
		InvokeRepeating ("CreatingWall", 1f, velocidadGeneracion);

	}
	
	void CreatingWall()
	{
		Instantiate (wall, Camera.main.ViewportToWorldPoint (v3WallLeft), Quaternion.identity);
		Instantiate (wall, Camera.main.ViewportToWorldPoint (v3WallRight), Quaternion.identity);
	}

	void CreatingPlayer()
	{
		Instantiate (player, Camera.main.ViewportToWorldPoint (v3Player), Quaternion.identity);

	}

	void CreatinVerticalWall()
	{
		Instantiate (vWall, Camera.main.ViewportToWorldPoint (v3VerticalWallLeft), Quaternion.identity);
		Instantiate (vWall, Camera.main.ViewportToWorldPoint (v3VerticalWallRight), Quaternion.identity);
	}

	void CalculateScale ()
	{
		float diferencia = defaultScale / scale;
		print (diferencia);
		velocidadGeneracion = defaultGenerateVelocity / diferencia;
	}
}
