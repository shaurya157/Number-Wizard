using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {
	int max;
	int min;
	int guess;
	
	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	void NextGuess(){
		guess = (max + min)/2;
		print ("Higher or lower than " + guess + "?");
	}
	
	void StartGame(){
		max = 1000;
		min = 1;
		guess = 500;
		max += 1;
		
		print ("welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me!");	
		
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		
		print ("is the number higher or lower than " + guess);
		print ("Up = higher, down = lower, return = equal");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)){
//			print ("Up Arrow pressed"); 
			min = guess;
			NextGuess();
			
		} else if (Input.GetKeyDown(KeyCode.DownArrow)){
//			print ("Down Arrow pressed");
			max = guess;
			NextGuess();
		} else if (Input.GetKeyDown("return")){
			print ("I won!");
			StartGame();
		}
	}
}