using UnityEngine;
using System.Collections;

public class PlatformerAnimation : MonoBehaviour {
	
	public GameObject capsule;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (capsule.rigidbody.velocity.magnitude > 1){
			if(capsule.GetComponent<Platformer>().grounded == false){
				if(capsule.rigidbody.velocity.y > 0){
					animation.CrossFade("jump");
				}else{
					animation.CrossFade("fall");
				}
			}else{
				animation["walk"].speed = capsule.rigidbody.velocity.magnitude / 6;
				animation.CrossFade("walk");
			}
			
		}else{
			animation.CrossFade("idle");
		}
		
		
		
	}
}
