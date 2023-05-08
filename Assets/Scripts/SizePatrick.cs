using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SizePatrick : MonoBehaviour {


    public GameObject kurRadit;
    public GameObject Brilles;
    public GameObject Cimdi;
    public GameObject Cepure;
    public GameObject CepureSarkana;
    public GameObject Krekls;
    public GameObject KreklsZils;
    public GameObject Bikses;
    public GameObject BiksesZilas;
    public GameObject slaideris1;
    public GameObject slaideris2;
    public Sprite[] koRadit;

    public void izkritosais(int indekss)
    {
        if (indekss == 0)
            kurRadit.GetComponent<Image>().sprite = koRadit[0];

        else if (indekss == 1)
            kurRadit.GetComponent<Image>().sprite = koRadit[1];

        else if (indekss == 2)
            kurRadit.GetComponent<Image>().sprite = koRadit[2];
    }
    public void MainitLielumuPatrick()
    {
        float pasreizejaVertiba = slaideris1.GetComponent<Slider>().value;
        float pasreizejaVertiba2 = slaideris2.GetComponent<Slider>().value;
        kurRadit.transform.localScale =
                new Vector2(1f * pasreizejaVertiba, 1f * pasreizejaVertiba2);
        Brilles.transform.localScale =
                new Vector2(1f * pasreizejaVertiba, 1f * pasreizejaVertiba2);
        Cimdi.transform.localScale =
                new Vector2(1f * pasreizejaVertiba, 1f * pasreizejaVertiba2);
        Cepure.transform.localScale =
                new Vector2(1f * pasreizejaVertiba, 1f * pasreizejaVertiba2);
        CepureSarkana.transform.localScale =
                new Vector2(1f * pasreizejaVertiba, 1f * pasreizejaVertiba2);
        Krekls.transform.localScale =
                new Vector2(1f * pasreizejaVertiba, 1f * pasreizejaVertiba2);
        KreklsZils.transform.localScale =
                new Vector2(1f * pasreizejaVertiba, 1f * pasreizejaVertiba2);
        Bikses.transform.localScale =
                new Vector2(1f * pasreizejaVertiba, 1f * pasreizejaVertiba2);
        BiksesZilas.transform.localScale =
                new Vector2(1f * pasreizejaVertiba, 1f * pasreizejaVertiba2);
    }
}
