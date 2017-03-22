using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WestJudge : MonoBehaviour {

	float S_w_S=68.0f;
	float S_w_MS=70.0f;
	float S_w_ML=76.0f;
	float S_w_L=78.0f;

	float M_w_S=72.0f;
	float M_w_MS=76.0f;
	float M_w_ML=84.0f;
	float M_w_L=88.0f;

	float L_w_S=84.0f;
	float L_w_MS=86.0f;
	float L_w_ML=92.0f;
	float L_w_L=100.0f;

	public Text W;
	string s = " 大きめ";
	string ms = " やや大きめ";
	string mm = " ちょうど良い";
	string ml = " やや小さめ";
	string l = " 小さめ";
	Modeldata human;

	string w;
	void Start(){
		w = W.text;
	}

	public void sizechk_s(){
		human=SetText.human;
		S_w_j_mens (human);	
	}
	public void sizechk_m(){
		human = SetText.human;
		M_w_j_mens (human);
	}
	public void sizechk_l(){
		human = SetText.human;
		L_w_j_mens (human);
	}

	// Use this for initialization
	public void S_w_j_mens(Modeldata man){
		W.text = w;
		if (S_w_S > man.west) {
			W.text += s;
		} else if (S_w_S <= man.west && man.west <= S_w_MS) {
			W.text += ms;
		} else if (S_w_MS <= man.west && man.west <= S_w_ML) {
			W.text += mm;
		} else if (S_w_ML <= man.west && man.west <= S_w_L) {
			W.text += ml;
		} else if (S_w_L < man.west) {
			W.text += l;
		}
	}

	public void M_w_j_mens (Modeldata man)
	{W.text = w;

		if (M_w_S > man.west) {
			W.text += s;
		} else if (M_w_S <= man.west && man.west <= M_w_MS) {
			W.text += ms;
		} else if (M_w_MS <= man.west && man.west <= M_w_ML) {
			W.text += mm;
		} else if (M_w_ML <= man.west && man.west <= M_w_L) {
			W.text += ml;
		} else if (M_w_L < man.west) {
			W.text += l;
		}
	}

	public void L_w_j_mens (Modeldata man)
	{W.text = w;
		if (L_w_S > man.west) {
			W.text += s;
		} else if (L_w_S <= man.west && man.west <= L_w_MS) {
			W.text += ms;
		} else if (L_w_MS <= man.west && man.west <= L_w_ML) {
			W.text += mm;
		} else if (L_w_ML <= man.west && man.west <= L_w_L) {
			W.text += ml;
		} else if (L_w_L < man.west) {
			W.text += l;
		}
	}


}
