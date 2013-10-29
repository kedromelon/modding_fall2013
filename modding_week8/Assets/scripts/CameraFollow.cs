using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	public float distance = 10.0f;
	public float height = 4.0f;
	public float heightDamping = 2.0f;
	public float rotationDamping = 3.0f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	void Update() {
		if(Input.GetKey(KeyCode.UpArrow)){
			if(distance > 4f) {
				distance -= 0.1f;
				if(height > 1f) height -= 0.05f;
			}
		}
		if(Input.GetKey(KeyCode.DownArrow)){
			if(distance < 12f) {
				distance += 0.1f;
				if(height < 4f) height += 0.05f;
			}
		}
	}
	// Update is called once per frame
	void LateUpdate () {
		if (!target) return;
		
		// Calculate the current rotation angles
	    float wantedRotationAngle = target.eulerAngles.y;
	    float wantedHeight = target.position.y + height;
	 
	    float currentRotationAngle = transform.eulerAngles.y;
	    float currentHeight = transform.position.y;
	 
	    // Damp the rotation around the y-axis
	    currentRotationAngle = Mathf.LerpAngle (currentRotationAngle, wantedRotationAngle, rotationDamping * Time.deltaTime);
	 
	    // Damp the height
	    currentHeight = Mathf.Lerp (currentHeight, wantedHeight, heightDamping * Time.deltaTime);
	 
	    // Convert the angle into a rotation
	    Quaternion currentRotation = Quaternion.Euler (0, currentRotationAngle, 0);
	 
	    // Set the position of the camera on the x-z plane to:
	    // distance meters behind the target
	    transform.position = new Vector3(target.position.x, currentHeight, target.position.z);
	    transform.position -= currentRotation * Vector3.forward * distance;
		
	 
	    // Set the height of the camera
	    //transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);
	 
	    // Always look at the target
	    transform.LookAt (target);
	}
}
