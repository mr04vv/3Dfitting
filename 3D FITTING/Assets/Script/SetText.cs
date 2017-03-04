using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetText : MonoBehaviour {

	public static Modeldata human;
	string strID;
	public static Modeldata len = new Modeldata ();
	public static Modeldata kishi = new Modeldata ();
	public static Modeldata mo_ri_ = new Modeldata ();
	public static Modeldata other = new Modeldata ();


	public Text T, W, C, S;



	public void setdata(){
		len.set (169.2f, 91.0f, 73.4f, 47.1f);
		mo_ri_.set (170.1f, 83.1f, 64.8f, 48.3f);
		kishi.set (185.3f, 91.3f, 77.0f, 48.0f);
		other.set (0.0f, 0.0f, 0.0f, 0.0f);
	
	}

	public void textload(Modeldata i){
		T.text = i.height.ToString ("N1")+" cm";
		W.text = i.west.ToString ("N1")+" cm";
		C.text = i.chest.ToString ("N1")+" cm";
		S.text = i.sholder.ToString("N1")+" cm";
	}

	public void nodata(Modeldata i){
		T.text = "no data";
		W.text = "no data";
		C.text = "no data";
		S.text = "no data";
	}



	public void set11(){
		strID = SaveScript.str;
		if (strID == "len") {
			human = len;
			textload (human);
		} else if (strID == "kishi") {
			human = kishi;
			textload (human);
		} else if (strID == "mo_ri_") {
			human = mo_ri_;
			textload (human);
		}else{
			human = other;
			nodata (human);
		}
	}
	
	// Update is called once per frame

}
