using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScreenShot : MonoBehaviour {


	public GameObject buttonn;
	public bool vertiba;

	void Update(){

			if(Input.GetKeyDown("tab")){
			StartCoroutine (CoroutineScreenshotPatrick ());
				buttonn.SetActive (vertiba);
			}

		}
	


	private IEnumerator CoroutineScreenshotPatrick(){
		yield return new WaitForEndOfFrame ();

		int width = 500;
		int height = 500;

		Texture2D screenshotTexture = new Texture2D (width, height, TextureFormat.ARGB32, false);
		Rect rect = new Rect (250, 100, width, height);
		screenshotTexture.ReadPixels (rect, 0, 0);
		screenshotTexture.Apply();

		float randomSk = Random.Range (0, 100000);
		byte[] byteArray = screenshotTexture.EncodeToPNG ();
		System.IO.File.WriteAllBytes (Application.dataPath + "/Screenshot"+randomSk+".png", byteArray);
	

	}


}