using UnityEngine;
using System.Collections;

public class DeadPlayer : MonoBehaviour {

	public GameObject cameraGameOver;

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this, "DeadPlayerGameOver");
	}

	void DeadPlayerGameOver(Notification notification){
		cameraGameOver.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
