using UnityEngine;
using System.Collections;

public class Win : MonoBehaviour {

	public Animator anim;

	// Use this for initialization
	void Awake () {
		anim = GetComponent<Animator> ();
	}

}
