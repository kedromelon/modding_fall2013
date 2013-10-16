using UnityEngine;
using System.Collections;

public class numberGuess : MonoBehaviour {
	
	int guess = 0; // this is the number the player is guessing
	
	int secretNumber = 0; // this is the number we have to guess

	// Use this for initialization
	void Start () {
		secretNumber = Random.RandomRange(0,20);
	}
	
	// Update is called once per frame
	void Update () {
		
		if ( Input.GetKeyDown(KeyCode.LeftArrow) == true ){
			guess--;
			guiText.text = guess.ToString ();
		}
		
		if ( Input.GetKeyDown(KeyCode.RightArrow)){
			guess++;
			guiText.text = guess.ToString ();
		}
		
		// if player presses enter, then evaluate the guess
		if ( Input.GetKeyDown(KeyCode.Return)){
			if ( guess < secretNumber){
				guiText.text = "2 low, u sux lolz";
			}else if ( guess > secretNumber){
				guiText.text = "2 hi, u sux lolz";
			}else if ( guess == secretNumber ){
				guiText.text = "AAYYYYY U DA WINNA, ITS " +secretNumber;
			}
		}
		
		
	}
}
