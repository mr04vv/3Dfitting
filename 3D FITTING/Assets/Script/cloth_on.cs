using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloth_on : MonoBehaviour {


	public GameObject tops1;
	public GameObject botoms1;
	// Use this for initialization
	void Start () {
		tops1.SetActive (false);
		botoms1.SetActive (false);
	}
	public void settop1(){
		setcloth (tops1);
	}
	public void setbotoms1(){
		setcloth (botoms1);
	}

	public void setcloth(GameObject a){
		a.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
