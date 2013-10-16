using UnityEngine;
using System.Collections;

public class ballBounce : MonoBehaviour {
	
	Vector3 basePosition = Vector3.zero;

	// Use this for initialization
	void Start () {
		
		basePosition = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
		//basePosition += new Vector3( 1.5f * Time.deltaTime, 0f, 0f );
		transform.position = basePosition + new Vector3(0f, - Mathf.Abs(Mathf.Sin(Time.time*10f)),0f);
	}
}
