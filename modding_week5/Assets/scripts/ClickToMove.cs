using UnityEngine;
using System.Collections;

public class ClickToMove : MonoBehaviour {
	
	Vector3 destination;
	
	// Use this for initialization
	void Start () {
		destination = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
		Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition );
		RaycastHit rayHit = new RaycastHit();
		
		if (Input.GetMouseButtonDown(0)){
			if ( Physics.Raycast(ray, out rayHit)){
				destination = rayHit.point;
			}
		}
		
	}
	
	void FixedUpdate (){
		
		Vector3 direction = Vector3.Normalize( destination - transform.position );
		
		if (Vector3.Distance(destination, transform.position) > 50){
        	rigidbody.AddForce( direction * 200 );
		}
	}
}
