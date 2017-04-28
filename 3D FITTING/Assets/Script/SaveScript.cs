using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SaveScript : MonoBehaviour {

	public static string str,str1;
	public static string h, w, c, k;
	public InputField h1, w1, c1, k1;
	public InputField id1;
	public InputField pass1;
	public Text text,text1;
	public Text h2, w2, c2, k2;
	public static Modeldata other=new Modeldata();

	void Start(){
		

	}
	public void SaveText () {
		//id1というinputfield（テキストが入力可能なフィールド)に入力された文字をstrに保存
		str = id1.text;
		text.text = str;   //textに指定したオブジェクトのTextcomponentにstrを格納
		id1.text = "";   //id1を初期化してinputfieldの文字を消去
	}

	public void SaveText1 () {
		str1 = pass1.text;
		text1.text = str1;
		pass1.text = "";
	}
	public void Saveh () {
		h = h1.text;
		h2.text = h;
		h1.text = "";
	}
	public void Savew () {
		w = w1.text;
		w2.text = w;
		w1.text = "";
	}
	public void Savec () {

		c= c1.text;
		c2.text = c;
		c1.text = "";
	}
	public void Savek () {
		k = k1.text;
		k2.text = k;
		k1.text = "";
	}
	public void set(){
		//データのセットがないアカウントの体型データを保存
		other.set (float.Parse (SaveScript.h), float.Parse (SaveScript.c), float.Parse (SaveScript.w), float.Parse (SaveScript.k));
	}
}
