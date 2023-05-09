using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour {
	 
	public void PlayGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

	}
    public void PlayGamePatrick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

    }
	public void ToStart(){
		SceneManager.LoadScene(0);
	}
	public void ToEnd(){
		SceneManager.LoadScene (4);
	}
	public void QuitGame(){
		
		Application.Quit();
	}
	}

