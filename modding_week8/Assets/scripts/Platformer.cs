using UnityEngine;
using System.Collections;

public class Platformer : MonoBehaviour {
	
	public float speed = 1;
	public float turnSpeed = 1;
	public float jumpSpeed = 1;
	public float fallSpeed = 1;
	Vector3 moveVector;
	bool grounded = false;
	
	// Use this for initialization
	void Start () {
		moveVector = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
		
		moveVector = Vector3.zero;
		
		Ray ray = new Ray(transform.position, -transform.up);
		RaycastHit hit = new RaycastHit();
		
		if (Physics.Raycast(ray, out hit, 1.25f)){
			grounded = true;
		}else{
			grounded = false;
		}
		
		if(Input.GetKey(KeyCode.W)){
			moveVector += transform.forward * speed;
		}
		if(Input.GetKey(KeyCode.S)){
			moveVector -= transform.forward * speed;
		}
		if(Input.GetKey(KeyCode.A)){
			transform.Rotate( 0f, -turnSpeed * Time.deltaTime, 0f );
		}
		if(Input.GetKey(KeyCode.D)){
			transform.Rotate( 0f, turnSpeed * Time.deltaTime, 0f );
		}
		
		if(Input.GetKeyDown(KeyCode.Space) && grounded == true){
			moveVector += transform.up * jumpSpeed;
		}
		
	}
	
	void FixedUpdate () {
		if (moveVector != Vector3.zero){
			if(grounded == true){
				rigidbody.AddForce( moveVector, ForceMode.VelocityChange);
			}else{
				rigidbody.AddForce( moveVector*.1f, ForceMode.VelocityChange);
			}
		}else{
			rigidbody.AddForce( new Vector3(-rigidbody.velocity.x, 0f, -rigidbody.velocity.z), ForceMode.Acceleration);			
		}
		
		if (rigidbody.velocity.y < 0){
				rigidbody.AddForce( new Vector3(0, -rigidbody.velocity.y , 0) + Physics.gravity * fallSpeed, ForceMode.Acceleration);
		}
	}
}
