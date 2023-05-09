using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsPat : MonoBehaviour {

	public AudioClip koAtskanotPat;
	public AudioSource kurAtskanotPat;

	public void UzAttelaPat(){
		kurAtskanotPat.PlayOneShot (koAtskanotPat);
	}

	public void NoAttelaPat(){
		kurAtskanotPat.Stop ();
	}
}
