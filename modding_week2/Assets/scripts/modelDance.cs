using UnityEngine;
using System.Collections;

public class modelDance : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
		if(Time.time > 2f && Time.time < 10f){
			transform.position += new Vector3(0f, 10f, 0f) * Time.deltaTime;
			transform.localScale += new Vector3(1f, 1f, 1f) * Time.deltaTime;
			transform.Rotate (0f, 45f * Time.deltaTime, 0f);
		}
		
		if(Time.time > 5f && light.enabled == false){
			light.enabled = true;
		}
		
	}
}
