using UnityEngine;
using System.Collections;

public class pulse : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > 3.3 && Time.time < 3.5){	
				transform.localScale += new Vector3(20f, 20f, 20f) * Time.deltaTime;
		}
	}
}
