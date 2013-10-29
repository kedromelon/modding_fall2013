using UnityEngine;
using System.Collections;

public class Platformer : MonoBehaviour {
	
	public float speed = 1;
	public float turnSpeed = 1;
	public float jumpSpeed = 1;
	public float fallSpeed = 1;
	public Transform camera;
	public Transform particleLand;
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
			if (grounded == false){
				Instantiate (particleLand, 
					new Vector3(transform.position.x, transform.position.y - 1.1f, transform.position.z), 
					particleLand.rotation);
			}
			grounded = true;
		}else{
			grounded = false;
		}
		
		
		moveVector += Input.GetAxis("Vertical") * camera.transform.forward * speed;
		
		moveVector += Input.GetAxis("Horizontal") * camera.transform.right * speed;
		
		if(grounded == true){
			moveVector += Input.GetAxis("Jump") * transform.up * jumpSpeed;
		}
		
		if(rigidbody.velocity != Vector3.zero){
			transform.rotation = Quaternion.LookRotation( rigidbody.velocity );
			Vector3 eulerAngles = transform.rotation.eulerAngles;
			eulerAngles = new Vector3(0, eulerAngles.y, 0);
			transform.rotation = Quaternion.Euler(eulerAngles);
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
