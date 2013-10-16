using UnityEngine;
using System.Collections;

public class ballScript : MonoBehaviour {
	
	void FixedUpdate(){
		rigidbody.AddForce(Vector3.down * 100, ForceMode.Impulse);
	}
	
	void OnTriggerEnter(Collider other){
		Destroy(other.gameObject);	
	}
}
