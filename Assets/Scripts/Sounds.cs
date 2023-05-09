using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour {

	public AudioSource kurAtskanotBob;
	public AudioClip koAtskanotBob;


	public void UzAttelaBob(){
		kurAtskanotBob.PlayOneShot (koAtskanotBob);
	}

	public void NoAttelaBob(){
		kurAtskanotBob.Stop ();
	}

}
