using UnityEngine;
using System.Collections;

public class particleDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		audio.Play();
	}
	
	// Update is called once per frame
	void Update () {
		if (particleSystem.IsAlive() == false) Destroy(gameObject);
	}
}
