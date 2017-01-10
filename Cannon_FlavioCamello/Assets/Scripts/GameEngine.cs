using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameEngine : MonoBehaviour {
	public GameObject canvasGo;
	public GameObject newBat;
	public Canhao canhao;
	public static bool comecou = false;
	public AudioClip audioAtira;
	public AudioClip audioMatarMorcego;
	public static GameEngine instancia;
	void Awake(){
		instancia = this;
	}

	public void SomAtirar(){
		GetComponent<AudioSource> ().PlayOneShot (audioAtira);
	}

	public void SomMatarMorcego(){
		GetComponent<AudioSource> ().PlayOneShot (audioMatarMorcego);
	}

	public void FinalizarJogo(){
		GameObject[] objetos;
		objetos = GameObject.FindGameObjectsWithTag("Finish");
		canhao.enabled = false;
		canvasGo.SetActive (true);
		for (int i=0; i<objetos.Length; i++) {
			Destroy(objetos[i]);
		}
		CancelInvoke ();

	}

	public void IniciarJogo(){
		comecou = true;
		print ("iniciar ogo");
		Application.LoadLevel ("Scene1");

	}

	//public static void MarcaPonto(){
	//	pontuacao++;
	//	pontuacaoText.text = "Pontos: "+pontuacao;
	//}
	// Use this for initialization

	void Start () {
		//canvasGo = (GameObject)GameObject.FindGameObjectWithTag ("CanvasGo");

		canvasGo.SetActive (false);
		InvokeRepeating ("CreateBat", 1.0f, 2.8f);
		InvokeRepeating ("PosicionarLife", 1.0f, 4.0f);
		if (!comecou) {
			Invoke("FinalizarJogo", 0.0f);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PosicionarLife(){
		Camera cam = Camera.main;
		GameObject objeto = (GameObject) GameObject.FindGameObjectWithTag ("Life"); 
		Vector3 localBarra = cam.ScreenToWorldPoint(new Vector3(70.0f, Screen.height - 25.0f, 10.0f));
		objeto.transform.position = localBarra;
	}

	public void CreateBat(){
		Instantiate (newBat);

	}




}
