using UnityEngine;
using System.Collections;

public class TenPrint : MonoBehaviour {
	
	TextMesh myTextMesh;
	int counter;
	
	// Use this for initialization
	void Start () {
		myTextMesh = GetComponent<TextMesh>();
		counter = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
		float randomNumber = Random.Range ( 0f, 10f );
		
		if ( randomNumber < 5f ) {
			myTextMesh.text += "/";
		} else {
			myTextMesh.text += "\\";
		}
		
		counter++;
		
		if ( counter % 40 == 0){
			myTextMesh.text += "\n";
		}
	
	}
}
