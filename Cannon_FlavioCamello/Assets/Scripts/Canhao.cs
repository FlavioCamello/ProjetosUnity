using UnityEngine;
using System.Collections;

public class Canhao : MonoBehaviour {
	public GameObject tiro;

	//public Vector3 Direcao;
	//public float Velocidade;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")){
			GameEngine.instancia.SomAtirar();
			Invoke ("Atirar", 0.0f);
		}
	}

	public void Atirar(){
		float n = GetComponent<Transform>().rotation.z;
		tiro.GetComponent<Tiro> ().rotacaoTiro (n);
		Instantiate (tiro);


		tiro.transform.position = new Vector2 (GetComponent<Transform>().position.x, GetComponent<Transform>().position.y);
		//tiro.GetComponent<Rigidbody2D> ().velocity = new Vector2 (10.0f, 1.0f);
		//Quaternion vetorRotacao = new Quaternion();
	
		//print (n);


		//vetorRotacao = Quaternion.Euler rotation;
		//tiro.GetComponent<Rigidbody2D>().velocity =  
	}


}
