using UnityEngine;
using System.Collections;

public class Fish : MonoBehaviour {
	
	public Vector3 destination = new Vector3( 100f, 100f, 0f );
	public float speed = 5f;

	// Use this for initialization
	void Start () {
		InvokeRepeating( "SetNewDestination", 0f, .5f );
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.LookRotation( rigidbody.velocity );
	}
	
	void FixedUpdate () {
		Vector3 direction = Vector3.Normalize( destination - transform.position );
		rigidbody.AddForce( direction * speed, ForceMode.VelocityChange );
	}
	
	void SetNewDestination () {
		// set a random destination
		destination = Random.insideUnitSphere * 50f;
		speed = Random.value;
	}
}
