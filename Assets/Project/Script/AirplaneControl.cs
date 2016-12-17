using UnityEngine;
using System.Collections;

public class AirplaneControl : MonoBehaviour {


	float planespeed = 2f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

		// Mover a la derecha es insertar un valor positivo en X , dependiendo de la ubicacion de la camara
		// Mover a la izquierda es insertar un valor negativo en X , dependiendo de la ubicacion de la camara

		// Mover hacia arriba es insertar un valor positivo en Y
		// Mover hacia abajo es insertar un valor negativo en Y
		if (Input.GetKey ("left") == true){

			Vector3 delta = new Vector3 (- planespeed, 0, 0);   // Los valores decimales se escriben agregando la f = float

			gameObject.transform.Translate (delta);
		}

		if (Input.GetKey ("right")== true){

			Vector3 delta = new Vector3 (planespeed, 0, 0);   // Los valores decimales se escriben agregando la f = float

			gameObject.transform.Translate (delta);
		}

		if (Input.GetKey ("up") == true){

			Vector3 delta = new Vector3 (0, planespeed, 0);   // Los valores decimales se escriben agregando la f = float

			gameObject.transform.Translate (delta);
		}

		if (Input.GetKey ("down") == true){

			Vector3 delta = new Vector3 (0, - planespeed, 0);   // Los valores decimales se escriben agregando la f = float

			gameObject.transform.Translate (delta);
		}

	}
}
