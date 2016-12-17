using UnityEngine;
using System.Collections;

public class MissileLaunch : MonoBehaviour {

	public GameObject hellfire;
	public GameObject fire;
	public GameObject nextParent;
	public AudioSource shoot; 

	bool waslaunched = false;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

		if (Input.GetKey ("space") == true) {
			ParticleSystem llamas = fire.GetComponent<ParticleSystem> ();

			// activar las llamas
			llamas.Play ();

			//ASignamos el misisl como hijo deñl nuevo padre
			//para evitar 
			gameObject.transform.SetParent(nextParent.transform);

			waslaunched = true;
		}

		if  (waslaunched == true){

			Vector3 delta = new Vector3 (0, 0, 1f);   // Los valores decimales se escriben agregando la f = float
			gameObject.transform.Translate(delta);

		}

	}
}
