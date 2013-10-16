using UnityEngine;
using System.Collections;

public class ballSpin : MonoBehaviour {
	
	public float speed = 100;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0f , 1f * (Time.deltaTime*speed), 0f);
		if (Time.time > 3.4 && Time.time < 3.55){
			if(speed>=0){
				speed += 10;
			}else{
				speed -= 10;
			}
		}
	}
}
