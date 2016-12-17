using UnityEngine;
using System.Collections;

public class MissileLaunch : MonoBehaviour {

	// Datos misil actual
	public GameObject hellfire;
	public GameObject fire;

	public AudioSource Shoot; 

	bool waslaunched = false;
	GameObject nextParent;
	GameObject launcher;


	// Use this for initialization
	void Start () {
		waslaunched = false;

		nextParent = GameObject.Find("MissilesLaunched"); 
		launcher = GameObject.Find ("Helicopter/Launcher");

	}
	
	// Update is called once per frame
	void Update () {



		// ------------- Comportamiento del Misil

		if (Input.GetKey ("space") == true) {
			

			if (waslaunched == false) {
				ParticleSystem llamas = fire.GetComponent<ParticleSystem> ();

				// activar las llamas
				llamas.Play ();


				Shoot.Play();

				//Asignamos el misil como hijo del nuevo padre
				//para evitar 
				gameObject.transform.SetParent (nextParent.transform);

				waslaunched = true;

				// Creo una copia del misil
				GameObject newMissile = (GameObject) Instantiate (Resources.Load ("Prefabs/Missile")) as GameObject;

				// Asociamos el nuevo misil al avion
				newMissile.transform.SetParent (launcher.transform);

				// Movemos el misil respecto a la posicion del padre
				newMissile.transform.localPosition = new Vector3 (0,0,0);
			}
		}


			if  (waslaunched == true){

				Vector3 delta = new Vector3 (0, 0, 0.5f);   // Los valores decimales se escriben agregando la f = float
				gameObject.transform.Translate(delta);

			}


		}


}
