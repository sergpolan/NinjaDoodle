using UnityEngine;
using System.Collections;

public class DestroyInvisible : MonoBehaviour {

	public bool active = false;

	/*
	 * Cuando aparece en la pantalla el objeto se activa la variable
	 * a true para que solo se active el metodo becomeInsible una vez
	 * haya desaparecido de la pantalla
	 */

	void OnBecameVisible()
	{
		print ("Walls visible.  Setting to active.");
		active=true;
	}

	/*
	 * Cuando desaparece de la pantalla el objeto comprueba
	 * que al menos se haya visto una vez por pantalla, si es asi
	 * lo destruye
	 */
	void OnBecameInvisible()
	{
		if(active==true)
		{
			print("Walls invisible.  Destroying.");
			active=false;
			Destroy (gameObject);
		}
	}
}
