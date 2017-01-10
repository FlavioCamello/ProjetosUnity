using UnityEngine;
using System.Collections;

public class ScriptBat : MonoBehaviour {


	Camera cam = Camera.main;
	public Vector3 Direcao;
	public float Velocidade;
	Vector3 limite;
	//static bool chamouAtualizadorTela = false;
//	public GameObject teste;

	// Use this for initialization
	void Start () {

		Direcao = new Vector2 (-1.0f, -0.1f);
		Direcao.Normalize ();
		//GetComponent<Rigidbody2D> ().velocity = new Vector2 (-1.0f, -0.5f);
		transform.position = cam.ScreenToWorldPoint(new Vector3( Screen.width, Screen.height, 10.0f));
		limite = cam.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0.0f));
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Direcao * Velocidade * Time.deltaTime;
		
		if (transform.position.x < -(limite.x)) {
			Direcao = new Vector2 (1.0f, -0.1f);
		} else {
			if (transform.position.x > limite.x) {
				Direcao = new Vector2 (-1.0f, -0.1f);
			}
		}
		if (transform.position.y < -(limite.y)) {
			Destroy (this.gameObject);
			GameObject teste = (GameObject) GameObject.Find ("ObjetoBarra"); 
			float escalaBarra = teste.transform.localScale.x;
			if ((escalaBarra - 10.10f * Time.deltaTime) > 0.0){

				escalaBarra = escalaBarra - 10.10f * Time.deltaTime;
				teste.transform.localScale = new Vector2(escalaBarra, 1.0f);
			}else{
				GameEngine.instancia.FinalizarJogo();
			}
		}
		//if (!chamouAtualizadorTela) {
		//	chamouAtualizadorTela = true;
			InvokeRepeating ("AtualizaTamanhoTela", 4.0f, 1.0f);

	}

	public void AtualizaTamanhoTela(){
		limite = cam.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0.0f));
		//chamouAtualizadorTela = false;

		CancelInvoke ();
	}
	/*void OnCollisionEnter2D(Collision2D colisor){
		
		Vector2 normal = colisor.contacts [0].normal;
		if (normal == Vector2.up) {
		}
		
	}*/


	
}
