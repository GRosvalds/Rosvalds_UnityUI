using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Images : MonoBehaviour {
	
	public GameObject kurRadit;
	public Sprite[] koRadit;
	public GameObject slaideris1;
	public GameObject slaideris2;



	public void izkritosais(int indekss){
		if (indekss == 0)
			kurRadit.GetComponent<Image> ().sprite = koRadit [0];

		else if(indekss == 1)
			kurRadit.GetComponent<Image> ().sprite = koRadit [1];

		else if(indekss == 2)
			kurRadit.GetComponent<Image> ().sprite = koRadit [2];
	}


	public void mainitLielumu(){
		float pasreizejaVertiba = slaideris1.GetComponent<Slider> ().value;
		float pasreizejaVertiba2 = slaideris2.GetComponent<Slider> ().value;
		kurRadit.transform.localScale = 
			new Vector2 (1f*pasreizejaVertiba, 1f*pasreizejaVertiba2);
	}


}
