using UnityEngine;
using System.Collections;

public class guySpin : MonoBehaviour {
	
	public float speed = 100;
	public Vector3 destination = Vector3.zero;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0f , 1f * (Time.deltaTime*speed), .33f * (Time.deltaTime*speed) );
		if (Time.time < 47){
			transform.position += ( destination - transform.position ) * Time.deltaTime;
		}else{
			transform.position += ( new Vector3(2.087749f, 50f, 71.27821f) - transform.position ) * Time.deltaTime;
		}
	}
}
