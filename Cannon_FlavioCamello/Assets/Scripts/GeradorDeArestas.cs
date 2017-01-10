using UnityEngine;
using System.Collections;

public class GeradorDeArestas : MonoBehaviour {

	EdgeCollider2D colisor;
	// Use this for initialization
	void Start () {
		Camera cam = Camera.main;
		colisor = GetComponent<EdgeCollider2D> ();
		Vector2 cantoInferiorEsquerdo = cam.ScreenToWorldPoint (new Vector3 (0.0f, 0.0f, 0.0f));
		Vector2 cantoSuperiorEsquerdo = cam.ScreenToWorldPoint (new Vector3 (0.0f, Screen.height, 0.0f));
		Vector2 cantoSuperiorDireito = cam.ScreenToWorldPoint (new Vector3 (Screen.width, Screen.height, 0.0f));
		Vector2 cantoInferiorDireito = cam.ScreenToWorldPoint (new Vector3 (Screen.width, 0.0f, 0.0f));
		colisor.points = new Vector2[5] {
			cantoInferiorEsquerdo,
			cantoSuperiorEsquerdo,
			cantoSuperiorDireito,
			cantoInferiorDireito,
			cantoInferiorEsquerdo
		};
	}
	
	// Update is called once per frame
	void Update () {
		InvokeRepeating ("EnquadraArestas", 4.0f, 1.0f);

	}

	public void EnquadraArestas(){
		Camera cam = Camera.main;
		colisor = GetComponent<EdgeCollider2D> ();
		Vector2 cantoInferiorEsquerdo = cam.ScreenToWorldPoint (new Vector3 (0.0f, 0.0f, 0.0f));
		Vector2 cantoSuperiorEsquerdo = cam.ScreenToWorldPoint (new Vector3 (0.0f, Screen.height, 0.0f));
		Vector2 cantoSuperiorDireito = cam.ScreenToWorldPoint (new Vector3 (Screen.width, Screen.height, 0.0f));
		Vector2 cantoInferiorDireito = cam.ScreenToWorldPoint (new Vector3 (Screen.width, 0.0f, 0.0f));
		colisor.points = new Vector2[5] {
			cantoInferiorEsquerdo,
			cantoSuperiorEsquerdo,
			cantoSuperiorDireito,
			cantoInferiorDireito,
			cantoInferiorEsquerdo
		};
		CancelInvoke ();
	}
}
