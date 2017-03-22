using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestJudge : MonoBehaviour {

	float S_c_S=78.0f;
	float S_c_MS=84.0f;
	float S_c_ML=92.0f;
	float S_c_L=96.0f;

	float M_c_S=84.0f;
	float M_c_MS=88.0f;
	float M_c_ML=96.0f;
	float M_c_L=102.0f;

	float L_c_S=88.0f;
	float L_c_MS=94.0f;
	float L_c_ML=102.0f;
	float L_c_L=110.0f;

	public Text C;
	string s = " 大きめ";
	string ms = " やや大きめ";
	string mm = " ちょうど良い";
	string ml = " やや小さめ";
	string l = " 小さめ";
	Modeldata human;

	string c;
	void Start(){
		c = C.text;
	}

	public void sizechk_s(){
		human=SetText.human;
		S_c_j_mens (human);	
	}
	public void sizechk_m(){
		human = SetText.human;
		M_c_j_mens (human);
	}
	public void sizechk_l(){
		human = SetText.human;
		L_c_j_mens (human);
	}

	// Use this for initialization
	public void S_c_j_mens(Modeldata man){
		C.text = c;
		if (S_c_S > man.chest) {
			C.text += s;
		} else if (S_c_S <= man.chest && man.chest <= S_c_MS) {
			C.text += ms;
		} else if (S_c_MS <= man.chest && man.chest <= S_c_ML) {
			C.text += mm;
		} else if (S_c_ML <= man.chest && man.chest <= S_c_L) {
			C.text += ml;
		} else if (S_c_L < man.chest) {
			C.text += l;
		}
	}

	public void M_c_j_mens (Modeldata man)
	{C.text = c;

		if (M_c_S > man.chest) {
			C.text += s;
		} else if (M_c_S <= man.chest && man.chest <= M_c_MS) {
			C.text += ms;
		} else if (M_c_MS <= man.chest && man.chest <= M_c_ML) {
			C.text += mm;
		} else if (M_c_ML <= man.chest && man.chest <= M_c_L) {
			C.text += ml;
		} else if (M_c_L < man.chest) {
			C.text += l;
		}
	}

	public void L_c_j_mens (Modeldata man)
	{C.text = c;
		if (L_c_S > man.chest) {
			C.text += s;
		} else if (L_c_S <= man.chest && man.chest <= L_c_MS) {
			C.text += ms;
		} else if (L_c_MS <= man.chest && man.chest <= L_c_ML) {
			C.text += mm;
		} else if (L_c_ML <= man.chest && man.chest <= L_c_L) {
			C.text += ml;
		} else if (L_c_L < man.chest) {
			C.text += l;
		}
	}


}