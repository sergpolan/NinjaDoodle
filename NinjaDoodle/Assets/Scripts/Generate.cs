using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {

	public GameObject wall_left;
	public GameObject wall_right;
	public GameObject vWall_left;
	public GameObject vWall_right;
	public GameObject player;
	private Renderer wallRender;

	Vector3 v3WallLeft = new Vector3(0.01f, 1.2f, 1);
	Vector3 v3WallRight = new Vector3(0.99f, 1.2f, 1);
	Vector3 v3VerticalWallLeft = new Vector3(0.17f, 1.2f, 1);
	Vector3 v3VerticalWallRight = new Vector3(0.83f, 1.2f, 1);
	Vector3 v3Player = new Vector3(0.5f, 0.5f, 1);

	void Start () {
		Invoke ("CreatingPlayer", 0.5f);
		Invoke ("CreatinVerticalWall", 0.6f);
		InvokeRepeating ("CreatingWall", 1f, 0.6f);
	}
	
	void CreatingWall()
	{
		Instantiate (wall_left, Camera.main.ViewportToWorldPoint (v3WallLeft), Quaternion.identity);
		Instantiate (wall_right, Camera.main.ViewportToWorldPoint (v3WallRight), Quaternion.identity);
	}

	void CreatingPlayer()
	{
		Instantiate (player, Camera.main.ViewportToWorldPoint (v3Player), Quaternion.identity);

	}

	void CreatinVerticalWall()
	{
		Instantiate (vWall_left, Camera.main.ViewportToWorldPoint (v3VerticalWallLeft), Quaternion.identity);
		Instantiate (vWall_right, Camera.main.ViewportToWorldPoint (v3VerticalWallRight), Quaternion.identity);
	}
}
