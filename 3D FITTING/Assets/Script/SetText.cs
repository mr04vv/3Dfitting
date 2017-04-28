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
		//事前にデータをセットいている関数
		len.set (169.2f, 91.0f, 73.4f, 47.1f);
		mo_ri_.set (170.1f, 83.1f, 64.8f, 48.3f);
		kishi.set (185.3f, 91.3f, 77.0f, 48.0f);
		other.set (float.Parse(SaveScript.h), float.Parse(SaveScript.c), float.Parse(SaveScript.w), float.Parse(SaveScript.k));
	
	}

	public void textload(Modeldata i){
		//modeldata型の変数の保持する値をT,W,C,Sにstring型に変換して少数第一位にして代入
		T.text = i.height.ToString ("N1")+" cm";
		W.text = i.west.ToString ("N1")+" cm";
		C.text = i.chest.ToString ("N1")+" cm";
		S.text = i.sholder.ToString("N1")+" cm";
	}

	public void nodata(Modeldata i){
		//セットしてないデータの名前が来た時に動作するメソッド
		if (SaveScript.h != "") { //身長の入力があれば
			T.text = SaveScript.h + " cm"; //それをTに代入
		} else {
			T.text = "no data";  //入力がなければno dataを出力
		}
		if (SaveScript.w != "") {
			W.text = SaveScript.w + " cm";
		} else {
			W.text = "no data";
		}
		if (SaveScript.c != "") {
			C.text = SaveScript.c + " cm";
		} else {
			C.text = "no data";
		}
		if (SaveScript.k != "") {
			S.text = SaveScript.k + " cm";
		} else {
			S.text = "no data";
		}
	}



	public void set11(){
		strID = SaveScript.str;
		if (strID == "len") {
			//idがlenであればmodeldata型の変数humanをlenにしてtextloadを実行
			human = len;
			textload (human);
		} else if (strID == "kishi") {
			human = kishi;
			textload (human);
		} else if (strID == "mo_ri_") {
			human = mo_ri_;
			textload (human);
		}else{
			//idがセット済みのデータにない場合otherを格納
			human = SaveScript.other;
			nodata (other);
		}
	}
	


}
