using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SholderJudge : MonoBehaviour {

	float S_s_S=43.5f;
	float S_s_MS=44.0f;
	float S_s_ML=44.5f;
	float S_s_L=45.0f;

	float M_s_S=45.0f;
	float M_s_MS=46.0f;
	float M_s_ML=47.0f;
	float M_s_L=48.0f;

	float L_s_S=48.0f;
	float L_s_MS=48.5f;
	float L_s_ML=49.0f;
	float L_s_L=50.0f;

	public Text S;
	string s = " 大きめ";
	string ms = " やや大きめ";
	string mm = " ちょうど良い";
	string ml = " やや小さめ";
	string l = " 小さめ";
	Modeldata human;

	string st;
	void Start(){
		st = S.text;
	}

	public void sizechk_s(){
		human=SetText.human;
		S_s_j_mens (human);	
	}
	public void sizechk_m(){
		human = SetText.human;
		M_s_j_mens (human);
	}
	public void sizechk_l(){
		human = SetText.human;
		L_s_j_mens (human);
	}

	// Use this for initialization
	public void S_s_j_mens(Modeldata man){
		S.text = st;
		if (S_s_S > man.sholder) {
			S.text += s;
		} else if (S_s_S <= man.sholder && man.sholder <= S_s_MS) {
			S.text += ms;
		} else if (S_s_MS <= man.sholder && man.sholder <= S_s_ML) {
			S.text += mm;
		} else if (S_s_ML <= man.sholder && man.sholder <= S_s_L) {
			S.text += ml;
		} else if (S_s_L < man.sholder) {
			S.text += l;
		}
	}

	public void M_s_j_mens (Modeldata man)
	{S.text = st;

		if (M_s_S > man.sholder) {
			S.text += s;
		} else if (M_s_S <= man.sholder && man.sholder <= M_s_MS) {
			S.text += ms;
		} else if (M_s_MS <= man.sholder && man.sholder <= M_s_ML) {
			S.text += mm;
		} else if (M_s_ML <= man.sholder && man.sholder <= M_s_L) {
			S.text += ml;
		} else if (M_s_L < man.sholder) {
			S.text += l;
		}
	}

	public void L_s_j_mens (Modeldata man)
	{S.text = st;
		if (L_s_S > man.sholder) {
			S.text += s;
		} else if (L_s_S <= man.sholder && man.sholder <= L_s_MS) {
			S.text += ms;
		} else if (L_s_MS <= man.sholder && man.sholder <= L_s_ML) {
			S.text += mm;
		} else if (L_s_ML <= man.sholder && man.sholder <= L_s_L) {
			S.text += ml;
		} else if (L_s_L < man.sholder) {
			S.text += l;
		}
	}


}