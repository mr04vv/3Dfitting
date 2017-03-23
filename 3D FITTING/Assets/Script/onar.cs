using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onar : MonoBehaviour {

	public GameObject tops1;
	public GameObject tops2;
	public GameObject tops3;
	public GameObject human;
	public GameObject b;
	public GameObject g;
	public GameObject r;
	// Use this for initialization
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
		b.transform.SetParent (human.transform, false);
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
		g.transform.SetParent (human.transform, false);
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
		r.transform.SetParent (human.transform, false);
	}
	public void off(GameObject a){
		GameObject.Destroy(a);
	}
}
