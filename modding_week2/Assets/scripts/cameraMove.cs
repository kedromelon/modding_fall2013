using UnityEngine;
using System.Collections;

public class cameraMove : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time < 3){
			transform.position += ( new Vector3(0f, 1f, -30f) - transform.position ) * Time.deltaTime;
		}else if (Time.time >= 3 && Time.time < 29){
			transform.position += new Vector3(0f, 0f, .02f);
		}else{
			transform.position += ( new Vector3(0f, 1f, 50f) - transform.position ) * Time.deltaTime;
		}
	}
}
