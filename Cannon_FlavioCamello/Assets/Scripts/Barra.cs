using UnityEngine;
using System.Collections;

public class Barra : MonoBehaviour {

	public float escalaBarra;

	// Use this for initialization
	void Start () {
		//escalaBarra = this.transform.localScale.x;
		escalaBarra = this.transform.localScale.x;

	}
	
	// Update is called once per frame
	void Update () {
		/*if (escalaBarra > 0.0) {
			escalaBarra = escalaBarra - 0.10f * Time.deltaTime;
			this.transform.localScale = new Vector2(escalaBarra, 1.0f);
			print ("Baixou");
		} */
	}
	
}
