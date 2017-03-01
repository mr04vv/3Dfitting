using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetText : MonoBehaviour {

	public static Modeldata human;
	string strID;
	public static Modeldata len1 =DataEnter.len2;

	public Text T, W, C, S;


	string rt,rw,rc,rs;

	public void settxt(){
		T.GetComponent<Text> ().text = rt;
		W.GetComponent<Text> ().text = rw;
		C.GetComponent<Text> ().text = rc;
		S.GetComponent<Text> ().text = rs;
	}
	public void textload(){
		float e=human.height;
		rt = ToString (e);
		rw = human.west.ToString ();
		rc = human.chest.ToString ();
		rs = human.sholder.ToString();
	}

	public void set11(){
		strID = SaveScript.str;
		if(strID=="len"){
			human = len1;
			this.textload();
			this.settxt ();
		}else if(strID=="kishi"){
			human = len1;
			this.settxt ();
		}else{
			human = len1;
			this.settxt ();
		}
	}
	
	// Update is called once per frame

}
