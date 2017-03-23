using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Sample : MonoBehaviour {

	public int Width = 960;
	public int Height = 540;
	public int FPS = 12;


	//CanvasのUIに紐付けてください。///////////
	public RawImage qrCodeImage;//生成したQRコード
	public int resultText=-1;//読み取り結果

	private WebCamTexture webcamTexture;
	private  PQRCodeManager qrManager;
	public GameObject Quad;
	public GameObject pop;


	// Use this for initialization
	void Start () {
		
		var euler = transform.localRotation.eulerAngles;
		//カメラ準備
		WebCamDevice[] devices = WebCamTexture.devices;
		if(Application.platform == RuntimePlatform.IPhonePlayer||Application.platform == RuntimePlatform.Android){
			transform.localRotation = Quaternion.Euler( euler.x, euler.y, euler.z - 90 );
		}
		webcamTexture = new WebCamTexture(devices[0].name,Width,Height,FPS);
		GetComponent<Renderer> ().material.mainTexture = webcamTexture;
		webcamTexture.Play();
		

		pop.SetActive (false);
		//QRコード管理クラス
		this.qrManager = new PQRCodeManager ();

	}
	// Update is called once per frame
	void Update () {
		//カメラから読み取り
		if(resultText== -1) {
			resultText = this.qrManager.read (webcamTexture);
		}
	}


	/// <summary>
	/// QRコード生成
	/// </summary>
	public void createQRCode(){
		Debug.Log ("createQRCode");
		string inputText = "http://test.ppen.info";


		Texture2D texture = new Texture2D (256, 256);
		qrCodeImage.texture = texture;
		this.qrManager.create (inputText,(Texture2D)qrCodeImage.texture);
	}
}