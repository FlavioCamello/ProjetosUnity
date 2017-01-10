using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Texto : MonoBehaviour {
	public Text pontuacaoText;
	public int pontos = 0;
	public void MarcaPonto(){
		pontos++;
		pontuacaoText.text = "Pontos: "+pontos.ToString();
	}

	// Use this for initialization
	void Start () {
		pontuacaoText.text = "Pontos: 0";
	}
	
	// Update is called once per frame
	void Update () {

	}

}
