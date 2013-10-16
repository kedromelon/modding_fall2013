using UnityEngine;
using System.Collections;

public class CubeMove : MonoBehaviour {
	
	public float speed = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// go to cube heaven at rate of 'speed' units over the duration of a second
		transform.position = transform.position + new Vector3( 0f, speed * Time.deltaTime, 0f );
	}
}
