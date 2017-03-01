using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataEnter : MonoBehaviour {

	public static Modeldata len2 = new Modeldata ();
	public static Modeldata kishi = new Modeldata ();
	public static Modeldata other = new Modeldata ();
	void Start(){
		len2.height = 0.0f;
		len2.west = 0.0f;
		len2.sholder = 0.0f;
		len2.chest = 0.0f;

	}
	// Use this for initialization
	public void koko(){
		
		
		len2.set (169.2f, 47.1f, 91.0f, 73.4f);

		kishi.set (185.3f, 48.0f, 91.3f, 77.0f);

		other.set (0.0f, 0.0f, 0.0f, 0.0f);
	}

}
