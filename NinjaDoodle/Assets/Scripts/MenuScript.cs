using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	public void CerrarAplicacion()
	{
		Debug.Log ("clicko en salir");
		Application.Quit ();
	}

	public void CargarPantallaPrincipal()
	{
		Application.LoadLevel("MainGame");
	}
}
