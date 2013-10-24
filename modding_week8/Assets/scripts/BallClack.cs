using UnityEngine;
using System.Collections;

public class BallClack : MonoBehaviour {
	
	public Vector3 start, end; // exposed in the inspector
	
	Vector3 baseCameraPosition;
	
	// Use this for initialization
	void Start () {
		StartCoroutine( BallMove() );
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	IEnumerator ScreenShake () {
		float t = .5f;
		baseCameraPosition = Camera.main.transform.position;
		while ( t > 0f ){
			t -= Time.deltaTime;
			Camera.main.transform.position = baseCameraPosition + new Vector3( Mathf.Sin(Time.time * 10f)*.3f, 
																 			   Mathf.Sin(Time.time * 12.5f)*.5f, 
														 					   Mathf.Sin(Time.time * 7f)*.2f);
			yield return 0;
		}
	}
	
	IEnumerator BallMove () {
		while( true ){
			float t = Mathf.Sin(Time.time * 2f) * 0.5f + 0.5f;
			if ((Mathf.Abs( 0.5f - t ) < 0.01f) && !audio.isPlaying){
				audio.Play();
				//StartCoroutine(ScreenShake());
			}
			transform.position = Vector3.Lerp( start, end, t );
			yield return 0; // wait a frame
		}
		
		// this code will never run bc while loop is infinite
		yield return 0;
		Debug.Log ("I waited one frame");
		
		yield return 0;
		yield return 0;
		Debug.Log("I waited two frames");
		
		yield return new WaitForSeconds( 5f );
		Debug.Log("5 Seconds have passed");
	}
}
