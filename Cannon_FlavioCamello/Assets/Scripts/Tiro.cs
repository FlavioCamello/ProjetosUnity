using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Tiro : MonoBehaviour {
	public Vector3 Direcao;
	public float Velocidade;
	public GameObject fire;
	public GameObject particulaTiro;
	public GameObject particulaBat;


	// Use this for initialization
	void Start () {

		Velocidade = 10;


	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Direcao * Velocidade * Time.deltaTime;
	}

	void OnCollisionEnter2D (Collision2D colisor){
		//Vector2 normal = colisor.contacts [0].normal;
		GeradorDeArestas geradorDeArestas = colisor.transform.GetComponent<GeradorDeArestas> ();
		// se acertar aresta
		if(geradorDeArestas != null){
			//if(normal == Vector2.up){
			GameObject particulas = (GameObject)Instantiate(particulaTiro, transform.position, Quaternion.identity);
			ParticleSystem componenteParticula = particulas.GetComponent<ParticleSystem>();
			Destroy(particulas, componenteParticula.startLifetime+ componenteParticula.duration);
			Destroy(this.gameObject);
				
		}//else{
			   // Direcao = Vector3.Reflect (Direcao, normal);
				//Direcao.Normalize ();
			//}
		//se acertar o morcego
		else{
			if(colisor.gameObject.tag.Equals("Finish")){
				GameEngine.instancia.SomMatarMorcego();
				Camera.main.GetComponent<Texto>().MarcaPonto();
				GameObject particulas = (GameObject)Instantiate(particulaBat, transform.position, Quaternion.identity);
				ParticleSystem componenteParticula = particulas.GetComponent<ParticleSystem>();
				Destroy(particulas, componenteParticula.startLifetime+ componenteParticula.duration);




				//GameObject objeto = (GameObject) GameObject.FindWithTag ("Text");
				//objeto.Text.text = "Pontos: "+GameEngine.pontuacao;

				Destroy (colisor.gameObject);
				Destroy (this.gameObject);
			}		
		}

	}

	public void rotacaoTiro(float rotation){

		if (rotation > 0.0) {
			if (rotation > 0.25 && rotation < 0.35) {
				print ("Atirei");
				Direcao = new Vector2 (-0.25f, 0.35f);
				Direcao.Normalize ();
			} else {
				if (rotation > 0.40) {
					Direcao = new Vector2 (-1.0f, 0.4f);
					Direcao.Normalize ();
				} else {
					if (rotation > 0.35 && rotation < 0.4) {
						Direcao = new Vector2 (-0.35f, 0.4f);
						Direcao.Normalize ();
					} else {
						if (rotation > 0.15 && rotation < 0.25) {
							Direcao = new Vector2 (-0.15f, 0.25f);
							Direcao.Normalize ();
						} else {
							if (rotation > 0.05 && rotation < 0.15) {
								Direcao = new Vector2 (-0.05f, 0.15f);
								Direcao.Normalize ();
							} else {
								if (rotation < 0.05 && rotation > 0.00) {
									Direcao = new Vector2 (0.0f, 1.0f);
									Direcao.Normalize ();
								}
							}
						}
					}
				}
			}
		} else {
			if (rotation < -0.25 && rotation > -0.35) {
				print ("Atirei");
				Direcao = new Vector2 (0.25f, 0.35f);
				Direcao.Normalize ();
			} else {
				if (rotation < -0.40) {
					Direcao = new Vector2 (1.0f, 0.4f);
					Direcao.Normalize ();
				} else {
					if (rotation < -0.35 && rotation > -0.4) {
						Direcao = new Vector2 (0.35f, 0.4f);
						Direcao.Normalize ();
					} else {
						if (rotation < -0.15 && rotation > -0.25) {
							Direcao = new Vector2 (0.15f, 0.25f);
							Direcao.Normalize ();
						} else {
							if (rotation < -0.05 && rotation > -0.15) {
								Direcao = new Vector2 (0.05f, 0.15f);
								Direcao.Normalize ();
							} else {
								if (rotation > -0.05 && rotation < 0.00) {
									Direcao = new Vector2 (0.0f, 1.0f);
									Direcao.Normalize ();
								}
							}
						}
					}
				}
			}
		}
	}
}


