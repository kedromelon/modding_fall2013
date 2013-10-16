using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FishGod : MonoBehaviour {
	
	public Fish fishBlueprint;
	public Fish fishBlueprint2;
	public Fish fishBlueprint3;
	public int fishCount = 100;
	
	public List<Fish> fishList = new List<Fish>();

	// Use this for initialization
	void Start () {
		int currentFishCounter = 0;
		while ( currentFishCounter < fishCount ) {
			// spawn a fish
			float fishtype = Random.value;
			Vector3 fishPosition = new Vector3( Random.Range (-10f,10f),Random.Range (-10f,10f), Random.Range (-10f,10f));
			if (fishtype < .5){
				Fish newFish = Instantiate(fishBlueprint, fishPosition, Quaternion.identity) as Fish;
				fishList.Add (newFish);
			}else if(fishtype < .9){
				Fish newFish = Instantiate(fishBlueprint2, fishPosition, Quaternion.identity) as Fish;
				fishList.Add (newFish);
			}else{
				Fish newFish = Instantiate(fishBlueprint3, fishPosition, Quaternion.identity) as Fish;
				fishList.Add (newFish);
			}
			
			// increment counter
			currentFishCounter++;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKey( KeyCode.Space )){
			foreach ( Fish currentFish in fishList ){
				currentFish.destination = Vector3.zero;
			}
			fishBlueprint.destination = Vector3.zero;
			fishBlueprint2.destination = Vector3.zero;
			fishBlueprint3.destination = Vector3.zero;
			
		}
	}
}
