using UnityEngine;
using System.Collections;

public class Platformer : MonoBehaviour {
	
	public float speed = 20;
	public float jumpforce = 200;
	bool onGround = false;
	bool doubleJump = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void FixedUpdate () {
		
		Ray ray = new Ray(transform.position, -transform.up);
		RaycastHit rayHit = new RaycastHit();
		
		if (Physics.Raycast(ray, out rayHit, transform.localScale.y / 2)){ 
			onGround = true;
			doubleJump = true;
		}
		
		if(Input.GetKey(KeyCode.LeftArrow)){
			rigidbody.AddRelativeForce(Vector3.left * speed);
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			rigidbody.AddRelativeForce(Vector3.right * speed);
		}
		if(Input.GetKey(KeyCode.UpArrow)){
			rigidbody.AddRelativeForce(Vector3.forward * speed);
		}
		if(Input.GetKey(KeyCode.DownArrow)){
			rigidbody.AddRelativeForce(Vector3.back * speed);
		}
		
		if(Input.GetKeyDown(KeyCode.Space)){
			if(onGround){
				rigidbody.AddForce(Vector3.up * jumpforce); 
				onGround = false;
			}else if(doubleJump){
				//if (rigidbody.velocity.y < 0){
				//	rigidbody.AddForce(Vector3.up * (jumpforce + Mathf.Abs(rigidbody.velocity.y)));
				//}
				rigidbody.velocity = Vector3.zero;
				rigidbody.AddForce(Vector3.up * (jumpforce)); 
				doubleJump = false;
			}
		}
			
	}
}
