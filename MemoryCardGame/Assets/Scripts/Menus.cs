
using UnityEngine;
using System.Collections;

public class Menus : MonoBehaviour {

	public void NextScene(string nextScene){
		Application.LoadLevel(nextScene);
	}

	public void Exit(){
		Application.Quit();
	}


}
