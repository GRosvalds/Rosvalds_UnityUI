using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputOutput : MonoBehaviour {

	private string vards;
	private int gadi;
	public GameObject Vards;
	public GameObject Gadi;
	public GameObject Izvade;

	public void NolasitTekstu(){
		vards = Vards.GetComponent<Text>().text;
		gadi = int.Parse(Gadi.GetComponent<Text>().text);
		Izvade.GetComponent<Text>().text = 
			vards+" ir "+gadi+" gadus vecs!";
	}		
}
