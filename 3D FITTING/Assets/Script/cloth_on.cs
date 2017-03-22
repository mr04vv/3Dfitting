using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloth_on : MonoBehaviour {


	public GameObject tops1;
	public GameObject tops2;
	public GameObject tops3;
	//public GameObject button;


	// Use this for initialization
	void Start () {
		
		//button.SetActive (false);
		tops1.SetActive (false);
		tops2.SetActive (false);
		tops3.SetActive (false);
	}

	//public static GameObject button(){
	//	return a;
	//}
	public void settop1(){
		off ();
		setcloth (tops1);
	}
	public void settop2(){
		off ();
		setcloth (tops2);
	}
	public void settop3(){
		off ();
		setcloth (tops3);
	}

	public void setcloth(GameObject a){
		a.SetActive (true);
	}

	public void off(){
		tops1.SetActive (false);
		tops2.SetActive (false);
		tops3.SetActive (false);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
