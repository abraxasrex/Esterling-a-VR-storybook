using UnityEngine;
using System.Collections;

public class sceneController : MonoBehaviour {

	[RequireComponent(typeof(SteamVR_TrackedController))]
public class ViveControlsExample : MonoBehaviour {

	// Use this for initialization
	void OnEnable () {
		SteamVR_TrackedController controller = GetComponent<SteamVR_TrackedController>();
		controller.TriggerClicked += OnClickTrigger;
		controller.TriggerUnclicked += OnUnclickTrigger;
		controller.PadClicked += OnPadClicked;
	}
	
	void OnDisable(){
		SteamVR_TrackedController controller = GetComponent<SteamVR_TrackedController>();
		controller.TriggerClicked -= OnClickTrigger;
		controller.TriggerUnclicked -= OnUnclickTrigger;
		controller.PadClicked -= OnPadClicked;
	}

	void OnPadClicked(object sender, ClickedEventArgs e){
		Debug.Log ("Pad Clicked! X: " + e.padX + " " + e.padY);
	}

	void OnUnclickTrigger(object sender, ClickedEventArgs e) {
		Debug.Log("Unclicked trigger!");
	}

	void OnClickTrigger(object sender, ClickedEventArgs e) {
		Debug.Log("Clicked trigger!");
	}
	
}
}
