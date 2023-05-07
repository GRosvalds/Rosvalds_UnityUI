using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour {

	public void ResetTheGame(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}

	public void Back(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex-1);
	}
	public void BackPatrick(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex-2);
	}

}
