using UnityEngine;
using System.Collections;

public class Scene1_next : MonoBehaviour {

	public GameObject nextScene;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col){
		/**
		Renderer[] rend = nextScene.GetComponentsInChildren<Renderer> ();
		foreach (Renderer r in rend) {
			r.enabled = false;
		}
		print ("event triggered");
		/**/
	}
}
