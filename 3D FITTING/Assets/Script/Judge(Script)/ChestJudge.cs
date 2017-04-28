using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestJudge : MonoBehaviour {
	//チェストの判定クラス

	//サイズSに対する４段階評価の基準
	float S_c_S=78.0f;  //以下なら（体に対して服が）大きすぎ、以上なら大きい
	float S_c_MS=84.0f;  //以上ならちょうどいい
	float S_c_ML=92.0f; //以上ならちいさい
	float S_c_L=96.0f;  //以上なら小さすぎ

	//サイズMに対する４段階評価の基準
	float M_c_S=84.0f;  
	float M_c_MS=88.0f;
	float M_c_ML=96.0f;
	float M_c_L=102.0f;

	//サイズLに対する４段階評価の基準
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
		//変数cにtext componentを指定
		//CのTextComponentには自由に指定できる。（今回はScene:3D model dataのCanvas/ScrollView/Viewport/Content/Textchest/C dataを指定）
		c = C.text;
	}

	public void sizechk_s(){
		//size Sのボタンを押した時に動作するメソッド
		//Modeldata型のhumanにSetTextクラスのhumanを指定
		//humanを以下のメソッドに引数として渡す。
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

	// サイズSに対する判定の表示
	public void S_c_j_mens(Modeldata man){
		C.text = c;
		if (S_c_S > man.chest) { //manのチェストがSのS基準より小さければ
			C.text += s;         //先ほど指定したC dataのTextにstring sを代入
								//以下も同様
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