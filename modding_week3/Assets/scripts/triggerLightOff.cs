using UnityEngine;
using System.Collections;

public class triggerLightOff : MonoBehaviour {
	
	public Light sun;

	void OnTriggerEnter(Collider other){
		sun.enabled = false;
	}
}
