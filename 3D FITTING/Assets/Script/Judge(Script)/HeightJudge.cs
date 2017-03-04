using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeightJudge : MonoBehaviour {

	float S_h_S=150.0f;
	float S_h_MS=157.0f;
	float S_h_ML=167.0f;
	float S_h_L=170.0f;

	float M_h_S=160.0f;
	float M_h_MS=167.0f;
	float M_h_ML=177.0f;
	float M_h_L=180.0f;

	float L_h_S=170.0f;
	float L_h_MS=177.0f;
	float L_h_ML=187.0f;
	float L_h_L=190.0f;

	public Text H;
	string s = " ゆるゆる";
	string ms = " 大きめ";
	string mm = " ちょうど良い";
	string ml = " 小さめ";
	string l = " きつきつ";
	Modeldata human;

	string h;
	void Start(){
		h = H.text;
	}

	public void sizechk_s(){
		human=SetText.human;
		S_h_j_mens (human);	
	}
	public void sizechk_m(){
		human = SetText.human;
		M_h_j_mens (human);
	}
	public void sizechk_l(){
		human = SetText.human;
		L_h_j_mens (human);
	}

	// Use this for initialization
	public void S_h_j_mens(Modeldata man){
		H.text = h;
		if (S_h_S > man.height) {
			H.text += s;
		} else if (S_h_S <= man.height && man.height <= S_h_MS) {
			H.text += ms;
		} else if (S_h_MS <= man.height && man.height <= S_h_ML) {
			H.text += mm;
		} else if (S_h_ML <= man.height && man.height <= S_h_L) {
			H.text += ml;
		} else if (S_h_L < man.height) {
			H.text += l;
		}
	}

	public void M_h_j_mens (Modeldata man)
	{H.text = h;
		
		if (M_h_S > man.height) {
			H.text += s;
		} else if (M_h_S <= man.height && man.height <= M_h_MS) {
			H.text += ms;
		} else if (M_h_MS <= man.height && man.height <= M_h_ML) {
			H.text += mm;
		} else if (M_h_ML <= man.height && man.height <= M_h_L) {
			H.text += ml;
		} else if (M_h_L < man.height) {
			H.text += l;
		}
	}

	public void L_h_j_mens (Modeldata man)
	{H.text = h;
		if (L_h_S > man.height) {
			H.text += s;
		} else if (L_h_S <= man.height && man.height <= L_h_MS) {
			H.text += ms;
		} else if (L_h_MS <= man.height && man.height <= L_h_ML) {
			H.text += mm;
		} else if (L_h_ML <= man.height && man.height <= L_h_L) {
			H.text += ml;
		} else if (L_h_L < man.height) {
			H.text += l;
		}
	}


}