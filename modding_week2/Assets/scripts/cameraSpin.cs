﻿using UnityEngine;
using System.Collections;

public class cameraSpin : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0f, 45f * Time.deltaTime, 0f);
	}
}
