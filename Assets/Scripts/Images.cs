using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Images : MonoBehaviour {
	
	public GameObject kurRadit;
    public GameObject bobcepure;
    public GameObject bobCepure1;
    public GameObject bobBikses;
    public GameObject bobbikses1;
    public GameObject bobKurpes;
    public GameObject bobKurpes1;
    public GameObject bobKrekls;
    public GameObject BobKrekls1;
    public GameObject Lapstina;
    public GameObject Lapstina1;
    public GameObject Patty;
    public GameObject Patty1;
    

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
        bobcepure.transform.localScale =
            new Vector2(1f * pasreizejaVertiba, 1f * pasreizejaVertiba2);
        bobCepure1.transform.localScale =
            new Vector2(1f * pasreizejaVertiba, 1f * pasreizejaVertiba2);
        bobBikses.transform.localScale =
            new Vector2(1f * pasreizejaVertiba, 1f * pasreizejaVertiba2);
        bobbikses1.transform.localScale =
            new Vector2(1f * pasreizejaVertiba, 1f * pasreizejaVertiba2);
        bobKurpes.transform.localScale =
            new Vector2(1f * pasreizejaVertiba, 1f * pasreizejaVertiba2);
        bobKurpes1.transform.localScale =
            new Vector2(1f * pasreizejaVertiba, 1f * pasreizejaVertiba2);
        bobKrekls.transform.localScale =
            new Vector2(1f * pasreizejaVertiba, 1f * pasreizejaVertiba2);
        BobKrekls1.transform.localScale =
            new Vector2(1f * pasreizejaVertiba, 1f * pasreizejaVertiba2);
        Lapstina.transform.localScale =
            new Vector2(1f * pasreizejaVertiba, 1f * pasreizejaVertiba2);
        Lapstina1.transform.localScale =
            new Vector2(1f * pasreizejaVertiba, 1f * pasreizejaVertiba2);
        Patty.transform.localScale =
            new Vector2(1f * pasreizejaVertiba, 1f * pasreizejaVertiba2);
        Patty1.transform.localScale =
            new Vector2(1f * pasreizejaVertiba, 1f * pasreizejaVertiba2);

    }


}
