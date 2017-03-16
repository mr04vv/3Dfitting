using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChange : MonoBehaviour {

	// Use this for initialization
	public void Register(){
		SceneManager.LoadScene ("Register");
	}
	public void Login(){
		SceneManager.LoadScene ("Log In");
	}
	public void Title(){
		SceneManager.LoadScene ("Title");
	}
	public void Model3D(){
		SceneManager.LoadScene ("3D model data");
	}
	public void Fitting(){
		SceneManager.LoadScene ("Fitting");
	}
	public void AR(){
		SceneManager.LoadScene ("AR");
	}
	public void QR(){
		SceneManager.LoadScene ("QRcode");
	}
}
