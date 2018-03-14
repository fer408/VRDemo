using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameLogic : MonoBehaviour {
	//Stores bool indicating if all the stations have been commpleted.
	public bool allCollected = false;
	//Creates GameObjects to store the pedestal entrances.
	public GameObject mainPedastal;
	public GameObject pedastalTwo;
	public GameObject pedastalThree;
	public GameObject pedastalFour;
	public GameObject pedastalFive;
	//Creates GameObjects to store the cubes.
	public GameObject mainCube1;
	public GameObject mainCube2;
	public GameObject mainCube3;
	public GameObject pedastalTwoCube1;
	public GameObject pedastalTwoCube2;
	public GameObject pedastalTwoCube3;
	public GameObject pedastalThreeCube1;
	public GameObject pedastalThreeCube2;
	public GameObject pedastalThreeCube3;
	public GameObject pedastalFourCube1;
	public GameObject pedastalFourCube2;
	public GameObject pedastalFourCube3;
	public GameObject pedastalFiveCube1;
	public GameObject pedastalFiveCube2;
	public GameObject pedastalFiveCube3;
	//Stores GameObjects with the audio sources the different endings a user can experience.
	public GameObject Oracle1;
	public GameObject Oracle2;
	public GameObject Oracle3;
	//Stores bools wich will determine fate.
	public bool rich = false;
	public bool poor = false;
	public bool middle = false;
	public int points = 0;
	//Stores bools indicating if a station has been completed
	public bool mainDone = false;
	public bool secondDone = false;
	public bool thirdDone = false;
	public bool fourthDone = false;
	public bool fifthDone = false;
	//Stores Gameobjects that have the AudioSources for the points user receives.
	public GameObject Points;


	void OnTriggerEnter(Collider col){
		if(col.gameObject.name =="MainPedestalEntrance"){
			mainPedastal.GetComponent<AudioSource>().Play();
			points += 1;
		}
		if(col.gameObject.name =="PedestalEntranceTwo"){
			pedastalTwo.GetComponent<AudioSource>().Play();
			points += 1;
		}
		if(col.gameObject.name =="PedestalEntranceThree"){
			pedastalThree.GetComponent<AudioSource>().Play();
			points += 1;
		}
		if(col.gameObject.name =="PedestalEntranceFour"){
			pedastalFour.GetComponent<AudioSource>().Play();
			points += 1;
		}
		if(col.gameObject.name =="PedestalEntranceFive"){
			pedastalFive.GetComponent<AudioSource>().Play();
			points += 1;
		}
		if(col.gameObject.name == "MainCubeBlue"){
			mainCube1.SetActive(false);
			mainCube2.SetActive(false);
			mainCube3.SetActive(false);
			mainCube1.GetComponent<AudioSource>().Play();
			middle = true;
			mainDone = true;
		}
		if(col.gameObject.name == "MainCubeRed"){
			mainCube2.GetComponent<AudioSource>().Play();
			mainCube1.SetActive(false);
			mainCube2.SetActive(false);
			mainCube3.SetActive(false);
			rich = true;
			mainDone = true;
		}
		if(col.gameObject.name == "MainCubeGreen"){
			mainCube3.GetComponent<AudioSource>().Play();
			mainCube1.SetActive(false);
			mainCube2.SetActive(false);
			mainCube3.SetActive(false);
			poor = true;
			mainDone = true;
		}
		if(col.gameObject.name == "BlueCube2"){
			secondDone = true;
			pedastalTwoCube1.GetComponent<AudioSource>().Play();
			pedastalTwoCube1.SetActive(false);
			pedastalTwoCube2.SetActive(false);
			pedastalTwoCube3.SetActive(false);
		}
		if(col.gameObject.name == "RedCube2"){
			secondDone = true;
			pedastalTwoCube2.GetComponent<AudioSource>().Play();
			pedastalTwoCube1.SetActive(false);
			pedastalTwoCube2.SetActive(false);
			pedastalTwoCube3.SetActive(false);
		}
		if(col.gameObject.name == "GreenCube2"){
			secondDone = true;
			pedastalTwoCube3.GetComponent<AudioSource>().Play();
			pedastalTwoCube1.SetActive(false);
			pedastalTwoCube2.SetActive(false);
			pedastalTwoCube3.SetActive(false);
		}
		if(col.gameObject.name == "BlueCube3"){
			thirdDone = true;
			pedastalThreeCube1.GetComponent<AudioSource>().Play();
			pedastalThreeCube1.SetActive(false);
			pedastalThreeCube2.SetActive(false);
			pedastalThreeCube3.SetActive(false);
		}
		if(col.gameObject.name == "RedCube3"){
			thirdDone = true;
			pedastalThreeCube2.GetComponent<AudioSource>().Play();
			pedastalThreeCube1.SetActive(false);
			pedastalThreeCube2.SetActive(false);
			pedastalThreeCube3.SetActive(false);
		}
		if(col.gameObject.name == "GreenCube3"){
			thirdDone = true;
			pedastalThreeCube3.GetComponent<AudioSource>().Play();
			pedastalThreeCube1.SetActive(false);
			pedastalThreeCube2.SetActive(false);
			pedastalThreeCube3.SetActive(false);
		}
		if(col.gameObject.name == "BlueCube4"){
			fourthDone = true;
			pedastalFourCube1.GetComponent<AudioSource>().Play();
			pedastalFourCube1.SetActive(false);
			pedastalFourCube2.SetActive(false);
			pedastalFourCube3.SetActive(false);
		}
		if(col.gameObject.name == "RedCube4"){
			fourthDone = true;
			pedastalFourCube2.GetComponent<AudioSource>().Play();
			pedastalFourCube1.SetActive(false);
			pedastalFourCube2.SetActive(false);
			pedastalFourCube3.SetActive(false);
		}
		if(col.gameObject.name == "GreenCube4"){
			fourthDone = true;
			pedastalFourCube3.GetComponent<AudioSource>().Play();
			pedastalFourCube1.SetActive(false);
			pedastalFourCube2.SetActive(false);
			pedastalFourCube3.SetActive(false);
		}
		if(col.gameObject.name == "BlueCube5"){
			fifthDone = true;
			pedastalFiveCube1.GetComponent<AudioSource>().Play();
			pedastalFiveCube1.SetActive(false);
			pedastalFiveCube2.SetActive(false);
			pedastalFiveCube3.SetActive(false);
		}
		if(col.gameObject.name == "RedCube5"){
			fifthDone = true;
			pedastalFiveCube2.GetComponent<AudioSource>().Play();
			pedastalFiveCube1.SetActive(false);
			pedastalFiveCube2.SetActive(false);
			pedastalFiveCube3.SetActive(false);
		}
		if(col.gameObject.name == "GreenCube5"){
			fifthDone = true;
			pedastalFiveCube3.GetComponent<AudioSource>().Play();
			pedastalFiveCube1.SetActive(false);
			pedastalFiveCube2.SetActive(false);
			pedastalFiveCube3.SetActive(false);
		}
		//If all the stations have been visited and interacted with the allCollected bool will be set to tru which is responsible for 
		//signifying all bools have been collected. 	
		if((mainDone) && (secondDone) && (thirdDone) && (fourthDone) && (fifthDone)){
			allCollected = true;
			if (points == 5){
				Points.GetComponent<AudioSource>().Play();
			}
		}
		if((allCollected) && (col.gameObject.name == "OracleEntrance") && (rich)){
			Oracle1.GetComponent<AudioSource>().Play();
		}
		if((allCollected) && (col.gameObject.name == "OracleEntrance") && (middle)){
			Oracle2.GetComponent<AudioSource>().Play();
		}
		if((allCollected) && (col.gameObject.name == "OracleEntrance") && (poor)){
			Oracle3.GetComponent<AudioSource>().Play();
		}
	}
}
