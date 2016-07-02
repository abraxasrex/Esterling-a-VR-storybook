using UnityEngine;
using System.Collections;

public class startScript : MonoBehaviour {

	public GameObject scene1;
	public GameObject scene2;
	public GameObject scene3;
	public GameObject scene4;
	public GameObject scene5;

	private int i = 0;
	private ArrayList scenes;

	// Use this for initialization
	void Start () {
		/*Renderer[] rend1 = scene1.GetComponentsInChildren<Renderer> ();
		Renderer[] rend2 = scene2.GetComponentsInChildren<Renderer> ();
		Renderer[] rend3 = scene3.GetComponentsInChildren<Renderer> ();
		Renderer[] rend4 = scene4.GetComponentsInChildren<Renderer> ();
		Renderer[] rend5 = scene5.GetComponentsInChildren<Renderer> ();

		scenes = new ArrayList();
		scenes.Add (scene1);
		scenes.Add (scene2);
		scenes.Add (scene3);
		scenes.Add (scene4);
		scenes.Add (scene5);

		foreach (Renderer r in rend1) {
			r.enabled = true;
		}
		foreach (Renderer r in rend2) {
			r.enabled = false;
		}
		foreach (Renderer r in rend3) {
			r.enabled = false;
		}
		foreach (Renderer r in rend4) {
			r.enabled = false;
		}
		foreach (Renderer r in rend5) {
			r.enabled = false;
		}*/
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void advanceScene(){
		GameObject g = (GameObject)this.scenes [this.i];
		GameObject g2 = (GameObject)this.scenes [this.i + 1];
		Renderer[] r = g.GetComponentsInChildren<Renderer> ();
		Renderer[] r2 = g2.GetComponentsInChildren<Renderer> ();

		foreach (Renderer c in r) {
			c.enabled = false;
		}
		foreach (Renderer c2 in r2) {
			c2.enabled = true;
		}
	}


}
