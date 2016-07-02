using UnityEngine;
using System.Collections;

public class nextButton : MonoBehaviour {

	public GameObject nextScene;
	public GameObject thisScene;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col){
		/**
		Renderer[] rend = nextScene.GetComponentsInChildren<Renderer> ();
		///Renderer[] currRend = this.GetCompone.getCom//GetComponentsInParent<Renderer>();
		Renderer[] currRend = thisScene.GetComponentsInChildren<Renderer>();
		foreach (Renderer r in rend) {
			r.enabled = true;
		}
		foreach (Renderer r in currRend) {
			r.enabled = false;
		}
		print ("event triggered");
		/**/
	}
}
