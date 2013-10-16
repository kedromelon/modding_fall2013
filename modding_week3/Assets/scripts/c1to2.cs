using UnityEngine;
using System.Collections;

public class c1to2 : MonoBehaviour {

	public Camera c1;
	public Camera c2;
	
	void OnTriggerEnter(Collider other){
	
		c1.enabled = false;
		c2.enabled = true;
		
	}
	
	
	
}
