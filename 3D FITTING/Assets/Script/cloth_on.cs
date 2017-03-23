using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class cloth_on : MonoBehaviour {


	public GameObject tops1;
	public GameObject tops2;
	public GameObject tops3;
	public GameObject TB1;
	public GameObject TB2;
	public GameObject TB3;
	public GameObject human;
	public static int count=0;
	public GameObject b;
	public GameObject g;
	public GameObject r;
	public GameObject Can;
	public static GameObject buttonblue;
	public static GameObject buttongreen;
	public static GameObject buttonred;
	public static int bo;
	public static int a;
	public static int c;
	public static int l;
	//public GameObject button;
	// Use this for initialization

	void Start () {
		

		l = PQRCodeManager.result ();
		if(l==1 && a!=1){
			a = l;
			buttonblue=Instantiate (TB1);
			buttonblue.transform.SetParent (Can.transform, false);
		}
		if (a == 1) {
			buttonblue=Instantiate (TB1);
			buttonblue.transform.SetParent (Can.transform, false);
		}

		if(bo!=2 && l==2){
			bo = l;
			buttongreen=Instantiate (TB2);
			buttongreen.transform.SetParent (Can.transform, false);
		}
		if (bo== 2) {
			buttongreen=Instantiate (TB2);
			buttongreen.transform.SetParent (Can.transform, false);
		}

		if (c != 3 && l == 3) {
			c = l;
			buttonred=Instantiate (TB3);
			buttonred.transform.SetParent (Can.transform, false);
		}
		if (c == 3) {
			buttonred=Instantiate (TB3);
			buttonred.transform.SetParent (Can.transform, false);
		}

			


		//button.SetActive (false);

	}

	//public static GameObject button(){
	//	return a;
	//}
	public void settop1(){
		if (b != null) {
			b = GameObject.Find ("topsgblue(Clone)");
			off (b);
		}
		if (g != null) {
			g = GameObject.Find ("topsgreen(Clone)");
			off (g);
		}
		if (r != null) {
			r = GameObject.Find ("topsred(Clone)");
			off (r);
		}
		b= Instantiate (tops1);
	}
	public void settop2(){
		if (b != null) {
			b = GameObject.Find ("topsgblue(Clone)");
			off (b);
		}
		if (g != null) {
			g = GameObject.Find ("topsgreen(Clone)");
			off (g);
		}
		if (r != null) {
			r = GameObject.Find ("topsred(Clone)");
			off (r);
		}

		g=Instantiate (tops2);

	}
	public void settop3(){
		if (b != null) {
			b = GameObject.Find ("topsgblue(Clone)");
			off (b);
		}
		if (g != null) {
			g = GameObject.Find ("topsgreen(Clone)");
			off (g);
		}
		if (r != null) {
			r = GameObject.Find ("topsred(Clone)");
			off (r);
		}
		r=Instantiate (tops3);
	}

	public void setcloth(GameObject a){
		a.SetActive (true);
	}

	public void off(GameObject a){
		GameObject.Destroy(a);
	}
	// Update is called once per frame
	void Update () {
		
	}
	public void uiui(){
		
	}
}
