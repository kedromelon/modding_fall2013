using UnityEngine;
using System.Collections;

public class waterdeform : MonoBehaviour {
	
	MeshFilter mf;
	Vector3[] baseVertices;
	Vector3[] workingCopy;
	public float waveHeight;
	public float waveSpeed;
	
	// Use this for initialization
	void Start () {
		mf = GetComponent<MeshFilter>();
		baseVertices = mf.mesh.vertices;
	}
	
	// Update is called once per frame
	void Update () {
		
		workingCopy = baseVertices;
		
		for ( int i=0; i<workingCopy.Length ; i++ ){
			workingCopy[i] = baseVertices[i] + Vector3.up * Mathf.Sin(Time.time*waveSpeed + i) * waveHeight 
											 + Vector3.up * Mathf.Sin(Time.time*waveSpeed*2f + i) * waveHeight/2
											 + Vector3.up * Mathf.Sin(Time.time*waveSpeed*3f + i) * waveHeight/3
											 + Vector3.up * Mathf.Sin(Time.time*waveSpeed*5f + i) * waveHeight/5
											 + Vector3.up * Mathf.Sin(Time.time*waveSpeed*7f + i) * waveHeight/7
											 + Vector3.up * Mathf.Sin(Time.time*waveSpeed*11f + i) * waveHeight/11;
		}
		
		mf.mesh.vertices = workingCopy;
		
		mf.mesh.RecalculateNormals();
		
	
	}
}
