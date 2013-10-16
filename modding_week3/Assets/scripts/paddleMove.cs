using UnityEngine;
using System.Collections;

public class paddleMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		
		if (Input.GetKey(KeyCode.LeftArrow)){
			transform.position += new Vector3(0f, 0f, -40f * Time.deltaTime);
		}
		
		if (Input.GetKey(KeyCode.RightArrow)){
			transform.position += new Vector3(0f, 0f, 40f * Time.deltaTime);
		}
	}
}
