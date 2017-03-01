using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SaveScript : MonoBehaviour {

	public static string str,str1;
	public InputField id1;
	public InputField pass1;
	public Text text,text1;



	public void SaveText () {
		str = id1.text;
		text.text = str;
		id1.text = "";
	}
	public void SaveText1 () {
		str1 = pass1.text;
		text1.text = str1;
		pass1.text = "";
	}

}
